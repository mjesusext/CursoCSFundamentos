using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaE_BloqueC
{
    /// <summary>
    /// Clase de extensión para String.
    /// </summary>
    //No es imprescindible hacerlo publico, simplemente que sea estático (porque siempre de poder operar)
    public static class ExtensionesString
    {
        #region Ejercicio VXYZ

        /// <summary>
        /// Da la vuelta a una cadena
        /// </summary>
        /// <param name="cadena">Texto a girar</param>
        /// <returns>Devuelve el texto girado</returns>
        public static string Invertir(this string cadena)
        {
            StringBuilder resultado = new StringBuilder(String.Empty);

            for (int i = cadena.Length - 1; i >= 0; i--)
            {
                resultado.Append(cadena[i]);
            }

            return resultado.ToString();
        }

        /// <summary>
        /// Devuelve true si vacía, false en caso contrario.
        /// </summary>
        /// <param name="cadena">Texto a revisar</param>
        /// <returns>Booleano</returns>
        public static bool EstaVacia(this string cadena)
        {
            return cadena.Length == 0 ? true : false;
        }

        /// <summary>
        /// Cadena, empezando por derecha, del número de posiciones indicado
        /// </summary>
        /// <param name="cadena">Texto de referencia</param>
        /// <param name="posiciones">Numero de posiciones a volcar desde final de cadena</param>
        /// <returns></returns>
        public static string Right(this string cadena, int posiciones)
        {
            StringBuilder resultado = new StringBuilder(string.Empty);

            for (int i = cadena.Length - posiciones; i < cadena.Length; i++)
            {
                resultado.Append(cadena[i]);
            }

            return resultado.ToString();
        }

        /// <summary>
        /// Cadena, empezando por izquierda, del número de posiciones indicado
        /// </summary>
        /// <param name="cadena">Texto de referencia</param>
        /// <param name="posiciones">Numero de posiciones a volcar desde inicio de cadena</param>
        /// <returns></returns>
        public static string Left(this string cadena, int posiciones)
        {
            StringBuilder resultado = new StringBuilder(string.Empty);

            for (int i = 0; i < posiciones; i++)
            {
                resultado.Append(cadena[i]);
            }

            return resultado.ToString();
        }

        #endregion

        #region EjercicioAA_AB

        /// <summary>
        /// Valida con expresión regular si un email es correcto
        /// </summary>
        /// <param name="email">Email a validar</param>
        /// <param name="usuario">Usuario detectado</param>
        /// <param name="dom_primer_nivel">Dominio de primer nivel detectado</param>
        /// <returns>Booleano</returns>
        public static bool ValidarEmail(this string email, out string usuario, out string dom_primer_nivel)
        {
            usuario = string.Empty;
            dom_primer_nivel = string.Empty;
            return false;
        }

        /// <summary>
        /// Extrae valores internos entre etiquetas de código HTML
        /// </summary>
        /// <param name="HTMLcode">Código HTML a procesar</param>
        /// <param name="valores">Array de strings con los resultados</param>
        public static void ExtraerValoresHTML(this string HTMLcode, out string[] valores)
        {
            valores = null;
        }
        #endregion
    }
}
