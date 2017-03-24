using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase03
{
    public class Sello
    {
        #region Atributos

        public static string mensaje;
        public static ConsoleColor color;

        #endregion

        #region Métodos

        public static string Imprimir()
        {
            if (mensaje == null)
                return null;
            else
                return ArmarMensaje();
        }

        public static void Borrar()
        {
            Sello.mensaje = null;
        }

        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = color;
            Console.WriteLine(Imprimir());
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        private static string ArmarMensaje()
        {
            
            string aux = null;

            for (int i = 0; i < mensaje.Length+2; i++)
            {
                aux += "*";
            }

            aux += "\n*" + mensaje + "*\n";

            for (int i = 0; i < mensaje.Length+2; i++)
            {
                aux += "*";
            }

            return aux;
        }

        #endregion
    }
}
