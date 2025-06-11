using System;
using System.Text;

namespace _05_Tipos_De_Datos_String_y_Sus_Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tipos de datos string y sus métodos";
            Console.OutputEncoding = Encoding.UTF8;

            /*
                * En este programa trabajaremos con el tipo de dato `string`
                * y aprenderemos a aplicar algunos de sus métodos más comunes:
                * - ToUpper() → Convierte el texto a mayúsculas
                * - ToLower() → Convierte el texto a minúsculas
            */

            // ==========================
            // DECLARACIÓN DE VARIABLES STRING
            // ==========================

            string nombre = "Jose David";
            string mensaje = $"Hola, me permito presentarme. Mi nombre es: {nombre}";

            // ==========================
            // IMPRESIÓN BÁSICA DE STRINGS
            // ==========================

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nIMPRESIÓN DE STRINGS: \n");
            Console.ResetColor();

            // 1. Imprimir solo el nombre
            Console.WriteLine(nombre);

            // 2. Imprimir mensaje con interpolación
            Console.WriteLine($"\nHola, me permito presentarme. Mi nombre es: {nombre}");

            // 3. Imprimir dos strings juntos
            Console.WriteLine($"\n{mensaje} {nombre}");

            // 4. Imprimir directamente la variable `mensaje`
            Console.WriteLine($"\n{mensaje}");

            // ==========================
            // MÉTODOS DE LA CLASE STRING
            // ==========================

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nMÉTODOS DE STRING:");
            Console.ResetColor();

            // ToUpper()
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n→ Método ToUpper():");
            Console.ResetColor();
            Console.WriteLine($"Nombre en mayúsculas: {nombre.ToUpper()}");

            // ToLower()
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n→ Método ToLower():");
            Console.ResetColor();
            Console.WriteLine($"Nombre en minúsculas: {nombre.ToLower()}");

            // ==========================
            // FINALIZACIÓN
            // ==========================

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nPresiona una tecla para cerrar la consola.");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
