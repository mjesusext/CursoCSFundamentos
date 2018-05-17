using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaC
{
    public delegate void AlumnoMatriculadoEventHandler(string nombre);
    //Ejercicio 5 - Creación clase curso
    class Curso
    {
        //Los campos los hacemos privados, y las herencias que trabajen a partir de las propiedades.
        //Así se controla el formato sin violar reglas de negocio.
        private string titulo;
        private double precio;
        private int duración;

        public string Titulo
        {
            get
            {
                if (titulo == null)
                    titulo = "Titulo por defecto (valor vacío)";
                return titulo;
            }
            set
            {
                titulo = value.Length > 100 ? "Titulo por defecto (exceso long)" : value;
            }
        }

        public double Precio
        {
            get
            {
                return precio;
            }
            set
            {
                precio = value < 0 ? 0 : value;
            }
        }

        public int Duración
        {
            get
            {
                return duración;
            }
            set
            {
                duración = value < 0 || value > 1000 ? 10 : value;
            }
        }

        public Curso()
        {
        }

        public Curso(string titulo, double precio, int duracion)
        {
            Titulo = titulo;
            Precio = precio;
            Duración = duracion;
        }

        //No usar modificador static. Sino, no podremos acceder a cosas basadas en instanciación (propiedades y campos NO estáticos)
        //Usamos propiedades ya que encapsulan como debemos mostrar las cosas (más que reimplementar forma de mostrar)
        public virtual void MostrarInfo()
        {
            Console.WriteLine("Título del curso: " + Titulo + "\nDuración del curso: " + Duración.ToString() + "\nPrecio del curso: " + CalcularPrecio().ToString());
            //Modificación ejercicio 8 (funcionaba correctamente)
            Console.WriteLine("------------------");
            Console.WriteLine("Precio incluido (ejercicio 8): " + CalcularPrecio().ToString());
        }

        public virtual double CalcularPrecio()
        {
            return Precio;
        }
    }

    //Ejercicio 6: Nueva clase a partir de herencia
    class CursoOnline : Curso
    {
        private string url;
        public string URL
        {
            get
            {
                if (url == null)
                    url = "Sin URL";
                return url;
            }
            set
            {
                url = value;
            }
        }

        //Overide de constructor
        public CursoOnline() : base()
        {
        }

        //Overide del constructor de 3 argumentos, añadiendo el cuarto
        public CursoOnline(string titulo, double precio, int duración, string url) : base(titulo, precio, duración)
        {
            URL = url;
        }

        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine("URL del curso: " + URL);
        }
    }

    //Ejercicio 7: Nueva clase a partir de herencia
    class CursoAMedida : Curso
    {
        private string cliente;

        private byte numalumnos;

        public string Cliente
        {
            get
            {
                if (cliente == null)
                    cliente = "Cliente por defecto. No definido";
                return cliente;
            }
            set
            {
                cliente = value;
            }
        }

        public byte NumAlumnos
        {
            get
            {
                return numalumnos;
            }
            set
            {
                if (Duración < 8)
                    numalumnos = 20;
                else
                    numalumnos = value > 10 ? value : (byte)10;
            }
        }

        //Extendemos constructor sin argumentos
        public CursoAMedida() : base() { }

        //Extendemos constructor con argumentos, añadiendole más
        public CursoAMedida(string titulo, double precio, int duración, string cliente, byte numalumnos) : base(titulo, precio, duración)
        {
            Cliente = cliente;
            NumAlumnos = numalumnos;
        }

        //Modificamos clase "Curso" para tener métodos virtual (sobreescribibles).
        //Sobreescribimos métodos para aplicar nuevos campos
        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine("Cliente: " + Cliente + "\nNúm. alumnos: " + NumAlumnos.ToString());
        }

        public override double CalcularPrecio()
        {
            if (NumAlumnos > 50)
                return Precio * (1 - 0.4);
            else if (NumAlumnos > 25)
                return Precio * (1 - 0.2);
            else
                return Precio;
        }
    }


    //Ejercicio 9-10: Redefinimos clase cambiandole el nombre y llamándolo abstracto.
    abstract class CursoAbstracto
    {
        /*Ejercicio 13 - Creación de evento y delegado asociado a matriculación de alumno. 
        Definimos delegado a nivel de namespace para que lo puedan ver las clases desde donde se define el delegado a ser llamado.
        El evento es exclusivo de la clase afectada, porque solo se llama desde ahi.*/
        public event AlumnoMatriculadoEventHandler OnAlumnoMatriculado;

        //Los campos los hacemos privados, y las herencias que trabajen a partir de las propiedades.
        //Así se controla el formato sin violar reglas de negocio.
        private string titulo;
        private double precio;
        private int duración;
        private byte numalumnos;
        public Alumno[] alumnos;
        public static byte matriculados;

        public string Titulo
        {
            get
            {
                if (titulo == null)
                    titulo = "Titulo por defecto (valor vacío)";
                return titulo;
            }
            set
            {
                titulo = value.Length > 100 ? "Titulo por defecto (exceso long)" : value;
            }
        }

        public double Precio
        {
            get
            {
                return precio;
            }
            set
            {
                precio = value < 0 ? 0 : value;
            }
        }

        public int Duración
        {
            get
            {
                return duración;
            }
            set
            {
                duración = value < 0 || value > 1000 ? 10 : value;
            }
        }

        public byte NumAlumnos
        {
            get
            {
                return numalumnos;
            }
            set
            {
                numalumnos = value;
            }
        }

        //Ejercicio 13: Crear indizador para retornar string en función del número de alumno
        public string this[int indice]
        {
            get
            {
                return alumnos[indice - 1].Nombre;
            }
        }

        //No usar modificador static. Sino, no podremos acceder a cosas basadas en instanciación (propiedades y campos NO estáticos)
        //Usamos propiedades ya que encapsulan como debemos mostrar las cosas (más que reimplementar forma de mostrar)
        public virtual void MostrarInfo()
        {
            Console.WriteLine("Título del curso: " + Titulo + "\nDuración del curso: " + Duración.ToString() + "\nPrecio del curso: " + CalcularPrecio().ToString());
            //Modificación ejercicio 8 (funcionaba correctamente)
            Console.WriteLine("------------------");
            Console.WriteLine("Precio incluido (ejercicio 8): " + CalcularPrecio().ToString());
        }

        public abstract double CalcularPrecio();

        //Ejercicio 12 - Crear método
        public void MatricularAlumno(Alumno alu)
        {
            alumnos[matriculados] = alu;
            matriculados++;
            //Ejercicio 13 - Disparamos evento.
            if (OnAlumnoMatriculado != null)
                OnAlumnoMatriculado(alu.Nombre);
        }
    }

    //Ejercicio 9-10: Nueva clase a partir de herencia, redefiniendolo por padre abstracto-
    class CursoOnlineAbstracto : CursoAbstracto
    {
        private string url;
        public string URL
        {
            get
            {
                if (url == null)
                    url = "Sin URL";
                return url;
            }
            set
            {
                url = value;
            }
        }

        //Overide de constructor
        public CursoOnlineAbstracto()
        {
        }

        //Overide del constructor de 3 argumentos, añadiendo el cuarto
        public CursoOnlineAbstracto(string titulo, double precio, int duración, string url)
        {
            Titulo = titulo;
            Precio = precio;
            Duración = duración;
            URL = url;
        }

        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine("URL del curso: " + URL);
        }

        public override double CalcularPrecio()
        {
            return Precio;
        }
    }

    //Ejercicio 9-10: Nueva clase a partir de herencia, redefiniendolo por padre abstracto.
    class CursoAMedidaAbstracto : CursoAbstracto
    {
        private string cliente;

        //Ejercicio 11 - Mover numalumnos a clase abstracta, sin reglas de negocio.
        //private byte numalumnos;

        public string Cliente
        {
            get
            {
                if (cliente == null)
                    cliente = "Cliente por defecto. No definido";
                return cliente;
            }
            set
            {
                cliente = value;
            }
        }

        /*public byte NumAlumnos
        {
            get
            {
                return numalumnos;
            }
            set
            {
                if (Duración < 8)
                    numalumnos = 20;
                else
                    numalumnos = value > 10 ? value : (byte)10;
            }
        }*/

        //Extendemos constructor sin argumentos
        public CursoAMedidaAbstracto()
        {
            //Ejercicio 12: cubrir caso de array nulo.
            alumnos = new Alumno[0];
        }

        //Extendemos constructor con argumentos, añadiendole más
        public CursoAMedidaAbstracto(string titulo, double precio, int duración, string cliente, byte numalumnos)
        {
            Titulo = titulo;
            Precio = precio;
            Duración = duración;
            Cliente = cliente;
            NumAlumnos = numalumnos;
            //Ejercicio 12: inicializar array definido en clase abstract (no instanciable)
            alumnos = new Alumno[numalumnos];
        }

        //Modificamos clase "Curso" para tener métodos virtual (sobreescribibles).
        //Sobreescribimos métodos para aplicar nuevos campos
        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine("Cliente: " + Cliente + "\nNúm. alumnos: " + NumAlumnos.ToString());
        }

        public override double CalcularPrecio()
        {
            if (NumAlumnos > 50)
                return Precio * (1 - 0.4);
            else if (NumAlumnos > 25)
                return Precio * (1 - 0.2);
            else
                return Precio;
        }
    }
}
