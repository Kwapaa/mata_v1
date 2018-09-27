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
        public List<byte[]> _packetList;

        private byte _STX = 0x53;
        private byte _ETX = 0xA;
        private byte _DLE = 0x44;
        private byte _sBitmap = 0x46;
        private bool _working = true;

        private static int height = MainSettings.Default.AreaHeight;
        private static int width = MainSettings.Default.AreaWidth;

        private Logic _logic;
        private Map _map;

        private Color _myColor;

        public Bitmaper(ref List<byte[]> packetList, Logic logic)
        {
            _packetList = packetList;
            _logic = logic;
        }

        public void buildBitmap()
        {
            int _sx, _sy, pixelX, pixelY, scaledPixelY = 0, scaledPixelX = 0;
            int force = 0, sumForce = 0;
            int pcktNum = _packetList.Count();
            byte[] buffer = new byte[height * width * 2 + 7];
            //_map = new Map(80, 40);;

            Bitmap _bitmap;

            Pen pen = new Pen(Color.White)
            {
                Alignment = PenAlignment.Inset,
                Width = 0.05f
            };

            _bitmap = new Bitmap(400, 200, PixelFormat.Format32bppArgb);
            Graphics graphicsBitmap = Graphics.FromImage(_bitmap);
            try
            {
                while (_working) // && _packetList.Count() > 0)
                {
                    if (_packetList.Count == 0)
                    {
                        Logic.updateConsoleDuoBox("poczekalnia");
                        Thread.Sleep(500);
                    }
                    else
                    {
                        buffer = _packetList.ElementAt(0);
                        //Logic.updateConsoleBox(string.Format("otrzymałem: {0}", buffer[0]));
                        sumForce = 0;
                        if (buffer[0] == _STX && buffer[1] == _sBitmap && buffer.Length == height * width * 2 + 7)
                        {
                            _sx = buffer[2] + buffer[3] * 256;
                            _sy = buffer[4] + buffer[5] * 256;
                            if (_sx != MainSettings.Default.AreaWidth || _sy != MainSettings.Default.AreaHeight)
                            {
                                _packetList.RemoveAt(0);
                                break;
                                //_logic.updateConsoleDuoBox("nieprawidlowa dlugosc ramki \n ");
                                //_logic.updateConsoleDuoBox("\n");
                            }

                            pixelX = 0;
                            pixelY = 0;
                            scaledPixelX = 0;
                            scaledPixelY = 0;

                            for (int j = 6; j < buffer.Length - 2; j += 2)
                            {
                                force = buffer[j] + buffer[j + 1] * 256;
                                sumForce += force;
                                if (force < 100)
                                    _myColor = Color.Black;
                                else
                                    _myColor = percentToColor(force, 0, 1000);

                                //scaledPixelX = _map.getField


                                //if (pixelY < _sy / 2)
                                //{
                                //    if (pixelX >= 10 && pixelX < _sx / 2 - 10)
                                //    {
                                //        scaledPixelY = pixelY + _sy / 2;
                                //        scaledPixelX = scaledPixelY;
                                //        scaledPixelY = _sy - pixelX - 1;
                                //    }
                                //    if (pixelX >= 50 && pixelX < _sx - 10)
                                //    {
                                //        scaledPixelY = pixelY + _sy / 2;
                                //        scaledPixelX = scaledPixelY;
                                //        scaledPixelY = _sy - pixelX - 1;
                                //    }
                                //    if (pixelX >= 10 && pixelX < _sx / 2 - 10)
                                //    {
                                //        if (pixelY < _sy / 2)
                                //            scaledPixelY = pixelY + _sy / 2;
                                //        else if (pixelY >= _sy / 2)
                                //            scaledPixelY = pixelY - _sy / 2;

                                //        scaledPixelX = scaledPixelY;
                                //        scaledPixelY = _sy - pixelX - 1;
                                //    }

                                //    /*if (pixelY < _sy / 2)
                                //        scaledPixelY = pixelY + _sy / 2;
                                //    else if (pixelY >= _sy / 2)
                                //        scaledPixelY = pixelY - _sy / 2;*/

                                for (int k = 0; k < 5; k++)
                                    for (int l = 0; l < 5; l++)
                                    {
                                        _bitmap.SetPixel(
                                            scaledPixelX * 5 + k,
                                            scaledPixelY * 5 + l,
                                            _myColor);
                                    }
                                pixelX++;
                                Logic.updateConsoleBox(string.Format("sumForce: {0}", sumForce));
                                if (pixelX == MainSettings.Default.AreaWidth)
                                {
                                    pixelX = 0;
                                    pixelY++;
                                }
                            }
                            _logic.updatePictureBox(_bitmap);
                            /*
                            for (int x =0; x < _bitmap.Width; x++)
                            {
                                for (int y=0; y< _bitmap.Height/2; y++)
                                {
                                    _myColor = _bitmap.GetPixel(x, y + _bitmap.Height / 2);
                                    _bitmap.SetPixel(x, y + _bitmap.Height / 2, _bitmap.GetPixel(x, y));
                                    _bitmap.SetPixel(x, y, _myColor);
                                }
                            }*/
                        }

                        if (_packetList.Count > 1)
                            _packetList.RemoveAt(0);
                    }
                }

            }
            catch (Exception ex)
            {
                Logic.updateConsoleBox(string.Format("Bitmaper: {0}", ex.Message));
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

        public string setWorking (bool working)
        {
            _working = working;
           return working ? "Włączono proces Bitmappera.\n" : "Wyłączono proces Bitmapera.\n";
        }
    }
}

