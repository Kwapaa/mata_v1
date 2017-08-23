using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mata_v1
{
    class Displayer
    {
        private PictureBox _pBox;
        private SolidBrush brush;
        public Displayer(PictureBox pBox)
        {
            _pBox = pBox;
        }

        public void preparePictureBox()
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
    }
    
}
