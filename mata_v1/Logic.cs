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

        private TextBox _tConsole;
        private TextBox _tConsoleDuo;
        private TextBox _tConnect;

        private Receiver _receiver;
        private Displayer _displayer;
        private Bitmaper _bitmaper;

        private Packet _packet;
        public List<Packet> _packetList;

        Thread receiverTh;
        Thread bitmaperTh;
        Thread displayerTh;


        public Logic(TextBox tConsole, TextBox tConnect, PictureBox pBox, TextBox tConsoleDuo)
        {
            _tConsole = tConsole;
            _tConsoleDuo = tConsoleDuo;
            _tConnect = tConnect;
            _pBox = pBox;
            _displayer = new Displayer(pBox);
            _displayer.preparePictureBox();

            _packetList = new List<Packet>();

            _receiver = new Receiver(this, _packetList);     //  OGARNAC SENS RECEIVERA !!
            _bitmaper = new Bitmaper(_packetList, this);
        }

        public void Drawing()
        {

            Pen pen = new Pen(Color.White)
            {
                Alignment = PenAlignment.Inset,
                Width = 0.05f
            };

            Bitmap bMap = new Bitmap(_pBox.Width, _pBox.Height, PixelFormat.Format32bppArgb);
            Graphics graphicsBitmap = Graphics.FromImage(bMap);
            for (int i = 0; i < _pBox.Width; i++)
            {
                for (int j = 0; j < _pBox.Height; j++)
                {
                    Rectangle rect = new Rectangle(
                        (i - 1) * 1,
                        (j - 1) * 1,
                        1,
                        1
                    );
                    brush = new SolidBrush(Color.Black);

                    graphicsBitmap.DrawRectangle(pen, rect);
                    graphicsBitmap.FillRectangle(brush, rect);

                }
            }
            _pBox.Image = bMap;
            _pBox.Update();
        }

        public void connect()
        {
            _receiver.connect();
        }
        
        public void startReceiver()
        {

            //_receiver.receive();
            receiverTh = new Thread(new ThreadStart(_receiver.receive));

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

        
        public void stopReceiver()
        {

            _receiver.setWorking(false);
            receiverTh.Abort();

            _bitmaper.setWorking(false);
            bitmaperTh.Abort();

            /*_packetList = _receiver.getPacketList();
            byte[] _packet = new byte[15000];

            _displayer = new displayer(_pBox, _packetList, this);
            displayerTh = new Thread(new ThreadStart(_displayer.start));

            try
            {
                displayerTh.Start();

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
            }*/


            
            _bitmaper.buildBitmap();
            //_receiver.close();
        }
        


        /*
        public Color GetColorOf(double value, double minValue, double maxValue)
        {
            if (value == 0 || minValue == maxValue)
                return Color.White;

            var g = (int)(240 * value / maxValue);
            var r = (int)(240 * value / minValue);

            return (value > 0
                ? Color.FromArgb(240 - g, 255 - (int)(g * ((255 - 155) / 240.0)), 240 - g)
                : Color.FromArgb(255 - (int)(r * ((255 - 230) / 240.0)), 240 - r, 240 - r));
        }
        */


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

        public void updateConsoleBox(String txt)
        {
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


        public void updateConsoleDuoBox(String txt)
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
