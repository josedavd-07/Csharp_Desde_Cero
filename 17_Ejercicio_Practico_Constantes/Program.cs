using System;

namespace _17_Ejercicio_Practico_Constantes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                ** Declara una constante de  tipo entero con el nombre colorFabrica
                * y asigna el valor de fabrica de color que lleve algun vehiculo que tengas.
                * y muestra su resultado en la consola con un metodo de salida.
            */

            const string colorFabrica = "Verde";
            Console.WriteLine("¿De que color fu el color de fabrica de su vehiculo: ?");
            Console.Write($"\nEl color de fabrica de mi vehiculo fue: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(colorFabrica);
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
