using System;

namespace _09_Conversiones_De_Datos_Implicitas_E_Explicitas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ────────────────────────────────────────────────
            // CONVERSIÓN EXPLÍCITA (CASTING)
            // ────────────────────────────────────────────────
            /*
             * Se utiliza cuando queremos convertir manualmente un tipo de dato más grande
             * a uno más pequeño, por ejemplo: de double a int.
             * 
             * Al hacerlo, se pierden los decimales porque el tipo de dato más pequeño no 
             * puede almacenar toda la información.
             * 
             * Para realizar esta conversión, debemos indicárselo al compilador usando (int).
             */

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("CONVERSIÓN EXPLÍCITA (CASTING)");
            Console.ResetColor();

            double miNumeroDouble = 13.40;
            int miNumeroInt = (int)miNumeroDouble; // Conversión explícita

            Console.WriteLine($"""
                El número 'double' con valor decimal {miNumeroDouble}
                convertido a un tipo de dato 'int' da como resultado: {miNumeroInt}

                Nota: Se pierden los decimales porque el tipo 'int' no los puede almacenar.
                """);

            // ────────────────────────────────────────────────
            // CONVERSIÓN IMPLÍCITA
            // ────────────────────────────────────────────────
            /*
             * Ocurre automáticamente cuando se asigna un tipo de dato más pequeño a uno más grande.
             * Ejemplo: int → long, float → double.
             * 
             * No es necesario indicar nada al compilador porque no hay pérdida de información.
             */

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nCONVERSIÓN IMPLÍCITA");
            Console.ResetColor();

            int numeroEntero = 1345;
            long numeroLong = numeroEntero; // int → long

            Console.WriteLine($"""
                El número 'int' con valor {numeroEntero}
                convertido a un tipo de dato 'long' da como resultado: {numeroLong}

                Nota: No se pierde información en esta conversión.
                """);

            float numeroFloat = 13.45F;
            double numeroDouble = numeroFloat; // float → double

            Console.WriteLine($"""
                El número 'float' con valor {numeroFloat}
                convertido a un tipo de dato 'double' da como resultado: {numeroDouble}
                """);

            // ────────────────────────────────────────────────
            // CONVERSIÓN A STRING (ToString)
            // ────────────────────────────────────────────────
            /*
             * Se utiliza cuando queremos convertir valores numéricos o booleanos en texto.
             * 
             * Al convertir un número a string:
             * - No se pierde información.
             * - Pero ya no se pueden realizar operaciones matemáticas con el valor.
             */

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nCONVERSIÓN A STRING");
            Console.ResetColor();

            int numeroPrueba = 13;
            string numeroString = numeroPrueba.ToString(); // Conversión a string

            Console.WriteLine($"""
                El número 'int' con valor {numeroPrueba}
                convertido a 'string' da como resultado: {numeroString}
                """);

            bool elSolBrilla = true;
            string miBoolString = elSolBrilla.ToString(); // Conversión a string

            Console.WriteLine($"""
                El valor booleano 'bool' con valor {elSolBrilla}
                convertido a 'string' da como resultado: {miBoolString}
                """);

            // ────────────────────────────────────────────────
            // FIN DEL PROGRAMA
            // ────────────────────────────────────────────────

            Console.WriteLine("\nPresiona una tecla para salir...");
            Console.ReadKey();
        }
    }
}
