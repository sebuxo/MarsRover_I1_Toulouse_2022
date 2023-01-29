using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    internal class Obstacle
    {
        public Point coordo { get; set; }

        public void setCoordo(ushort x,ushort y)
        {
            coordo = new Point(x, y);
        }

        public Point getCoordo()
        {
            return coordo; 
        }

    }
}
