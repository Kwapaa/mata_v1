using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mata_v1
{
    class Logic
    {
        private PictureBox _pBox;
        private SolidBrush brush;

        private static TextBox _tConsole;
        private static TextBox _tConsoleDuo;
        private TextBox _tConnect;

        private Receiver _receiver;
        private Displayer _displayer;
        private Bitmaper _bitmaper;

        private Packet _packet;
        public List<byte[]> packetList;

        Thread receiverTh;
        Thread bitmaperTh;
        Thread displayerTh;


        public Logic(TextBox tConsole, TextBox tConnect, PictureBox pBox, TextBox tConsoleDuo)
        {
            if (1 == 0)
                DbService.ExecuteCommand();
            else
            {

                _tConsole = tConsole;
                _tConsoleDuo = tConsoleDuo;
                _tConnect = tConnect;
                _pBox = pBox;
                _displayer = new Displayer(pBox);
                _displayer.preparePictureBox();

                packetList = new List<byte[]>();


                _receiver = new Receiver(ref packetList);

                //_packetList = new List<Packet>();

                //_receiver = new Receiver(this, _packetList);     //  OGARNAC SENS RECEIVERA !!
                _bitmaper = new Bitmaper(ref packetList, this);
            }

            
        }

        public string connect()
        {
            return _receiver.connect();
        }
        
        public void startReceiver()
        {
            receiverTh = new Thread(new ThreadStart(_receiver.StartListening));

            ////_receiver.receive();
            //receiverTh = new Thread(new ThreadStart(_receiver.receive));

            try
            {
                receiverTh.Start();

            }
            catch (ThreadStateException e)
            {
                _tConsole.Text += e;  // Display text of exception
                                      // Result says there was an error
            }
            catch (ThreadInterruptedException e)
            {
                _tConsole.Text += e;       // This exception means that the thread
                                           // was interrupted during a Wait
                                           // Result says there was an error
            }


            bitmaperTh = new Thread(new ThreadStart(_bitmaper.buildBitmap));

            try
            {
                bitmaperTh.Start();

            }
            catch (ThreadStateException e)
            {
                _tConsole.Text += e;  // Display text of exception
                                      // Result says there was an error
            }
            catch (ThreadInterruptedException e)
            {
                _tConsole.Text += e;       // This exception means that the thread
                                           // was interrupted during a Wait
                                           // Result says there was an error
            }
        }

        
        public string stopReceiver()
        {
            MessageBox.Show( _receiver.Disconnect());
            return string.Empty;
            
        }

        public string stopBitmaper()
        {
            MessageBox.Show(_bitmaper.setWorking(false));
            return string.Empty;

        }

        public void updatePictureBox(Bitmap _bmap)
        {
            _pBox.Image = _bmap;
            Thread.Sleep(50);
            if (_pBox.InvokeRequired)
            {
                _pBox.Invoke(new MethodInvoker(
                delegate ()
                {
                    _pBox.Update();
                }));
            }
            else
            {
                _pBox.Update();
            }
        }

        public static void updateConsoleBox(string txt)
        {
            //_tConsole.AppendText(txt);

            if (_tConsole.InvokeRequired)
            {
                _tConsole.Invoke(new MethodInvoker(
                delegate ()
                {
                    _tConsole.AppendText(txt);
                }));
            }
            else
                _tConsole.AppendText(txt);
        }

        public void updateConnectBox(String txt)
        {
            if (_tConnect.InvokeRequired)
            {
                _tConnect.Invoke(new MethodInvoker(
                delegate ()
                {
                    _tConnect.Text += txt;
                }));
            }
            else
                _tConnect.Text += txt;
        }


        public static void updateConsoleDuoBox(String txt)
        {
            if (_tConsoleDuo.InvokeRequired)
            {
                _tConsoleDuo.Invoke(new MethodInvoker(
                delegate ()
                {
                    _tConsoleDuo.AppendText(txt);
                }));
            }
            else
                _tConsoleDuo.AppendText(txt);
        }

    }
}
