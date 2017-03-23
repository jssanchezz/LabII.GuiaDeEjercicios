using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio09
{
    /* Escribir un programa que imprima por pantalla una pirámide como
    la siguiente:
    *
    ***
    *****
    *******
    *********    
    El usuario indicará cuál será la altura de la pirámide ingresando
    un número entero positivo. Para el ejemplo anterior la altura
    ingresada fue de 5.
    Nota: Utilizar estructuras repetitivas y selectivas.*/

    class Program
    {
        static void Main(string[] args)
        {
            int length = 5;

            Console.ForegroundColor = ConsoleColor.Magenta;

            for (int i = 0; i < length; i++)
            {                
                Console.Write("*");
                    
                if(i != 0)
                {
                    for (int j = 0; j < i*2; j++)
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();   
        }
    }
}
