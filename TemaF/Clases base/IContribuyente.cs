using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaF.Clases_base
{
    interface IContribuyente
    {
        string Nombre { get; set; }
        string Apellidos { get; set; }

        void PagarImpuestos();
    }
}
