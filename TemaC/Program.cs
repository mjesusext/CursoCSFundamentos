using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaC
{
    class Program
    {
        static void Main(string[] args)
        {
            #region EjercicioA
            //Prueba con matriz vacía
            //Console.WriteLine(TemaD_ejercicioA(new int[] {}));
            //Prueba con matriz de valores que generen overflow al sumar
            /*try
            {
                Console.WriteLine(TemaD_ejercicioA(new int[] { 2147483646, 2147483647 }));
            }
            catch (System.OverflowException)
            {
                Console.WriteLine("Overflow: el resultado no cabe en el tipo de datos int.");
            }*/

            #endregion

            #region EjercicioB

            //Añadimos variable tonta al final para sobrecargar con "params int" sin problemas (exige ser el último)
            //Console.WriteLine(TemaD_ejercicioA(1,2,3));

            #endregion

            #region EjercicioC

            /*string s1 = "Hola";
            string s2 = "Adios";

            TemaD_ejercicioC(ref s1, ref s2);

            Console.WriteLine(s1); //Esto imprime "Adios"
            Console.WriteLine(s2); // Esto imprime "Hola"*/

            #endregion

            #region EjercicioDvA

            /*try
            {
                Console.WriteLine(TemaD_ejercicioDvA(2, 8));
                Console.WriteLine(TemaD_ejercicioDvA(256,256));
            }
            catch (System.OverflowException)
            {
                Console.WriteLine("Overflow: el resultado no cabe en el tipo de datos int.");
            }*/

            #endregion

            #region EjercicioDvB

            /*try
            {
                Console.WriteLine(TemaD_ejercicioDvB(2, 8));
                Console.WriteLine(TemaD_ejercicioDvB(256, 256));
            }
            catch (System.OverflowException)
            {
                Console.WriteLine("Overflow: el resultado no cabe en el tipo de datos int.");
            }*/

            #endregion

            #region EjercicioE
            /*Curso curso = new Curso("Prueba curso", 239.20d, 50);
            curso.MostrarInfo();
            curso.CalcularPrecio();*/
            #endregion

            #region EjercicioF
            /*CursoOnline curso_online = new CursoOnline("Prueba curso on-line", 339.20d, 60, "http://www.google.com");
            curso_online.MostrarInfo();
            curso_online.CalcularPrecio();*/
            #endregion

            #region EjercicioGyH
            /*CursoAMedidaAbstracto curso_medida = new CursoAMedidaAbstracto("Prueba curso on-line", 100d, 6, "Carlos Ruíz", 25);
            CursoAMedidaAbstracto curso_medidaB = new CursoAMedidaAbstracto("Prueba curso on-line B", 100d, 10, "Miguel Pérez", 30);
            CursoAMedidaAbstracto curso_medidaC = new CursoAMedidaAbstracto("Prueba curso on-line C", 100d, 10, "María Rodríguez", 90);

            curso_medida.MostrarInfo();
            curso_medida.CalcularPrecio();
            Console.WriteLine();

            curso_medidaB.MostrarInfo();
            curso_medidaB.CalcularPrecio();
            Console.WriteLine();

            curso_medidaC.MostrarInfo();
            curso_medidaC.CalcularPrecio();
            Console.WriteLine();*/
            #endregion

            #region EjercicioI
            /*CursoAbstracto[] cursos = new CursoAbstracto[2];
            cursos[0] = new CursoOnlineAbstracto("Prueba curso on-line abstracto", 100d, 6, "http://www.google.es");
            cursos[1] = new CursoAMedidaAbstracto("Prueba de curso medida abstracto", 100d, 10, "María Rodríguez", 90);

            foreach (CursoAbstracto curso in cursos)
            {
                curso.MostrarInfo();
                Console.WriteLine();
            }*/
            #endregion

            #region EjercicioJ
            /*CursoAMedidaAbstracto curso_medida = new CursoAMedidaAbstracto("Prueba curso medida ", 100d, 10, "Maria López", 75);
            for (int i = 0; i < curso_medida.NumAlumnos; i++)
            {
                curso_medida.MatricularAlumno(new Alumno("Alumno #" + (i+1).ToString()));
                Console.WriteLine(curso_medida.alumnos[i].Nombre + " registrado.");
            }*/
            #endregion

            #region EjercicioK
            /*CursoAMedidaAbstracto curso_medida = new CursoAMedidaAbstracto("Prueba curso medida ", 100d, 10, "Maria López", 75);
            for (int i = 0; i < curso_medida.NumAlumnos; i++)
            {
                curso_medida.MatricularAlumno(new Alumno("Alumno #" + (i + 1).ToString()));
                Console.WriteLine(curso_medida[i+1] + " registrado.");
            }*/
            #endregion

            #region EjercicioL
            /* CursoAMedidaAbstracto curso_medida = new CursoAMedidaAbstracto("Prueba curso medida ", 100d, 10, "Maria López", 75);
             curso_medida.OnAlumnoMatriculado += new AlumnoMatriculadoEventHandler(MostrarAlumnoMinusculasHandler);
             curso_medida.OnAlumnoMatriculado += new AlumnoMatriculadoEventHandler(MostrarAlumnoMayusculasHandler);
             for (int i = 0; i < curso_medida.NumAlumnos; i++)
             {
                 curso_medida.MatricularAlumno(new Alumno("Alumno #" + (i + 1).ToString()));
             }*/

            #endregion

            #region EjercicioM
            CursoAMedidaAbstracto curso_medida = new CursoAMedidaAbstracto("Prueba curso medida ", 100d, 75, "Maria López", 90);
            CursoAMedidaAbstracto curso_medidaB = new CursoAMedidaAbstracto("Prueba curso medida B ", 100d, 75, "Carlos Gómez", 90);
            for (int i = 0; i < 20; i++)
            {
                curso_medida.MatricularAlumno(new Alumno("Alumno #A" + (i + 1).ToString()));
            }

            for (int i = 0; i < 15; i++)
            {
                curso_medidaB.MatricularAlumno(new Alumno("Alumno #B" + (i + 1).ToString()));
            }
            #endregion

            Console.WriteLine("Total de matriculados: " + CursoAMedidaAbstracto.matriculados.ToString());
            Console.ReadLine();
        }

        //Modificado para cumplir ejercicio B
        public static int TemaD_ejercicioA(int[] valores, bool VarTontaSobrecarga = true)
        {
            //Al inicializar resultado, si el for no itera, siempre retornaremos valor correcto.
            int resultado = 0;

            //Control de overflow en la misma función con bloque checked. Lo lanzamos a nivel superior para decidir mensaje.
            //Si fuera instrucción normal lo haríamos con checked(instrucción)
            for (int i = 0; i < valores.Length; i++)
            {
                try
                {
                    checked
                    {
                        resultado += valores[i];
                    }
                }
                catch (System.OverflowException)
                {
                    throw;
                }
            }

            return resultado;
        }

        //Ejercicio B
        public static int TemaD_ejercicioA(params int[] valores)
        {
            //Al inicializar resultado, si el for no itera, siempre retornaremos valor correcto.
            int resultado = 0;

            //Control de overflow en la misma función con bloque checked. Lo lanzamos a nivel superior para decidir mensaje.
            //Si fuera instrucción normal lo haríamos con checked(instrucción)
            for (int i = 0; i < valores.Length; i++)
            {
                try
                {
                    checked
                    {
                        resultado += valores[i];
                    }
                }
                catch (System.OverflowException)
                {
                    throw;
                }
            }

            return resultado;
        }

        //Intercambiar
        public static void TemaD_ejercicioC(ref string A, ref string B)
        {
            string buffer = A;
            A = B;
            B = buffer;
        }

        //Potencia
        public static int TemaD_ejercicioDvA(int num_base, int num_exp)
        {
            try
            {
                return checked((int)Math.Pow((double)num_base, (double)num_exp));
            }
            catch (System.OverflowException)
            {
                throw;
            }
        }

        //Potencia: Planteamiento recursivo. Pasamos valores sin querer editar (sin ref o out)
        public static int TemaD_ejercicioDvB(int num_base, int num_exp)
        {
            int resultado;

            if (num_exp > 0)
            {
                try
                {
                    checked
                    {
                        resultado = num_base * TemaD_ejercicioDvB(num_base, num_exp - 1);
                        return resultado;
                    }
                }
                catch (System.OverflowException)
                {
                    throw;
                }
            }
            else
            {
                //Devolvemos algo que no altere resultado. Multiplicar por 1.
                return 1;
            }
        }

        //Ejercicio 13 - Crear método para asociar a delegado del evento matriculación.
        public static void MostrarAlumnoMinusculasHandler(string nombre)
        {
            Console.WriteLine("El alumno registrado es: " + nombre);
        }

        public static void MostrarAlumnoMayusculasHandler(string nombre)
        {
            Console.WriteLine("El alumno registrado es: " + nombre.ToUpper());
        }
    }
}
