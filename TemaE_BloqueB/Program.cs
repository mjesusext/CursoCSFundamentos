using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaE_BloqueB
{
    class Program
    {
        static void Main(string[] args)
        {
            #region EjercicioJKLM
            /*Usuario UsuarioA = new Usuario("Manuel", TipoUsuario.Lector);
            Usuario UsuarioB = new Usuario("Antonio", TipoUsuario.Lector | TipoUsuario.OperadorInformes);
            Usuario UsuarioC = new Usuario("María", TipoUsuario.Lector | TipoUsuario.OperadorInformes | TipoUsuario.GestorUsuarios | TipoUsuario.Administrador);

            Console.WriteLine("Manuel es gestor de usuarios?: " + EsGestorDeUsuarios(UsuarioA));
            Console.WriteLine("Antonio es gestor de usuarios?: " + EsGestorDeUsuarios(UsuarioB));
            Console.WriteLine("María es gestora de usuarios?: " + EsGestorDeUsuarios(UsuarioC));
            Console.WriteLine("Manuel es administrador?: " + EsAdministrador(UsuarioA));
            Console.WriteLine("Antonio es administrador?: " + EsAdministrador(UsuarioB));
            Console.WriteLine("María es administradora?: " + EsAdministrador(UsuarioC));
            */
            #endregion

            #region Ejercicio NOPQRST
            /*Superman sup1 = new Superman();
            IAvion sup2 = sup1;
            IPajaro sup3 = sup1;

            //Ejercicio T: Al crear implementación explicita, no podemos llamar a Volar a secas porque colisiona.
            //sup1.Volar();
            //sup1.Aletear();
            IAvion sup1Avion = sup1 as IAvion;
            IPajaro sup1Pajaro = sup1 as IPajaro;
            sup1Avion.Volar();
            sup1Pajaro.Volar();
            sup1Pajaro.Aletear();
            //Al tratarlo como avión, no sabe aletear
            sup2.Volar();
            //sup2.Aletear();
            //Al tratarlo como pájaro, sabe hacer ambas cosas. Solo tiene una definición de volar para todas las implementaciones.
            sup3.Volar();
            sup3.Aletear();
            */

            #endregion

            #region EjercicioU
            Superman sup1 = new Superman();
            IAvion sup1Avion = sup1;
            IPajaro sup1Pajaro = sup1;
            sup1.Aletear();
            sup1.Volar();
            sup1Avion.Volar();
            sup1Pajaro.Aletear();
            sup1Pajaro.Volar();
            #endregion

            Console.ReadLine();
        }

        #region EjercicioJKLM
        public static Boolean EsGestorDeUsuarios(Usuario User)
        {
            return User.Tipo.HasFlag(TipoUsuario.GestorUsuarios);
        }

        public static Boolean EsAdministrador(Usuario User)
        {
            return User.Tipo.HasFlag(TipoUsuario.Administrador);
        }
        #endregion
    }
}
