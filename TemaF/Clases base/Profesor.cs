using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaF.Clases_base
{
    public class Profesor : Persona, IContribuyente, IFuncionario
    {
        public string Asignatura { get; set; }
        public bool JefeEstudios { get; set; }

        //public sealed override void MostrarNombre()
        //{
        //    Console.WriteLine("El nombre es " + Nombre + " " + Apellidos);
        //}

        public void PagarImpuestos()
        {
            Console.WriteLine("Pagando impuestos");
        }

        public void CotejarDocumentos()
        {
            Console.WriteLine("Cotejando documentos");
        }

        string IContribuyente.Nombre
        {
            get
            {
                return "Desde IContribuyente: " + Nombre;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        string IContribuyente.Apellidos
        {
            get
            {
                return "Desde IContribuyente: " + Apellidos;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        void IContribuyente.PagarImpuestos()
        {
            Console.WriteLine("Pagando impuestos");
        }

        string IFuncionario.Nombre
        {
            get
            {
                //return "Desde IFuncionario: " + Nombre;
                return Nombre;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        string IFuncionario.Apellidos
        {
            get
            {
                //return "Desde IFuncionario: " + Apellidos;
                return Apellidos;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        void IFuncionario.CotejarDocumentos()
        {
            Console.WriteLine("Cotejando documentos");
        }
    }
}
