using System;

namespace _04_Tipos_De_Datos_Int_Float_Double
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tipos de datos int, float y double";

            /*
                * En este ejemplo se explica el uso de los tipos de datos:
                * - int    → Números enteros
                * - float  → Números decimales de menor precisión
                * - double → Números decimales de mayor precisión
            */

            // Declaración múltiple de variables sin inicializar
            int a, b, c;
            double x, y, z;
            float m, n, o;

            // ==========================
            // VARIABLES DE TIPO INT
            // ==========================
            int num1 = 10;
            int num2 = 20;

            int suma = num1 + num2;

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nSUMA DE VALORES ENTEROS:");
            Console.ResetColor();

            // 1. Interpolación de cadenas
            Console.WriteLine($"\nLa suma de {num1} + {num2} es: {suma}");

            // 2. Concatenación tradicional
            Console.WriteLine("\nLa suma de " + num1 + " + " + num2 + " es: " + suma);

            // 3. Formato por índices
            Console.WriteLine("\nLa suma de {0} + {1} es: {2}", num1, num2, suma);

            // ==========================
            // VARIABLES DE TIPO DOUBLE
            // ==========================
            double numDouble1 = 10.5;
            double numDouble2 = 20.5;

            double sumaDouble = numDouble1 + numDouble2;

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nSUMA DE VALORES DOUBLE:");
            Console.ResetColor();

            Console.WriteLine($"\nLa suma de {numDouble1} + {numDouble2} es: {sumaDouble}");

            // ==========================
            // SUMA DE VALORES ENTEROS Y DOUBLE
            // ==========================
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nSUMA DE VALORES INT Y DOUBLE:");
            Console.ResetColor();
            
            int numInt = 5;
            double numDouble = 15.5;

            double sumIntAndDouble = numInt + numDouble;
            Console.WriteLine($"\nLa suma del número entero {numInt} más el número double {numDouble} es: {sumIntAndDouble}");

            // ==========================
            // VARIABLES DE TIPO FLOAT
            // ==========================
            float numFloat1 = 10.5f;
            float numFloat2 = 20.5f;

            float sumaFloat = numFloat1 + numFloat2;

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nSUMA DE VALORES FLOAT:");
            Console.ResetColor();

            Console.WriteLine($"\nLa suma de {numFloat1} + {numFloat2} es: {sumaFloat}");

            // ==========================
            // FINAL DEL PROGRAMA
            // ==========================
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nPresiona una tecla para continuar...");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}

