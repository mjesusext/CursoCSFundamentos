using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaE_BloqueA
{
    class ColorClase
    {
        public byte r { get; set; }
        public byte g { get; set; }
        public byte b { get; set; }

        public ColorClase()
        {
            r = 0;
            g = 0;
            b = 0;
        }

        public ColorClase(byte r, byte g, byte b)
        {
            this.r = r;
            this.g = g;
            this.b = b;
        }

        //Ejercicio F
        public override string ToString()
        {
            return "rgb(" + r.ToString() + "," + g.ToString() + "," + b.ToString() + ")";
        }
    }
}
