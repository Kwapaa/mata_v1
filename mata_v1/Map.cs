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
        Field[,] mapa;
        private int _sx, _sy;
        public Map(int sx, int sy)
        {
            _sx = sx;
            _sy = sy;
            mapa = new Field[_sx, _sy];
        }
        public void setMap()
        {
            for (int x = 0; x < _sx; x++)
                for (int y = 0; y < _sy; y++)
                    this.mapa[x, y].setX(-1);

            for (int y = 36; y >= 16; y--)
                for (int x = 37; x >= 10; x--)
                {
                    this.mapa[x, y].setX(36 - y);
                    this.mapa[x, y].setY(37 - x);
                }

            for (int x = 2; x < 20; x++)
            {
                for (int y = 1; y < 16; y++)
                {
                    this.mapa[x, y].setX(3 + y - 1);
                    this.mapa[x, y].setY(59 - (x - 2));
                }
                for (int y = 37; y < 40; y++)
                {
                    this.mapa[x, y].setX(2 - (y - 37));
                    this.mapa[x, y].setY(59 - (x - 2));
                }
            }

            for (int x = 21; x < 25; x++)
            {
                for (int y = 1; y < 16; y++)
                {
                    this.mapa[x, y].setX(3 + y - 1);
                    this.mapa[x, y].setY(41 - (x - 21));
                }
                for (int y = 37; y < 40; y++)
                {
                    this.mapa[x, y].setX(2 - (y - 37));
                    this.mapa[x, y].setY(41 - (x - 21));
                }
            }

            for (int x = 26; x < 30; x++)
            {
                for (int y = 1; y < 16; y++)
                {
                    this.mapa[x, y].setX(3 + y - 1);
                    this.mapa[x, y].setY(37 - (x - 26));
                }
                for (int y = 37; y < 40; y++)
                {
                    this.mapa[x, y].setX(2 - (y - 37));
                    this.mapa[x, y].setY(37 - (x - 26));
                }
            }
            for (int x = 31; x < 35; x++)
            {
                for (int y = 1; y < 16; y++)
                {
                    this.mapa[x, y].setX(3 + y - 1);
                    this.mapa[x, y].setY(33 - (x - 31));
                }
                for (int y = 37; y < 40; y++)
                {
                    this.mapa[x, y].setX(2 - (y - 37));
                    this.mapa[x, y].setY(33 - (x - 31));
                }
            }
            for (int x = 36; x < 38; x++)
            {
                for (int y = 1; y < 16; y++)
                {
                    this.mapa[x, y].setX(3 + y - 1);
                    this.mapa[x, y].setY(29 - (x - 36));
                }
                for (int y = 37; y < 40; y++)
                {
                    this.mapa[x, y].setX(2 - (y - 37));
                    this.mapa[x, y].setY(29 - (x - 36));
                }
            }


            this.mapa[2, 1].setX(-1);
            this.mapa[2, 2].setX(-1);
            this.mapa[2, 3].setX(-1);
            this.mapa[2, 4].setX(-1);

            this.mapa[3, 1].setX(-1);
            this.mapa[3, 2].setX(-1);
            this.mapa[3, 3].setX(-1);

            this.mapa[4, 1].setX(-1);
            this.mapa[4, 2].setX(-1);

            this.mapa[5, 1].setX(-1);
            this.mapa[5, 2].setX(-1);

            this.mapa[6, 1].setX(-1);
            this.mapa[7, 1].setX(-1);
            this.mapa[8, 1].setX(-1);


            this.mapa[2, 15].setX(-1);
            this.mapa[2, 14].setX(-1);
            this.mapa[2, 13].setX(-1);
            this.mapa[2, 12].setX(-1);

            this.mapa[3, 15].setX(-1);
            this.mapa[3, 14].setX(-1);
            this.mapa[3, 13].setX(-1);

            this.mapa[4, 15].setX(-1);
            this.mapa[4, 14].setX(-1);

            this.mapa[5, 15].setX(-1);
            this.mapa[6, 15].setX(-1);

            for (int x = 2; x < 19; x++)
                this.mapa[x, 37].setX(-1);
            for (int x = 2; x < 25; x++)
                this.mapa[x, 38].setX(-1);
            for (int x = 2; x < 33; x++)
                this.mapa[x, 39].setX(-1);

            this.mapa[10, 18].setX(-1);
            this.mapa[10, 17].setX(-1);
            this.mapa[10, 16].setX(-1);

            this.mapa[11, 17].setX(-1);
            this.mapa[11, 16].setX(-1);

            this.mapa[12, 17].setX(-1);
            this.mapa[12, 16].setX(-1);

            this.mapa[13, 17].setX(-1);
            this.mapa[13, 16].setX(-1);

            this.mapa[14, 16].setX(-1);
            this.mapa[15, 16].setX(-1);
            this.mapa[16, 16].setX(-1);

            for (int x = 24; x < 38; x++)
                this.mapa[x, 16].setX(-1);
            for (int x = 29; x < 38; x++)
                this.mapa[x, 17].setX(-1);
            for (int x = 33; x < 38; x++)
                this.mapa[x, 18].setX(-1);
            for (int x = 35; x < 38; x++)
                this.mapa[x, 19].setX(-1);
            this.mapa[37, 20].setX(-1);

            for (int x = 19; x < 38; x++)
                this.mapa[x, 36].setX(-1);
            for (int x = 23; x < 38; x++)
                this.mapa[x, 35].setX(-1);
            for (int x = 26; x < 38; x++)
                this.mapa[x, 34].setX(-1);
            for (int x = 29; x < 38; x++)
                this.mapa[x, 33].setX(-1);
            for (int x = 31; x < 38; x++)
                this.mapa[x, 32].setX(-1);
            for (int x = 33; x < 38; x++)
                this.mapa[x, 31].setX(-1);
            for (int x = 35; x < 38; x++)
                this.mapa[x, 30].setX(-1);
            for (int x = 36; x < 38; x++)
                this.mapa[x, 29].setX(-1);
            this.mapa[37, 28].setX(-1);
        }
        public Field getField(int x, int y)
        {
            return this.mapa[x, y];

        }
    }
}
