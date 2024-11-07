using System;

namespace _31_Ejercicios_Practicos_If_else_If_y_TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                * Utilizando el método TryParse, intenta convertir el string "edad" en un int.
                * 
                * - En caso de que la conversión sea posible, se debe imprimir en consola 
                *   el mensaje "Número válido".
                * 
                * - En caso contrario, se debe imprimir el mensaje "Número no válido".
            */

            string edad = "19";
            int numero;

            if (int.TryParse(edad, out numero))
            {
                Console.WriteLine("Número valido");
            }
            else
            {
                Console.WriteLine("Número no valido");
            }

            Console.ReadKey();
        }
    }
}
