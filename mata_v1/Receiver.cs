using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mata_v1
{
    class Receiver
    {
        private Logic _logic;

        private SerialPort _serialPort = new SerialPort();
        private int _baudRate = 750000;
        private int _dataBits = 8;
        private Handshake _handshake = Handshake.None;
        private Parity _parity = Parity.None;
        private string _portName = "COM6";
        private StopBits _stopBits = StopBits.One;
        private int _ReadTimeout = 500;

        private const byte _STX = 0x53;
        private const byte _ETX = 0xA;
        private const byte _DLE = 0x44;
        private const byte _sBitmap = 0x46;

        private bool _connected = false;
        private bool _working = true;

        public delegate void Delegate(string message);
        private Form1 _form;

        public List<Packet> _packetList;
        public Packet _packet;

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

            _packetList = packetList;
        }

        public void receive()
        {
            byte[] buffer = new byte[5000];
            byte[] packet = new byte[20000];
            int packetSz = 0, bytesToRead;
            bool start = false, bDLE = false;

            _packet = new Packet();
            _working = true;
            while (_working)
            {
                try
                {
                    bytesToRead = _serialPort.Read(buffer, 0, buffer.Length);
                    for (int i = 0; i < bytesToRead; i++)
                    {
                        if (packetSz > 15000)
                        {
                            packetSz = 0;
                            start = false;
                            _logic.updateConsoleDuoBox("porzucono pakiet ");
                            _logic.updateConsoleDuoBox("\n");
                        }
                        if (bDLE == true)
                        {
                            packet[packetSz++] = buffer[0];     // zabezpieczenie na wypadek, gdy DLE pojawlo sie 
                            bDLE = false;                       // na koncu poprzedniego buffera
                        }
                        else
                            switch (buffer[i])
                            {
                                case _STX:
                                    packet[packetSz++] = buffer[i];
                                    start = true;
                                    break;

                                case _DLE:
                                    if (start == true)
                                    {
                                        if (i == bytesToRead -1)
                                        {
                                            bDLE = true;
                                            _logic.updateConsoleDuoBox("\n");
                                            _logic.updateConsoleDuoBox("DLE na koncu pakietu");
                                            packet[packetSz++] = buffer[i++];
                                        }
                                        else
                                        {
                                            packet[packetSz++] = buffer[i++];
                                            packet[packetSz++] = buffer[i];
                                        }
                                    }
                                    break;

                                case _ETX:
                                    if (start == true)
                                    {
                                        packet[packetSz] = buffer[i];
                                        _packet.setBuffer(packet);
                                        _packet.setPacketSz(packetSz);
                                        _packetList.Add(_packet);
                                        start = false;
                                        packetSz = 0;
                                    }
                                    break;

                                default:
                                    if (start == true)
                                        packet[packetSz++] = buffer[i];
                                    break;
                            }

                    }
                    /*_logic.updateConsoleBox("\n");
                    _logic.updateConsoleBox("Wczytano 500 znakow, pozostalo ");
                    _logic.updateConsoleBox(_serialPort.BytesToRead.ToString());*/

                }
                catch (TimeoutException) { }
            }


        } 



        public void connect()
        {
            
            if (COMScan())
            {
                if (!_connected)
                {
                    _serialPort.Open();
                    _logic.updateConnectBox("\nPolaczono z mata");
                    _connected = true;
                }
            }
            else
                _logic.updateConnectBox("\nNie udalo sie polaczyc z mata");
        }

        public bool COMScan()
        {
            string[] ports = SerialPort.GetPortNames();

            if (IsNullOrEmpty(ports))
            {
                _logic.updateConnectBox("Nie znaleziono zadnego portu szeregowego. \n");
                return false;
            }
            else
            {
                _logic.updateConsoleBox("Znaleziono nastepujace porty szeregowe:\n ");
                foreach (string port in ports)
                    _logic.updateConsoleBox(port + "\n");
                return true;
            }

        }
        private bool IsNullOrEmpty(string[] ports)
        {
            return ports == null || ports.Length < 1;

        }

        public void setWorking(bool working)
        {
            _working = working;
        }

        public List<Packet> getPacketList()
        {
            return this._packetList;
        }
    }
}
