using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaE_BloqueB
{
    //Más eficiente en memoria limitar el tamaño de la variable de enumeración.
    [Flags()]
    enum TipoUsuario : byte
    {
        Lector = 0,
        OperadorInformes = 2,
        GestorUsuarios = 4,
        Administrador = 8
    }

    class Usuario
    {
        public string Nombre { get; set; }
        public TipoUsuario Tipo { get; set; }

        public Usuario(string Nombre, TipoUsuario Tipo)
        {
            this.Nombre = Nombre;
            this.Tipo = Tipo;
        }
    }
}
