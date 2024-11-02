using System;

namespace _16_Ejercicio_Practico_Constantes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
                * Declara una constante de tipo int con el nombre de anioAmerica
                * y asigna el valor del decubrimiento de america
                * y muestra su resultado en la consola con un metod desalida.
            */

            const int anioAmerica = 1492;
            Console.WriteLine("¿En que año fue el descubrimiento de América?");
            Console.Write($"\nEl descubrimiento de América fue en el año: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(anioAmerica);
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
