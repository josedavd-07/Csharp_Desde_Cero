using System;

namespace _30_Toma_de_Decisiones_if_else_if_y_Try_Parse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Usuario ingresa informacion.
            Console.Write("Por favor, ingresa la temperatura actual: ");

            string temperatura = Console.ReadLine();
            int numTemperatura;

            //Sentencias if junto con el TryParse
            int numero;
            if (int.TryParse(temperatura, out numero))
            {
                numTemperatura = numero;
            }
            else
            {
                numTemperatura = 0;
                Console.WriteLine("\nEl valor ingresado no es válido, se estableció que la temperatura es 0");
            }

            //Sentencias if y  else if
            if (numTemperatura < 20)
            {
                Console.Write("\nAbrígate!");
            }
            else if (numTemperatura == 20)
            {
                Console.WriteLine("\nVístete cómodo");
            }
            else if (numTemperatura > 30)
            {
                Console.WriteLine("\nHacen mas de  30 grados, ¡qué calor!");
            }
            else
            {
                Console.WriteLine("\nUsa ropa bien liviana");
            }

            Console.ReadKey();
        }

    }
    
}
