using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaE_BloqueA
{
    class PixelClaseColStruct
    {
        public int x { get; set; }
        public int y { get; set; }
        public ColorStruct color { get; set; }
        public PixelClaseColStruct()
        {
            x = 0;
            y = 0;
            color = new ColorStruct(0, 0, 0);
        }

        public PixelClaseColStruct(int x, int y, ColorStruct color)
        {
            this.x = x;
            this.y = y;
            this.color = color;
        }

        //Ejercicio G
        public override string ToString()
        {
            return "(" + x.ToString() + "," + y.ToString() + ") - " + color.ToString();
        }
    }
}
