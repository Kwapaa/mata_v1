using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mata_v1
{
    class Field
    {
        private Color _clr;
        private int _force;
        private int x, y;
        public Field()
        {

        }

        public Color getClr()
        {
            return this._clr;
        }
        public int getForce()
        {
            return this._force;
        }
        public int getX()
        {
            return this.x;
        }
        public int getY()
        {
            return this.y;
        }


        public void setClr(Color color)
        {
            this._clr = color;
        }
        public void setForce(int force)
        {
            this._force = force;
        }
        public void setX(int _x)
        {
            this.x = _x;
        }
        public void setY( int _y)
        {
            this.y = _y;
        }
    }
}
