using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaC
{
    //Ejercicio 12: Crear clase para generar dependencia en otros métodos de clase Curso
    class Alumno
    {
        public string Nombre { get; set; }

        public Alumno(string nombre)
        {
            Nombre = nombre;
        }
    }
}
