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

            //Operacion de suma entre los dos valores de tipo string
            string resultadoSuma = miPrimerNumeroString + miSegundoNumeroString;
            Console.WriteLine($"\nEl resultado de la suma de los valores de" +
                $" {miPrimerNumeroString} + {miSegundoNumeroString} da como resultado: {resultadoSuma}"
            );
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nCONVERSIONES DE LOS VALORES DE STRING A INT CON int.Parse");
            Console.ResetColor();

            //Numero convertido usando el metodo Parse con el dato int.parse
            //Creamos una variable de tipo int y pasamos el valor de la variable string a int
            //Y nos quedaria  ahora si la suma de los valores de los numeros ya que el datos
            //ya que ahora ya no es un string si no un int.
            int numeroUnoConvertido = int.Parse(miPrimerNumeroString);
            int numeroDosConvertido = int.Parse(miSegundoNumeroString);
            int resultadoSumaNumerosConvertidos  = numeroUnoConvertido + numeroDosConvertido;
            Console.WriteLine($"\nEl resultado de la suma de los valores de los numeros Convertidos desde" +
                $" string a int son el numero {numeroUnoConvertido} + {numeroDosConvertido}" +
                $"  da como resultado el valor de: {resultadoSumaNumerosConvertidos}"
            );

            //Numero convertidos usando el int32.Parse
            //Creamos una variable de tipo int y pasamos el valor de la variable string a int
            //Y nos quedaria  ahora si la suma de los valores de los numeros ya que el datos
            //ya que ahora ya no es un string si no un int.

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nCONVERSIONES DE LOS VALORES DE STRING A INT YA CONVERTIDOS CON Int32.Parse");
            Console.ResetColor();

            //Decalracion de variables usadas para la conversion de string a int32.Parse
            string strinNumeroUnoPruebaConversion = "19";
            string stringNumeroDosPruebaConversion = "81";

            //Conversion de string a int usando el metodo Int32.Parse
            int _numeroUnoConvertido = Int32.Parse(strinNumeroUnoPruebaConversion);
            int _numeroDosConvertido = Int32.Parse(stringNumeroDosPruebaConversion);
            int _resultadoSumaNumerosConvertidos = _numeroUnoConvertido + _numeroDosConvertido;
            Console.WriteLine($"\nEl resultado de la suma de los valores de los numeros Convertidos desde" +
                $" string a int son el numero {_numeroUnoConvertido} + {_numeroDosConvertido}" +
                $"  da como resultado el valor de: {_resultadoSumaNumerosConvertidos}"
            );
            Console.ReadKey();
        }
    }
}
