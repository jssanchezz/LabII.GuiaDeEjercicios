using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    /*Ingresar 5 números por consola, guardándolos en una variable
    escalar. Luego calcular y mostrar: el valor máximo, el valor
    mínimo y el promedio.*/
    class Program
    {
        static void Main(string[] args)
        {
            int num, maximo = 0, minimo = 0, contador = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese un numero: ");
                
                while (!(int.TryParse(Console.ReadLine(), out num)))
                {
                    Console.WriteLine("Error. Reingrese: ");
                }

                if (i == 0)
                {
                    maximo = num;
                    minimo = num;
                }
                else {
                    if (num > maximo)
                        maximo = num;
                    if (num < minimo)
                        minimo = num;
                }

                contador = contador + num;
            }

            Console.WriteLine("Valor maximo: {0}\nValor minimo: {1}\nValor promedio: {2}", maximo, minimo, contador / 5);
            Console.ReadKey();
        }
    }
}
