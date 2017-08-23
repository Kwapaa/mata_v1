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

        public void setClr(Color color)
        {
            this._clr = color;
        }
        public void setForce(int force)
        {
            this._force = force;
        }
       
    }
}
