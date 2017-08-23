using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace mata_v1
{
    class Bitmaper
    {
        private SolidBrush brush;
        private Packet _packet;
        public List<Packet> _packetList;

        private const byte _STX = 0x53;
        private const byte _ETX = 0xA;
        private const byte _DLE = 0x44;
        private const byte _sBitmap = 0x46;
        private bool _working = true;

        private Logic _logic;
        private Map _map;

        private Color _myColor;

        public Bitmaper(List<Packet> packetList, Logic logic)
        {
            _packetList = packetList;
            _logic = logic;
        }

        public void buildBitmap()
        {
            int _sx, _sy, pixelX, pixelY;
            int packetSz = 0, force = 0, sumForce = 0;
            int pcktNum = _packetList.Count();
            byte[] buffer = new byte[12000];
            //_map = new Map(80, 40);;

            

           
            Bitmap _bitmap;

            Pen pen = new Pen(Color.White)
            {
                Alignment = PenAlignment.Inset,
                Width = 0.05f
            };

            _bitmap = new Bitmap(400, 200, PixelFormat.Format32bppArgb);
            Graphics graphicsBitmap = Graphics.FromImage(_bitmap);
            while (_working)
            {
                while (_packetList.Count() > 0)
                {
                    _packet = _packetList.ElementAt(0);
                    buffer = _packet.getBuffer();
                    sumForce = 0;
                    if (buffer[0] == _STX && buffer[1] == _sBitmap)
                    {
                        _sx = buffer[2] + buffer[3] * 256;
                        _sy = buffer[4] + buffer[5] * 256;
                        if (_sx != 80 || _sy != 40)
                        {
                            break;
                            _logic.updateConsoleDuoBox("nieprawidlowa dlugosc ramki \n ");
                            _logic.updateConsoleDuoBox("\n");
                        }
                        packetSz = 5;

                        pixelX = 0;
                        pixelY = 0;

                        for (int j = 6; j < _packet.getPacketSz() - 5; j += 2)
                        {
                            if (buffer[j] == _DLE)
                                j++;
                            force = buffer[j] + buffer[j + 1] * 256;
                            sumForce += force;
                            packetSz += 2;
                            if (force < 100)
                                _myColor = Color.Black;
                            else
                                _myColor = percentToColor(force, 0, 1000);

                            if (packetSz < 6407)
                                for (int k = 0; k < 5; k++)
                                    for (int l = 0; l < 5; l++)
                                        _bitmap.SetPixel(pixelX * 5 + k, pixelY * 5 + l, _myColor);

                            pixelX++;

                            if (pixelX == 80)
                            {
                                pixelX = 0;
                                pixelY++;
                            }
                            

                            

                            /*Rectangle _rectangle = new Rectangle(
                                pixelX * 5,
                                pixelY * 5,
                                5,
                                5
                            );
                            if (force != 0)
                            {
                                brush = new SolidBrush(percentToColor(force, 0, 65000));
                            }
                            else
                                brush = new SolidBrush(Color.Black);
                            graphicsBitmap.DrawRectangle(pen, _rectangle);
                            graphicsBitmap.FillRectangle(brush, _rectangle);*/
                        }
                        _logic.updateConsoleDuoBox("dlugosc pakietu " + packetSz);
                        _logic.updateConsoleDuoBox("\n");
                    }
                    _logic.updatePictureBox(_bitmap);
                    _packetList.RemoveAt(0);
                }
                if (_packetList.Count() == 0)
                {
                    _logic.updateConsoleDuoBox("poczekalnia");
                    Thread.Sleep(100);
                }
            }
        }

        public Color GetColorOf(double value, double minValue, double maxValue)
        {
            if (value == 0)
                return Color.Black;

            var g = (int)(240 * value / maxValue);
            var r = (int)(240 * value / minValue);

            return (value > 0
                ? Color.FromArgb(240 - g, 255 - (int)(g * ((255 - 155) / 240.0)), 240 - g)
                : Color.Black);
                //: Color.FromArgb(255 - (int)(r * ((255 - 230) / 240.0)), 240 - r, 240 - r));
        }



        private Color percentToColor(double value, double minValue, double maxValue)
        {
            double percent = value / maxValue;
            if (percent < 0 || percent > 1)
                return Color.Black;

            int r, g;
            if (percent < 0.5)
            {
                g = 255;
                r = (int)(255 * percent / 0.5);  //closer to 0.5, closer to yellow (255,255,0)
            }
            else
            {
                r = 255;
                g = 255 - (int)(255 * (percent - 0.5) / 0.5); //closer to 1.0, closer to green (0,255,0)
            }
            return Color.FromArgb(r, g, 0);
        }

        public void setWorking (bool working)
        {
            _working = working;
        }
    }
}

