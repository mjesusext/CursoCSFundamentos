using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosCursoCS
{
    class Program
    {
        public struct StructEjercicioKvA
        {
            public int cantidad;
            public float media;
            public int maximo;
            public int minimo;

            public StructEjercicioKvA(int cant, int med, int max, int min)
            {
                cantidad = cant;
                media = med;
                maximo = max;
                minimo = min;
            }
        }

        static void Main(string[] args)
        {
            //TemaC_ejercicioA();
            //TemaC_ejercicioB();
            //TemaC_ejercicioCyD();
            //TemaC_ejercicioE();
            //TemaC_ejercicioF();
            //TemaC_ejercicioG();
            //TemaC_ejercicioH();
            //TemaC_ejercicioI();
            //TemaC_ejercicioJ();
            //TemaC_ejercicioKvA();
            //TemaC_ejercicioKvB();
            //TemaC_ejercicioL();
            //TemaC_ejercicioM();
            //TemaC_ejercicioN();
            TemaC_ejercicioO();
        }

        public static void TemaC_ejercicioA()
        {
            int A = 3;
            int B = 3;
            int C = 7;

            //Probamos si son iguales
            string igualdad = Convert.ToString(A == B ? 1 : 0) + Convert.ToString(A == C ? 1 : 0) + Convert.ToString(B == C ? 1 : 0);

            switch (igualdad)
            {
                case "000":
                    Console.WriteLine("Ningún valor idéntico");
                    if (A < B || A < C)
                    {
                        if (B < C)
                            Console.WriteLine("El grande es C");
                        else
                            Console.WriteLine("El grande es B");
                    }
                    else if (B < A || B < C)
                    {
                        if (A < C)
                            Console.WriteLine("El grande es C");
                        else
                            Console.WriteLine("El grande es A");
                    }
                    else
                    {
                        if (A < B)
                            Console.WriteLine("El grande es B");
                        else
                            Console.WriteLine("El grande es A");
                    }
                    break;

                case "001":
                    Console.WriteLine("Valor B y C iguales");
                    if (A < B)
                        Console.WriteLine("El grande es B");
                    else
                        Console.WriteLine("El grande es C");
                    break;

                case "010":
                    Console.WriteLine("Valor A y C iguales");
                    if (A < B)
                        Console.WriteLine("El grande es B");
                    else
                        Console.WriteLine("El grande es C");
                    break;

                case "100":
                    Console.WriteLine("Valor A y B iguales");
                    if (A < C)
                        Console.WriteLine("El grande es C");
                    else
                        Console.WriteLine("El grande es A");
                    break;

                default:
                    Console.WriteLine("Tautología: todos son iguales");
                    break;
            }
            Console.ReadLine();
        }

        public static void TemaC_ejercicioB()
        {
            int[] valores = { 1, 7, 0, 0, 7 };
            int min_val = 0;
            int max_val = 0;

            for (int i = 0; i < valores.Length; i++)
            {
                max_val = valores[i] >= max_val ? valores[i] : max_val;
                min_val = valores[i] <= min_val ? valores[i] : min_val;
            }
            Console.WriteLine("El valor grande es " + max_val.ToString());
            Console.WriteLine("El valor pequeño es " + min_val.ToString());
            Console.ReadLine();
        }

        public static void TemaC_ejercicioCyD()
        {
            int valor;
            const int factor = 3;
            string mensaje;
            bool Correcto = true;

            while (Correcto)
            {
                Console.WriteLine("Introducza valor: ");
                Correcto = int.TryParse(Console.ReadLine(), out valor);

                if (Correcto)
                {
                    Correcto = valor == 0 ? false : true;
                    mensaje = Correcto ? "Valor: " + Convert.ToString(valor * factor) + "\n\n" : "Fin de ejecución.\n\n";
                }
                else
                {
                    mensaje = "Valor no válido: debes introducir un número entero\n";
                    Correcto = true;
                }

                Console.WriteLine(mensaje);
            }
            Console.ReadLine();
        }

        public static void TemaC_ejercicioE()
        {
            //No crear variable mensaje si cada vez cambia. Ineficiente sin StringBuilder. Hardcodear.

            bool Correcto = false;
            int valor = 0;

            while (!Correcto)
            {
                Console.WriteLine("Introducza un valor entero: ");
                Correcto = int.TryParse(Console.ReadLine(), out valor);
            }

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(valor.ToString() + " X " + i.ToString() + " = " + Convert.ToString(valor * i));
            }
            Console.ReadLine();
        }

        public static void TemaC_ejercicioF()
        {
            for (int i = 2; i <= 5; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine(i.ToString() + " X " + j.ToString() + " = " + Convert.ToString(i * j));
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        public static void TemaC_ejercicioG()
        {
            const string clave = "secreto";
            const int max_intentos = 5;

            Console.WriteLine("Introduzca clave: ");

            for (int i = 1; i <= max_intentos; i++)
            {
                if (String.Equals(clave, Console.ReadLine()))
                {
                    Console.WriteLine("Acceso concedido.");
                    break;
                }
                else
                {
                    Console.WriteLine("Acceso denegado.");
                    Console.WriteLine("Introduzca clave: ");
                }
            }
            Console.ReadLine();
        }

        public static void TemaC_ejercicioH()
        {
            int valor_actual = 1;
            int valor_fin = 0;
            bool Correcto = false;

            while (!Correcto)
            {
                Console.WriteLine("Introducza un valor entero: ");
                Correcto = int.TryParse(Console.ReadLine(), out valor_fin);
            }

            //Versión for
            for (int i = valor_actual; i <= valor_fin; i++)
            {
                Console.Write(i.ToString() + ", ");
            }
            Console.WriteLine();

            //Versión while
            while (valor_actual <= valor_fin)
            {
                Console.Write(valor_actual.ToString() + ", ");
                valor_actual++;
            }
            Console.WriteLine();

            //Versión do-while
            valor_actual = 1;

            do
            {
                Console.Write(valor_actual.ToString() + ", ");
                valor_actual++;
            } while (valor_actual <= valor_fin);
            Console.WriteLine();

            Console.ReadLine();
        }

        public static void TemaC_ejercicioI()
        {
            int valor = 0;
            bool Correcto = false;

            while (!Correcto)
            {
                Console.WriteLine("Introducza un valor entero: ");
                Correcto = int.TryParse(Console.ReadLine(), out valor);
            }

            for (int i = 1; i <= valor; i++)
            {
                if (i == 15 || i == 21 || i % 2 == 0)
                    continue;
                Console.Write(i.ToString() + ", ");
            }
            Console.ReadLine();
        }

        public static void TemaC_ejercicioJ()
        {
            int valor = 0;
            int posiciones = 1;
            bool Correcto = false;

            while (!Correcto)
            {
                Console.WriteLine("Introducza un valor entero: ");
                Correcto = int.TryParse(Console.ReadLine(), out valor);
            }

            if (valor < 0)
                valor = -valor;

            Correcto = true;

            while (Correcto)
            {
                valor = valor / 10;
                if (valor == 0)
                    break;
                else
                    posiciones++;
            }
            Console.WriteLine("El número tiene " + posiciones.ToString() + " posiciones.");
            Console.ReadLine();
        }

        public static void TemaC_ejercicioKvA()
        {
            int valor = 0;
            StructEjercicioKvA estructura;
            //Inicializamos sin instanciar, para detectar primera iteración en cálculos.
            estructura.cantidad = 0;
            estructura.media = 0f;
            estructura.minimo = 0;
            estructura.maximo = 0;

            Console.WriteLine("Introducza valores enteros. Si no desea más, introducza cualquier caracter: ");
            Console.WriteLine("Valor nuevo: ");

            while (int.TryParse(Console.ReadLine(), out valor))
            {
                estructura.cantidad++;
                estructura.media = estructura.cantidad == 1 ? valor : (estructura.media * (estructura.cantidad - 1) + valor) / estructura.cantidad;
                estructura.minimo = estructura.minimo == 0 ? valor : Math.Min(estructura.minimo, valor);
                estructura.maximo = estructura.maximo == 0 ? valor : Math.Max(estructura.maximo, valor);

                Console.WriteLine("Cantidad: " + estructura.cantidad.ToString() + "\nMedia: " + estructura.media.ToString() + "\nMínimo: " + estructura.minimo.ToString() + "\nMáximo: " + estructura.maximo.ToString());
                Console.WriteLine("Valor nuevo: ");
            }

        }

        public static void TemaC_ejercicioKvB()
        {
            int[] valores = { 0 };
            int valor;
            bool primer_valor = true;

            Console.WriteLine("Introducza valores enteros. Si no desea más, introducza cualquier caracter: ");
            Console.WriteLine("Valor nuevo: ");

            while (int.TryParse(Console.ReadLine(), out valor))
            {
                if (primer_valor)
                {
                    valores[0] = valor;
                    primer_valor = false;
                    Console.WriteLine("Valor nuevo: ");
                    continue;
                }

                //Creamos variable temporal, volcamos valores anteriores, añadimos nuevo y cambiamos puntero.
                int[] valores_buffer = new int[valores.Length + 1];
                //Si la matriz fuera de tipo referencia, habria que usar este. Si es por valor, da igual copyto que clone (copia superficial)...
                valores.CopyTo(valores_buffer, 0);
                valores_buffer[valores.Length] = valor;
                valores = valores_buffer;
                Console.WriteLine("Valor nuevo: ");
            }

            Console.WriteLine("Cantidad: " + valores.Length.ToString() + "\nMedia: " + valores.Average().ToString() + "\nMínimo: " + valores.Min().ToString() + "\nMáximo: " + valores.Max().ToString());
            Console.ReadLine();

        }

        public static void TemaC_ejercicioL()
        {
            int nota = 0;
            bool Correcto = false;

            Console.WriteLine("Introduzca una nota de 0 a 10: ");
            while (!Correcto)
            {
                Correcto = int.TryParse(Console.ReadLine(), out nota);
            }

            switch (nota)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("Suspenso");
                    break;
                case 5:
                case 6:
                    Console.WriteLine("Aprobado");
                    break;
                case 7:
                case 8:
                    Console.WriteLine("Notable");
                    break;
                case 9:
                case 10:
                    Console.WriteLine("Sobresaliente");
                    break;
                default:
                    Console.WriteLine("Valor fuera de rango");
                    break;
            }
            Console.ReadLine();
        }

        public static void TemaC_ejercicioM()
        {
            int valorA = 0, valorB = 0;
            bool Correcto = false;
            string mensaje;

            Console.WriteLine("Introduzca dos valores para comparar:");
            while (!Correcto)
            {
                Console.WriteLine("Valor A: ");
                Correcto = int.TryParse(Console.ReadLine(), out valorA);
            }

            //Aprovechamos variable...
            Correcto = false;

            while (!Correcto)
            {
                Console.WriteLine("Valor B: ");
                Correcto = int.TryParse(Console.ReadLine(), out valorB);
            }

            mensaje = valorA < valorB ? "El numero mayor es B" : "El numero mayor es A";
            Console.WriteLine(mensaje);
            Console.ReadLine();
        }

        public static void TemaC_ejercicioN()
        {
            int valor = 0;
            bool Correcto = false;
            string mensaje;

            Console.WriteLine("Introduzca valor mayor que 0, para validar si es primo:");
            while (!Correcto)
            {
                Console.WriteLine("Valor: ");
                Correcto = int.TryParse(Console.ReadLine(), out valor);
            }

            //Aprovechamos booleano. Asumimos que es primo (para ahorrar una asignación)
            Correcto = true;

            for (int i = 2; i < valor; i++)
            {
                if (valor % i == 0)
                {
                    Correcto = false;
                    break;
                }
            }

            mensaje = Correcto ? "El número " + valor.ToString() + " es primo." : "El número " + valor.ToString() + " no es primo.";
            Console.WriteLine(mensaje);
            Console.ReadLine();
        }

        public static void TemaC_ejercicioO()
        {
            int coste = 0, pago = 0, pend_devolver = 0, num_billetes = 0;
            //Se podria definir como enum fuera del método...
            int[] billetes = { 500, 200, 100, 50, 20, 10, 5 };
            bool Correcto = false;

            Console.WriteLine("Introduzca coste y pago (enteros) para calculo de devolución: ");
            while (!Correcto || coste <= 0)
            {
                Console.WriteLine("Coste: ");
                Correcto = int.TryParse(Console.ReadLine(), out coste);
            }
            Correcto = false;

            while (!Correcto || pago < coste)
            {
                Console.WriteLine("Pago: ");
                Correcto = int.TryParse(Console.ReadLine(), out pago);
            }

            pend_devolver = pago - coste;
            Console.Write("Devolución: ");


            for (int i = 0; i < billetes.Length; i++)
            {
                if (billetes[i] > pend_devolver)
                    continue;

                while (pend_devolver % billetes[i] > 0 && billetes[i] <= pend_devolver)
                {
                    num_billetes++;
                    pend_devolver = pend_devolver - billetes[i];
                }

                Console.Write(billetes[i].ToString() + " X " + num_billetes.ToString() + ", ");
                num_billetes = 0;
            }

            Console.Write(pend_devolver.ToString() + ".");
            Console.ReadLine();
        }
    }
}
