using System; // Biblioteca base de C#
using System.Text; // Biblioteca para codificación de texto

namespace _03_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Variables en C#";

            //Salida emojis
            Console.OutputEncoding = Encoding.UTF8; 

            /*
                * ESTRUCTURA DE UNA VARIABLE EN C#
                * Sintaxis:
                * TipoDato nombreVariable = valor;
            */

            // Declaración de variables
            int numero = 10;                // Entero
            float numeroFlotante = 10.5f;   // Flotante (requiere 'f')
            string texto = "Hola Mundo";    // Cadena de texto

            /*
                * FORMAS DE IMPRIMIR VALORES EN CONSOLA
            */

            // 1. Formato por índice
            Console.WriteLine("El valor de 'numero' es: {0}", numero);

            // 2. Concatenación con +
            Console.WriteLine("El valor de 'numeroFlotante' es: " + numeroFlotante);

            // 3. Interpolación de cadenas
            Console.WriteLine($"El mensaje de 'texto' es: {texto}");

            /*
                * IMPRESIÓN MULTILÍNEA CON INTERPOLACIÓN (C# 11+)
            */

            Console.WriteLine($"""

                ------------------------------
                VALORES DE LAS VARIABLES
                ------------------------------
                🔢 Numero: {numero}
                🌊 Flotante: {numeroFlotante}
                📝 Texto: {texto}
            """);

            // Pausa para ver resultados
            Console.WriteLine("\nPresiona cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}
