using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mata_v1
{
    class Map
    {
        private Field[,] _bitmap;
    
        public Map(int sx, int sy)
        {
            _bitmap = new Field[sx, sy];

            for (int i = 0; i < sx; i++)
                for (int j = 0; j < sy; j++)
                {
                    _bitmap[i, j] = new Field();
                    _bitmap[i, j].setForce(0);
                }


            _bitmap[2, 1].setForce(-1);
            _bitmap[2, 2].setForce(-1);
            _bitmap[2, 3].setForce(-1);
            _bitmap[2, 4].setForce(-1);

            _bitmap[3, 1].setForce(-1);
            _bitmap[3, 2].setForce(-1);
            _bitmap[3, 3].setForce(-1);

            _bitmap[4, 1].setForce(-1);
            _bitmap[4, 2].setForce(-1);

            _bitmap[5, 1].setForce(-1);
            _bitmap[5, 2].setForce(-1);

            _bitmap[6, 1].setForce(-1);
            _bitmap[7, 1].setForce(-1);
            _bitmap[8, 1].setForce(-1);


            _bitmap[2, 15].setForce(-1);
            _bitmap[2, 14].setForce(-1);
            _bitmap[2, 13].setForce(-1);
            _bitmap[2, 12].setForce(-1);

            _bitmap[3, 15].setForce(-1);
            _bitmap[3, 14].setForce(-1);
            _bitmap[3, 13].setForce(-1);

            _bitmap[4, 15].setForce(-1);
            _bitmap[4, 14].setForce(-1);

            _bitmap[5, 15].setForce(-1);
            _bitmap[6, 15].setForce(-1);

            for (int x = 2; x < 19; x++)
                _bitmap[x, 37].setForce(-1);
            for (int x = 2; x < 25; x++)
                _bitmap[x, 38].setForce(-1);
            for (int x = 2; x < 33; x++)
                _bitmap[x, 39].setForce(-1);

            _bitmap[10, 18].setForce(-1);
            _bitmap[10, 17].setForce(-1);
            _bitmap[10, 16].setForce(-1);

            _bitmap[11, 17].setForce(-1);
            _bitmap[11, 16].setForce(-1);

            _bitmap[12, 17].setForce(-1);
            _bitmap[12, 16].setForce(-1);

            _bitmap[13, 17].setForce(-1);
            _bitmap[13, 16].setForce(-1);

            _bitmap[14, 16].setForce(-1);
            _bitmap[15, 16].setForce(-1);
            _bitmap[16, 16].setForce(-1);

            for (int x = 24; x < 38; x++)
                _bitmap[x, 16].setForce(-1);
            for (int x = 29; x < 38; x++)
                _bitmap[x, 17].setForce(-1);
            for (int x = 33; x < 38; x++)
                _bitmap[x, 18].setForce(-1);
            for (int x = 35; x < 38; x++)
                _bitmap[x, 19].setForce(-1);
            _bitmap[37, 20].setForce(-1);

            for (int x = 19; x < 38; x++)
                _bitmap[x, 36].setForce(-1);
            for (int x = 23; x < 38; x++)
                _bitmap[x, 35].setForce(-1);
            for (int x = 26; x < 38; x++)
                _bitmap[x, 34].setForce(-1);
            for (int x = 29; x < 38; x++)
                _bitmap[x, 33].setForce(-1);
            for (int x = 31; x < 38; x++)
                _bitmap[x, 32].setForce(-1);
            for (int x = 33; x < 38; x++)
                _bitmap[x, 31].setForce(-1);
            for (int x = 35; x < 38; x++)
                _bitmap[x, 30].setForce(-1);
            for (int x = 36; x < 38; x++)
                _bitmap[x, 29].setForce(-1);
            _bitmap[37, 28].setForce(-1);
        }

        public int getForce(int x, int y)
        {
            return this._bitmap[x, y].getForce();
        }

        public Color getColor(int x, int y)
        {
            return this._bitmap[x, y].getClr();
        }
    
        public void setForce(int x, int y, int force)
        {
            this._bitmap[x, y].setForce(force);
        }

        public void setColor(int x, int y, Color color)
        {
            this._bitmap[x, y].setClr(color);
        }
      

    }
}
