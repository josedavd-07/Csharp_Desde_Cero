using System;

namespace _10_Conversion_Parsing_De_Int_A_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
            * Conversiones de tipo  string a int es decir Parsing
            */
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("CONVERSIONES DE TIPO STRING A INT");
            Console.ResetColor();

            string miPrimerNumeroString = "200";
            string miSegundoNumeroString = "5";

            Console.WriteLine($"\nEl resultado de estos dos numeros al concatenarnos o sumarlos nos va a dar" +
                $" como resultado 2005 y no 205 como seria correspondientemente."
            );

            // Operacion de suma entre los dos valores de tipo string
            string resultadoSuma = miPrimerNumeroString + miSegundoNumeroString;
            Console.WriteLine($"\nEl resultado de la suma de los valores de" +
                $" {miPrimerNumeroString} + {miSegundoNumeroString} da como resultado: {resultadoSuma}"
            );

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nCONVERSIONES DE LOS VALORES DE STRING A INT CON int.Parse");
            Console.ResetColor();

            // Numero convertido usando el metodo Parse con el dato int.parse
            // Creamos una variable de tipo int y pasamos el valor de la variable string a int
            // Y nos quedaria  ahora si la suma de los valores de los numeros ya que el datos
            // ya que ahora ya no es un string si no un int.
            int numeroUnoConvertido = int.Parse(miPrimerNumeroString);
            int numeroDosConvertido = int.Parse(miSegundoNumeroString);
            int resultadoSumaNumerosConvertidos = numeroUnoConvertido + numeroDosConvertido;
            Console.WriteLine($"\nEl resultado de la suma de los valores de los numeros Convertidos desde" +
                $" string a int son el numero {numeroUnoConvertido} + {numeroDosConvertido}" +
                $"  da como resultado el valor de: {resultadoSumaNumerosConvertidos}"
            );

            /**
            * Conversion de tipo string a int32.TryParse , Manera uno de hacerlo
            */

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nCONVERSIONES DE LOS VALORES DE STRING A INT CON int32.TryParse");
            Console.ResetColor();

            string strinNumeroUnoPruebaConversion = "19";
            int esConvertible;
            bool conversion = int.TryParse(strinNumeroUnoPruebaConversion, out esConvertible);

            if (conversion)
            {
                Console.Write($"\nEl valor de la variable de tipo string");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($" - string strinNumeroUnoPruebaConversion = \"19\" - ");
                Console.ResetColor();
                Console.Write($" al mirar su tipo de dato podemos observar que es de tipo" +
                    $" {strinNumeroUnoPruebaConversion.GetType()} y al convertirlo a int por medio de");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($" - int.TryParse(strinNumeroUnoPruebaConversion, out esConvertible); - ");
                Console.ResetColor();
                Console.Write($" Podemos mirar que su valor cambio al int: {esConvertible} , y su valor" +
                    $" que contiene  es de tipo: {esConvertible.GetType()}");
            }
            else
            {
                Console.WriteLine($"\nEl valor de la variable {strinNumeroUnoPruebaConversion} no es convertible a int" +
                    $" Revisa que tenga caracteres de tipo numero");
            }

            //****************************************

            // Numero convertidos usando el int32.Parse
            // Creamos una variable de tipo int y pasamos el valor de la variable string a int
            // Y nos quedaria  ahora si la suma de los valores de los numeros ya que el datos
            // ya que ahora ya no es un string si no un int.

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\nCONVERSIONES DE LOS VALORES DE STRING A INT YA CONVERTIDOS CON Int32.Parse");
            Console.ResetColor();

            // Declaracion de variables usadas para la conversion de string a int32.Parse
            string stringNumeroUnoPruebaConversion = "19";
            string stringNumeroDosPruebaConversion = "81";

            // Conversion de string a int usando el metodo Int32.Parse
            int _numeroUnoConvertido = Int32.Parse(stringNumeroUnoPruebaConversion);
            int _numeroDosConvertido = Int32.Parse(stringNumeroDosPruebaConversion);
            int _resultadoSumaNumerosConvertidos = _numeroUnoConvertido + _numeroDosConvertido;
            Console.WriteLine($"\nEl resultado de la suma de los valores de los numeros Convertidos desde" +
                $" string a int son el numero {_numeroUnoConvertido} + {_numeroDosConvertido}" +
                $"  da como resultado el valor de: {_resultadoSumaNumerosConvertidos}"
            );

            /**
            * Ejercicio de practica conversion con int.Parse.
            *
            * Haz el parsing para convertir el contenido de la variable
            * miString a número entero y almacenarlo en la variable miInt
            */

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nEJERCICIO DE PRACTICA CONVERSION CON int.Parse");
            Console.ResetColor();

            string miString = "22";
            int miInt = int.Parse(miString);

            Console.WriteLine($"\nLa suma del valor int luego de ser convertido es de : {miInt}");
            Console.ReadKey();
        }
    }
}