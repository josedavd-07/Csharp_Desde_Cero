using System;

namespace _28_Tomas_de_Decisiones_If
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pedimnos informacion al cliente
            Console.WriteLine("Por favor, ingresa la temperatura actual");

            string temperatura = Console.ReadLine();
            int numTemperatura = int.Parse(temperatura);

            //Solo usamos sentencias de if para este ejercicio luego mas adelante veremos los else if y else.

            if (numTemperatura < 20)
            {
                Console.Write("Abrígate!");
            }
            if (numTemperatura == 20)
            {
                Console.WriteLine("Vístete cómodo");
            }
            if (numTemperatura > 20)
            {
                Console.WriteLine("Usa ropa bien liviana");
            }

            Console.ReadKey();
        }
    }
}
