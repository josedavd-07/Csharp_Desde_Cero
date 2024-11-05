using System;

namespace _21_Metodos_Valores_de_Retorno_y_Parametros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                * Tres formas de llamar a un método:
                1. Llamado directo.
                Console.WriteLine(Suma(5, 5));

                2. Llamado por medio de una variable.
                int resultado = Suma(10, 10);
                Console.WriteLine(resultado);

                3. Llamado de la función por su nombre pero esta salidad no me da un valro en la consola.
                Suma(15, 15);
            */

            //llamamos los metodos.
            Console.WriteLine($"La suma de los números 25 + 13 da como resultado el valor de: {Suma(25, 13)}");
            Console.WriteLine($"\nEl producto de 5 * 5 es: {Multiplicar(5, 5)}");
            Console.WriteLine($"\nLa división de 10 / 2 es: {Dividir(10, 2)}");

            Console.ReadKey();
        }

        // Metodo suamr valores
        public static int Suma(int num1, int num2)
        {
            return num1 + num2;
        }

        // Metodo  multiplicar valores
        public static int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        //Metodo dividir valores
        public static double Dividir(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
