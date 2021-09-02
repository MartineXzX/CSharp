using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometría
{
    public class Punto
    {
        private int x;
        private int y;

        public int GetX
        {
            get
            {
                return this.x;
            }
        }
        public int GetY
        {
            get
            {
                return this.y;
            }
        }
        public Punto(int X, int Y)
        {
            this.x = X;
            this.y = Y;
        }
    }
}
