using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kvadrat
{
    public class Rectangle
    {
        public Rectangle()
        {
            this.Side = 0;
        }

        public Rectangle(uint side)
        {
            this.Side = side;
        }
        public uint Side
        {
            get;
            set;
        }
        public virtual uint GetSquare()
        {
            return this.Side * this.Side;
        }
        public virtual uint GetPerimetr()
        {
            return this.Side * 4;
        }
    }
}