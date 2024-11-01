using System;

namespace _13_Ejercicio_Practico_Metodos_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Ejercicio  N° 1 de metodos de string");
            Console.ResetColor();

            Console.Write("\nPor favor ingrese un texto: ");
            string ingreso = Console.ReadLine();
            Console.Write("\nIngrese el caracter que quiere buscar en el texto: ");
            char ingresoBuscado = Console.ReadLine()[0];
            int buscarIndice = ingreso.IndexOf(ingresoBuscado);
            Console.WriteLine("\nEl índice del caracter {0} en el texto es: {1}", ingresoBuscado, buscarIndice);
            
            Console.WriteLine("\nPor favor presione culquiera tecla para continuar con el segundo ejercicio");
            Console.ReadKey();
            Console.Clear();


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nEjercicio  N° 2 de metodos de string");
            Console.ResetColor();

            Console.Write("\nPor favor ingrese su nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("\nPor favor ingrese su apellido: ");
            string apellido = Console.ReadLine();
            string nombrecompleto = String.Concat(nombre, " ", apellido);
            Console.WriteLine("\nEl nombre completo es: {0}", nombrecompleto);

            Console.WriteLine("\nPor favor presione cualquiera tecla pra terminar la ejecución del programa");
            Console.ReadKey();
        }
    }
}
