using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaE_BloqueA
{
    struct PixelStructColClase
    {
        public int x { get; set; }
        public int y { get; set; }
        public ColorClase color { get; set; }
        public PixelStructColClase(int x, int y, ColorClase color)
        {
            this.x = x;
            this.y = y;
            this.color = color;
        }
    }
}
