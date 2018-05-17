using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaF
{
    class Comparador<T>
    {

        T objetoA { get; set; }
        T objetoB { get; set; }

        public Comparador()
        {
            objetoA = default(T);
            objetoB = default(T);
        }

        #region EjercicioC

        public bool Igualdad()
        {
            //Los Ifuncionarios deben implementar nombre y apellidos como propiedades.
            //Aun así el ejercicio se centra en como llamar a los métodos, mas que lo que hagan...

            //Comparación con boxing (pasando de objeto concreto a object para poder usar "equals"
            if (object.Equals(objetoA, default(T)) || object.Equals(objetoB, default(T)))
            {
                if (object.Equals(objetoA, default(T)) && object.Equals(objetoB, default(T)))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return objetoA.Equals(objetoB);
            }

            //Comparación con clase generica para comparaciones. Ahorra el boxin al definir el tipo de variable
            /*if (EqualityComparer<T>.Default.Equals(objetoA, objetoB))
            {
                return true;
            }
            else
            {
                return false;
            }*/

        }

        #endregion

        #region EjercicioD

        public string Union(T A, T B)
        {
            //Solo validamos una variable, la otra es del mismo tipo
            if (A is IFuncionario)
            {
                IFuncionario objetoA = A as IFuncionario;
                IFuncionario objetoB = B as IFuncionario;
                return String.Concat(objetoA.Nombre, objetoA.Apellidos, objetoB.Nombre, objetoB.Apellidos);
            }
            else if (A is string)
            {
                return string.Concat(A, B);
            }
            else if (A is int)
            {
                return (Convert.ToInt32(A) + Convert.ToInt32(B)).ToString();
            }
            else if (A is DateTime)
            {
                DateTime objetoA = Convert.ToDateTime(A);
                DateTime objetoB = Convert.ToDateTime(B);
                return objetoA.AddTicks(objetoB.Ticks).ToString();
            }
            else
            {
                return "No se puede concatenar";
            }
        }

        #endregion
    }
}
