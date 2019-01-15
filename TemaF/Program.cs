using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemaF.Clases_base;

namespace TemaF
{
    class Program
    {
        static void Main(string[] args)
        {
            #region EjercicioA

            /*int A = 3, B = 3;
            Alumno alumnoA = new Alumno();
            Alumno alumnoB = new Alumno();
            alumnoA.Nombre = "Pedro";
            alumnoB.Nombre = "Antonio";
            bool res;

            res = Igualdad<int>(A, B);
            Console.WriteLine("Método Igualdad. Variable int. Resultado: " + res.ToString());
            alumnoA = alumnoB;
            res = Igualdad<Alumno>(alumnoA, alumnoB);
            Console.WriteLine("Método Igualdad. Variable alumno. Resultado: " + res.ToString());
            Console.ReadLine();*/

            #endregion

            #region EjercicioB

            /*int A = 3, B = 3;
            Alumno alumnoA = new Alumno();
            Alumno alumnoB = new Alumno();
            Conserje conserjeA = new Conserje();
            Conserje conserjeB = new Conserje();
            Profesor profesorA = new Profesor();
            Profesor profesorB = new Profesor();

            alumnoA.Nombre = "Pedro";
            alumnoB.Nombre = "Antonio";
            conserjeA.Nombre = "Miguel";
            conserjeB.Nombre = "María";
            profesorA.Nombre = "Carlos";
            profesorB.Nombre = "Andrés";

            bool res;

            res = IgualdadB<Conserje>(conserjeA, conserjeB);
            Console.WriteLine("Método Igualdad. Variable Conserje. Resultado: " + res.ToString());
            //conserjeA = conserjeB;
            conserjeA.Nombre = "María";
            res = IgualdadB<Conserje>(conserjeA, conserjeB);
            Console.WriteLine("Método Igualdad. Variable Conserje. Resultado: " + res.ToString());
            res = IgualdadB<Profesor>(profesorA, profesorB);
            Console.WriteLine("Método Igualdad. Variable Profesor. Resultado: " + res.ToString());
            profesorA = profesorB;
            res = IgualdadB<Profesor>(profesorA, profesorB);
            Console.WriteLine("Método Igualdad. Variable Profesor. Resultado: " + res.ToString());
            Console.ReadLine();
            */
            #endregion

            #region EjercicioC

            /*bool res;
            Comparador<Conserje> comparadorA = new Comparador<Conserje>();
            res = comparadorA.Igualdad();
            Console.WriteLine("Método Igualdad (en clase comparador). Variable Conserje. Resultado: " + res.ToString());
            Console.ReadLine();*/

            #endregion

            #region EjercicioD

            /*string res = "";
            int A = 3, B = 7;
            Conserje conserjeA = new Conserje();
            Profesor profesorA = new Profesor();
            conserjeA.Nombre = "Miguel";
            conserjeA.Apellidos = "Gómez";
            profesorA.Nombre = "Carlos";
            profesorA.Apellidos = "Pérez";

            Comparador<string> comp = new Comparador<string>();
            res = comp.Union(conserjeA.Nombre,profesorA.Nombre);

            Console.WriteLine("Resultado unión: " + res);
            Console.ReadLine();*/

            #endregion

        }

        #region EjercicioA
        public static bool Igualdad<Tobjeto>(Tobjeto A, Tobjeto B)
        {
            return A.Equals(B);
        }
        #endregion

        #region EjercicioB
        public static bool IgualdadB<TIFuncionario>(TIFuncionario A, TIFuncionario B) where TIFuncionario : IFuncionario
        {
            //Los Ifuncionarios deben implementar nombre y apellidos como propiedades.
            //Los usaremos para comparar por ese criterio

            return string.Equals(A.Apellidos + ", " + A.Nombre, B.Apellidos + ", " + B.Nombre); ;
        }
        #endregion
    }
}
