using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mata_v1
{
    class Receiver
    {
        private Logic _logic;

        private static SerialPort _serialPort = null;
        private int _baudRate = MainSettings.Default.BaudRate; //750000;
        private int _dataBits = MainSettings.Default.DataBits; // 8;

        private static Handshake _handshake;
        bool bHandshake = Handshake.TryParse(MainSettings.Default.Handshake, out _handshake);

        private static Parity _parity;
        bool bParity = Parity.TryParse(MainSettings.Default.Parity, out _parity);

        private static string _portName = MainSettings.Default.COM;

        private static StopBits _stopBits;
        bool bStopBits = StopBits.TryParse(MainSettings.Default.StopBits, out _stopBits);

        private int _ReadTimeout = MainSettings.Default.TimeOut; //  500;

        private const byte _STX = 0x53;
        private const byte _ETX = 0xA;
        private const byte _DLE = 0x44;
        private const byte _sBitmap = 0x46;

        private static int width = MainSettings.Default.AreaWidth;
        private static int height = MainSettings.Default.AreaHeight;

        private static int packetExpectedSize = height * width * 2 + 7;

        private static decimal difference = MainSettings.Default.PacketSizeDifference;

        //private byte _STX = Convert.ToByte(MainSettings.Default.STX); // 0x53;
        //private byte _ETX = Convert.ToByte(MainSettings.Default.ETX); // 0xA;
        //private byte _DLE = Convert.ToByte(MainSettings.Default.DLE);//0x44;
        //private byte _sBitmap = Convert.ToByte(MainSettings.Default.StartBitmapSign); //0x46;

        private bool _connected = false;
        private bool _working = true;
        private bool bDLE = false;

        public delegate void Delegate(string message);

        private List<byte[]> _packetList;
        private List<byte[]> _dataList;
        public int? packetSize = null;
        private byte[] _packet;
        private bool headerFound = false;

        private int packetsCollected = 0;
        private int packetCorrect = 0;
        private int iterator = 0;

        public Receiver(ref List<byte[]> packetList)
        {
            if (MainSettings.Default.AreaHeight != 0 && MainSettings.Default.AreaWidth != 0)
                _packet = new byte[MainSettings.Default.AreaHeight * MainSettings.Default.AreaWidth * 2 + 7];
            else
                throw new Exception("Nie podano rozmiarow maty !");

            if (_serialPort == null)
                _serialPort = new SerialPort(
                    _portName,
                    _baudRate,
                    _parity,
                    _dataBits,
                    _stopBits);
            _packetList = packetList;
            _dataList = new List<byte[]>();
        }

        public Receiver(Logic logic, List<Packet> packetList)
        {
            _logic = logic;
            _serialPort.BaudRate = _baudRate;
            _serialPort.DataBits = _dataBits;
            _serialPort.Handshake = _handshake;
            _serialPort.Parity = _parity;
            _serialPort.PortName = _portName;
            _serialPort.StopBits = _stopBits;
            _serialPort.ReadTimeout = _ReadTimeout;

            //_packetList = packetList;
        }
        public string connect()
        {
            if (_serialPort != null && !_serialPort.IsOpen)
            {
                _serialPort.Open();
                return _serialPort.IsOpen ? "Polaczono" : "blad";
            }
            else
                return "Juz jestes polaczony z mata.";
        }
        public string Disconnect()
        {
            _working = false;
            Thread.Sleep(2000);
            if (_serialPort != null && _serialPort.IsOpen)
            {
                _serialPort.Close();
                return "Rozlacozno";
            }
            else
                return "Juz rozlaczono.";
        }

        public static string TestConnection()
        {
            if (_serialPort != null && !_serialPort.IsOpen)
            {
                _serialPort.Open();
                if (_serialPort.IsOpen)
                {
                    _serialPort.Close();
                    return "polaczenie OK";
                }
                return "nie udalo sie polaczyc";
                // return _serialPort.IsOpen ? "Polaczono" : "blad";
            }
            else
                return "polaczenie OK";
        }
        public void StartListening()
        {
            while (_working)
            {
                if (_serialPort != null && _serialPort.IsOpen)
                    _serialPort.DataReceived += new SerialDataReceivedEventHandler(_serialPort_DataReceived);
                try
                {
                    if (!_serialPort.IsOpen)
                        _serialPort.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        void _serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (_serialPort.IsOpen)
            {
                int dataLength = _serialPort.BytesToRead;
                byte[] data = new byte[dataLength];
                int nbrDataRead = _serialPort.Read(data, 0, dataLength);
                if (nbrDataRead == 0)
                    return;
                BuildPacket(data);
                
                if (data.Length < 2000)
                    Thread.Sleep(1000);
                data = null;
            }
        }
        public void BuildPacket(byte[] bytes)
        {
            try
            {
                //_packet[0] = Convert.ToByte(iterator);
                //_packetList.Add(_packet);
                //Logic.updateConsoleBox(string.Format("wyslałem: {0}", iterator.ToString()));
                //iterator++;
                for (int i = 0; i < bytes.Length; i++)
                {
                    if (!headerFound && bytes[i] == _STX)
                    {
                        ClearPacket();
                        _packet[packetSize.Value] = bytes[i];
                        packetSize++;
                        headerFound = true;
                    }
                    else if (headerFound && bytes[i] == _DLE)
                        bDLE = true;
                    else if (headerFound)
                    {
                        if (bDLE)
                        {
                            _packet[packetSize.Value] = bytes[i];
                            bDLE = false;
                        }
                        else if (bytes[i] == _ETX)
                        {
                            if (packetSize.Value == packetExpectedSize - 1 || Math.Abs(packetSize.Value - packetExpectedSize) < packetExpectedSize * difference / 100)
                            {
                                _packet[packetSize.Value] = bytes[i];
                                System.IO.File.WriteAllText(string.Format("{0}/binary/correct/{1}.txt", MainSettings.Default.PatientFolderPath, packetCorrect), System.Text.Encoding.Default.GetString(_packet));
                                _packetList.Add(_packet);
                                ClearPacket();
                                packetCorrect++;
                                packetsCollected++;
                                headerFound = false;
                            }
                            else
                            {
                                headerFound = false;
                                System.IO.File.WriteAllText(string.Format("{0}/binary/{1}.txt", MainSettings.Default.PatientFolderPath, packetsCollected), System.Text.Encoding.Default.GetString(_packet));
                                ClearPacket();
                                packetsCollected++;
                            }
                        }
                        else if (packetSize.Value >= 6407)
                            ClearPacket();
                        else
                            _packet[packetSize.Value] = bytes[i];
                        packetSize++;
                    }
                }
                bytes = null;
            }
            
            catch (Exception ex)
            {
                Logic.updateConsoleBox(string.Format("Receiver: {0}", ex.Message));
            }
        }

        private void ClearPacket()
        {
            _packet = null;
            _packet = new byte[MainSettings.Default.AreaHeight * MainSettings.Default.AreaWidth * 2 + 7];
            packetSize = 0;
            headerFound = false;
        }
    }
}