using System;

namespace _10_Conversion_Parsing_De_Int_A_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ──────────────────────────────────────────────
            // CONVERSIONES DE TIPO STRING A INT (Parsing)
            // ──────────────────────────────────────────────

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("CONVERSIONES DE TIPO STRING A INT");
            Console.ResetColor();

            string miPrimerNumeroString = "200";
            string miSegundoNumeroString = "5";

            Console.WriteLine($"""
                
                Si sumamos estos dos números como strings: "{miPrimerNumeroString}" + "{miSegundoNumeroString}", 
                el resultado será "2005" y no "205" como sería en una suma matemática.
                
                Esto ocurre porque al sumar strings se realiza una concatenación, no una operación matemática.
                """);

            // Concatenación de strings
            string resultadoSuma = miPrimerNumeroString + miSegundoNumeroString;

            Console.WriteLine($"""
                
                Resultado de la suma (concatenación) de los strings:
                {miPrimerNumeroString} + {miSegundoNumeroString} = {resultadoSuma}
                """);

            // ──────────────────────────────────────────────
            // Conversión usando int.Parse
            // ──────────────────────────────────────────────

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nCONVERSIÓN DE STRING A INT CON int.Parse");
            Console.ResetColor();

            int numeroUnoConvertido = int.Parse(miPrimerNumeroString);
            int numeroDosConvertido = int.Parse(miSegundoNumeroString);

            int resultadoSumaNumerosConvertidos = numeroUnoConvertido + numeroDosConvertido;

            Console.WriteLine($"""
                
                Después de convertir los strings a números enteros la suma da como  resultado:
                {numeroUnoConvertido} + {numeroDosConvertido} = {resultadoSumaNumerosConvertidos}
                """);

            // ──────────────────────────────────────────────
            // Conversión usando int.TryParse
            // ──────────────────────────────────────────────

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nCONVERSIÓN DE STRING A INT CON int.TryParse");
            Console.ResetColor();

            string cadenaPrueba = "19";
            int numeroConvertido;
            bool conversionExitosa = int.TryParse(cadenaPrueba, out numeroConvertido);

            if (conversionExitosa)
            {
                Console.WriteLine($"""
                    
                    La cadena "{cadenaPrueba}" fue convertida correctamente a int: {numeroConvertido}
                    Tipo de dato original: {cadenaPrueba.GetType()}
                    Tipo de dato convertido: {numeroConvertido.GetType()}
                    """);
            }
            else
            {
                Console.WriteLine($"""
                    
                    El valor "{cadenaPrueba}" no se pudo convertir a int.
                    Verifica que el contenido sea numérico.
                    """);
            }

            // Segundo ejemplo: conversión fallida
            string cadenaNoValida = "Hola";
            bool resultadoConversion = int.TryParse(cadenaNoValida, out int numeroInvalido);

            Console.WriteLine($"""
                
                ¿Se puede convertir el string "{cadenaNoValida}" a un número entero? 
                {(!resultadoConversion ? "No, el valor ingresado no es convertible." : "Sí es convertible.")}
                """);

            // ──────────────────────────────────────────────
            // Conversión usando Int32.Parse
            // ──────────────────────────────────────────────

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nCONVERSIÓN DE STRING A INT CON Int32.Parse");
            Console.ResetColor();

            string stringNumeroUno = "19";
            string stringNumeroDos = "81";

            int numeroUno = Int32.Parse(stringNumeroUno);
            int numeroDos = Int32.Parse(stringNumeroDos);

            int resultadoSumaInt32 = numeroUno + numeroDos;

            Console.WriteLine($"""
                
                Después de convertir los strings a números enteros:
                {numeroUno} + {numeroDos} = {resultadoSumaInt32}
                """);

            // ──────────────────────────────────────────────
            // EJERCICIO PRÁCTICO
            // ──────────────────────────────────────────────

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nEJERCICIO PRÁCTICO: Conversión con int.Parse");
            Console.ResetColor();

            string miString = "22";
            int miInt = int.Parse(miString);

            Console.WriteLine($"""
                
                El valor de la cadena "{miString}" convertido a int es: {miInt}
                """);

            // ──────────────────────────────────────────────
            // Final
            // ──────────────────────────────────────────────

            Console.WriteLine("\nPresiona una tecla para salir...");
            Console.ReadKey();
        }
    }
}
