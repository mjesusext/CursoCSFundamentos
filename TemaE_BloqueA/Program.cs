using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaE_BloqueA
{
    class Program
    {
        //Ejercicio E.
        public const int AltoBasico = 600, AnchoBasico = 800;
        public const int AltoHD = 1080, AnchoHD = 1920;

        static void Main(string[] args)
        {
            #region EjerciciosA-B-C

            /*TimeSpan stopEjercicioABC;
            TimeSpan startEjercicioABC = new TimeSpan(DateTime.Now.Ticks);

            PixelClaseColClase[] PantBaseTodoClase = new PixelClaseColClase[AltoBasico * AnchoBasico];
            for (int fil = 0; fil < AltoBasico; fil++)
            {
                for (int col = 0; col < AnchoBasico; col++)
                {
                    //Implementación como clase
                    PantBaseTodoClase[col + fil * AnchoBasico] = new PixelClaseColClase(col + 1, fil + 1, 0, 0, 0);
                }
            }
            Console.WriteLine(PantBaseTodoClase[800].x.ToString() + " " + PantBaseTodoClase[800].y.ToString());

            stopEjercicioABC = new TimeSpan(DateTime.Now.Ticks);
            Console.WriteLine(stopEjercicioABC.Subtract(startEjercicioABC).TotalSeconds);
            */
            #endregion

            #region EjercicioD

            /*TimeSpan stopEjercicioD;
            TimeSpan startEjercicioD = new TimeSpan(DateTime.Now.Ticks);

            PixelStructColClase[] PantBasePixStruct = new PixelStructColClase[AltoBasico * AnchoBasico];

            for (int fil = 0; fil < AltoBasico; fil++)
            {
                for (int col = 0; col < AnchoBasico; col++)
                {
                    //Implementación como struct
                    PantBasePixStruct[col + fil * AnchoBasico].x = col + 1;
                    PantBasePixStruct[col + fil * AnchoBasico].y = fil + 1;
                    PantBasePixStruct[col + fil * AnchoBasico].color = new ColorClase();
                }
            }
            Console.WriteLine(PantBasePixStruct[800].x.ToString() + " " + PantBasePixStruct[800].y.ToString());

            stopEjercicioD = new TimeSpan(DateTime.Now.Ticks);
            Console.WriteLine(stopEjercicioD.Subtract(startEjercicioD).TotalSeconds);
            */
            #endregion

            #region EjercicioE

            /*TimeSpan stopEjercicioE;
            TimeSpan startEjercicioE = new TimeSpan(DateTime.Now.Ticks);

            PixelClaseColClase[] PantHDTodoClase = new PixelClaseColClase[AltoHD * AnchoHD];
            for (int fil = 0; fil < AltoHD; fil++)
            {
                for (int col = 0; col < AnchoHD; col++)
                {
                    //Implementación como clase
                    PantHDTodoClase[col + fil * AnchoHD] = new PixelClaseColClase(col + 1, fil + 1, 0, 0, 0);
                }
            }
            Console.WriteLine(PantHDTodoClase[800].x.ToString() + " " + PantHDTodoClase[800].y.ToString());

            stopEjercicioE = new TimeSpan(DateTime.Now.Ticks);
            Console.WriteLine(stopEjercicioE.Subtract(startEjercicioE).TotalSeconds);

            startEjercicioE = new TimeSpan(DateTime.Now.Ticks);

            PixelStructColClase[] PantHDPixStruct = new PixelStructColClase[AltoHD * AnchoHD];

            for (int fil = 0; fil < AltoHD; fil++)
            {
                for (int col = 0; col < AnchoHD; col++)
                {
                    //Implementación como struct
                    PantHDPixStruct[col + fil * AnchoHD].x = col + 1;
                    PantHDPixStruct[col + fil * AnchoHD].y = fil + 1;
                    PantHDPixStruct[col + fil * AnchoHD].color = new ColorClase();
                }
            }
            Console.WriteLine(PantHDPixStruct[800].x.ToString() + " " + PantHDPixStruct[800].y.ToString());

            stopEjercicioE = new TimeSpan(DateTime.Now.Ticks);
            Console.WriteLine(stopEjercicioE.Subtract(startEjercicioE).TotalSeconds);
            */
            #endregion

            #region EjercicioF

            /*TimeSpan stopEjercicioF;
            TimeSpan startEjercicioF = new TimeSpan(DateTime.Now.Ticks);
            //Pixel struct color clase
            PixelStructColClase[] PantBasePxStrColCl = new PixelStructColClase[AltoBasico * AnchoBasico];
            for (int fil = 0; fil < AltoBasico; fil++)
            {
                for (int col = 0; col < AnchoBasico; col++)
                {
                    //Implementación como clase
                    PantBasePxStrColCl[col + fil * AnchoBasico] = new PixelStructColClase(col + 1, fil + 1, new ColorClase());
                }
            }

            Console.WriteLine(PantBasePxStrColCl[800].x.ToString() + " " + PantBasePxStrColCl[800].y.ToString());
            Console.WriteLine(PantBasePxStrColCl[800].color.ToString());
            stopEjercicioF = new TimeSpan(DateTime.Now.Ticks);
            Console.WriteLine(stopEjercicioF.Subtract(startEjercicioF).TotalSeconds);

            startEjercicioF = new TimeSpan(DateTime.Now.Ticks);
            //Todo como struct
            PixelStructColStruct[] PantBasePxStrColSt = new PixelStructColStruct[AltoBasico * AnchoBasico];

            for (int fil = 0; fil < AltoBasico; fil++)
            {
                for (int col = 0; col < AnchoBasico; col++)
                {
                    //Implementación como struct
                    PantBasePxStrColSt[col + fil * AnchoBasico].x = col + 1;
                    PantBasePxStrColSt[col + fil * AnchoBasico].y = fil + 1;
                    PantBasePxStrColSt[col + fil * AnchoBasico].color = new ColorStruct();
                }
            }
            Console.WriteLine(PantBasePxStrColSt[800].x.ToString() + " " + PantBasePxStrColSt[800].y.ToString());
            Console.WriteLine(PantBasePxStrColSt[800].color.ToString());
            stopEjercicioF = new TimeSpan(DateTime.Now.Ticks);
            Console.WriteLine(stopEjercicioF.Subtract(startEjercicioF).TotalSeconds);
            */
            #endregion

            #region EjercicioGHI

            //Todo como struct
            PixelStructColStruct[] PantBasePxStrColSt = new PixelStructColStruct[AltoBasico * AnchoBasico];

            for (int fil = 0; fil < AltoBasico; fil++)
            {
                for (int col = 0; col < AnchoBasico; col++)
                {
                    //Implementación como struct
                    PantBasePxStrColSt[col + fil * AnchoBasico].x = col + 1;
                    PantBasePxStrColSt[col + fil * AnchoBasico].y = fil + 1;
                    PantBasePxStrColSt[col + fil * AnchoBasico].color = new ColorStruct();
                }
            }

            //Todo structs y string
            TimeSpan stopEjercicioGHI;
            TimeSpan startEjercicioGHI = new TimeSpan(DateTime.Now.Ticks);
            startEjercicioGHI = new TimeSpan(DateTime.Now.Ticks);
            String resultado = "";

            for (int i = 0; i < 20000; i++)
            {
                resultado = resultado + PantBasePxStrColSt[i].ToString() + "\r\n";
            }

            stopEjercicioGHI = new TimeSpan(DateTime.Now.Ticks);
            Console.WriteLine("Todo structs y string: " + stopEjercicioGHI.Subtract(startEjercicioGHI).TotalSeconds);

            //Todo structs y string builder
            startEjercicioGHI = new TimeSpan(DateTime.Now.Ticks);
            startEjercicioGHI = new TimeSpan(DateTime.Now.Ticks);
            StringBuilder resultadoB = new StringBuilder("");

            for (int i = 0; i < 20000; i++)
            {
                resultadoB.Append(PantBasePxStrColSt[i].ToString() + "\r\n");
            }

            stopEjercicioGHI = new TimeSpan(DateTime.Now.Ticks);
            Console.WriteLine("Todo structs y string builder " + stopEjercicioGHI.Subtract(startEjercicioGHI).TotalSeconds);

            PixelClaseColStruct[] PantBasePxClColSt = new PixelClaseColStruct[AltoBasico * AnchoBasico];

            for (int fil = 0; fil < AltoBasico; fil++)
            {
                for (int col = 0; col < AnchoBasico; col++)
                {
                    //Implementación como struct
                    PantBasePxClColSt[col + fil * AnchoBasico] = new PixelClaseColStruct(0, 0, new ColorStruct(0, 0, 0));
                }
            }

            //Pixel clase, color struct y strings
            startEjercicioGHI = new TimeSpan(DateTime.Now.Ticks);
            resultado = "";

            for (int i = 0; i < 20000; i++)
            {
                resultado = resultado + PantBasePxStrColSt[i].ToString() + "\r\n";
            }

            stopEjercicioGHI = new TimeSpan(DateTime.Now.Ticks);
            Console.WriteLine("Pixel clase, color struct y strings: " + stopEjercicioGHI.Subtract(startEjercicioGHI).TotalSeconds);

            //Pixel clase, color struct y string builder
            startEjercicioGHI = new TimeSpan(DateTime.Now.Ticks);
            resultadoB = new StringBuilder("");

            for (int i = 0; i < 20000; i++)
            {
                resultadoB.Append(PantBasePxStrColSt[i].ToString() + "\r\n");
            }

            stopEjercicioGHI = new TimeSpan(DateTime.Now.Ticks);
            Console.WriteLine("Pixel clase, color struct y string builder: " + stopEjercicioGHI.Subtract(startEjercicioGHI).TotalSeconds);

            #endregion

            Console.ReadLine();

        }
    }
}
