using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Seteando e imprimiendo
            Sello.mensaje = "Holaaaaaaa";
            Console.WriteLine(Sello.Imprimir());

            //Borro e imprimo
            Sello.Borrar();
            Console.WriteLine(Sello.Imprimir());

            //Seteo e imprimo
            Sello.mensaje = "Chau";
            Console.WriteLine(Sello.Imprimir());

            //Probando con colores

            Sello.color = ConsoleColor.Cyan;
            Sello.mensaje = "Estoy en color!";
            Sello.ImprimirEnColor();

            Sello.color = ConsoleColor.Red ;
            Sello.mensaje = "Vuelvo al mismo color!";
            Sello.ImprimirEnColor();
            Console.WriteLine(Sello.Imprimir());

            Console.ReadKey();
        }
    }
}
