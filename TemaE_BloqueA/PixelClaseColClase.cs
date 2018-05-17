using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaE_BloqueA
{
    class PixelClaseColClase
    {
        public int x { get; set; }
        public int y { get; set; }
        public ColorClase color { get; set; }

        public PixelClaseColClase()
        {
            x = 0;
            y = 0;
            color = new ColorClase(0, 0, 0);
        }

        public PixelClaseColClase(int x, int y, byte r, byte g, byte b)
        {
            this.x = x;
            this.y = y;
            color = new ColorClase(r, g, b);
        }
    }
}
