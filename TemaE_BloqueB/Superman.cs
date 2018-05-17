using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaE_BloqueB
{
    class Superman : IPajaro, IAvion
    {
        #region EjercicioNOPQRST

        void IPajaro.Aletear()
        {
            Console.WriteLine("Aleteando como pájaro!");
        }

        void IPajaro.Volar()
        {
            Console.WriteLine("Volando como pájaro!");
        }

        void IAvion.Volar()
        {
            Console.WriteLine("Volando como avión!");
        }

        #endregion

        #region EjercicioU
        //Tenemos las implementacions explicitas para cada interfaz, pero no una por defecto para Superman
        //Es decir, si casteamos un superman como IAVion avion = (IAvion) objeto_superman,
        //obligamos a que cumpla los métodos de IAvión, pero sigue siendo clase superman (una interface no tiene instanciación, es un contrato)
        //Para que tenga métodos únicos se puede implementar explicitamente, y luego una general como hariamos de forma implicita (sin indicar interfaz).

        //Información MS: https://msdn.microsoft.com/es-es/library/4taxa8t2.aspx

        public void Aletear()
        {
            Console.WriteLine("Aletear? Claro que si, soy superman!");
        }

        public void Volar()
        {
            Console.WriteLine("Volar? Claro que si, soy superman!");
        }

        #endregion
    }
}
