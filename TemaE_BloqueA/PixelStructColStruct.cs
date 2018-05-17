using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaE_BloqueA
{
    struct PixelStructColStruct
    {
        public int x { get; set; }
        public int y { get; set; }
        public ColorStruct color { get; set; }

        public PixelStructColStruct(int x, int y, ColorStruct color)
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
