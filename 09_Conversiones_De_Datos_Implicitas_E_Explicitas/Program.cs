using System;

namespace _09_Conversiones_De_Datos_Implicitas_E_Explicitas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
             * Conversion Explicita
             * 
             * Trata de convertir un tipo de dato mayor a uno menor
             * En este caso un double a un int
             * Lo que hace es que perdemos información
             * porque un numero decimal como el double  no cabe completo en un int 
             */
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("CONVERSION EXPLICITA");
            Console.ResetColor();

            double miNumeroDouble = 13.40;
            int miNumeroInt;
            //se hace la conversion tras la asignacion del nuevo tipo de dato.
            //Tomanddo el valor del doble y se asigna  al valor int.
            miNumeroInt = (int)miNumeroDouble;

            Console.WriteLine($"\nEl numero 'double' con valor decimal de {miNumeroDouble}" +
                $" convertido a un tipo de dato entero 'int' da como resultado perdida de" +
                $" datos e informacion lo cual perdemos los decimales de nuestro numero" +
                $" double y nos da como rsultado un numero entero con  valor de: {miNumeroInt}"
            );


            /*****************************/


            /** Conversión Implícita
             *
             * En la conversion implicita no se pierde información
             * Porque se convierte un tipo de dato menor a uno mayor}
             * Y este proceso se hace de forma automatica
             * Ya que el valro cabe automaticamente en el nuevo tipo de dato
             * Al que se va a convertir
             */
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nCONVERSION IMPLICITA");
            Console.ResetColor();

            //Conversion implicita entero a long
            int numeroEntero = 1345;
            long numeroLong = numeroEntero;
            Console.WriteLine($"\nEl número 'int' con valor de {numeroEntero}" +
                $" convertido a un tipo de dato 'long' da como resultado: {numeroLong}");

            // Conversión implícita float a double
            float numeroFloat = 13.45F;
            double numeroDouble = numeroFloat;
            Console.WriteLine($"\nEl número 'float' con valor de {numeroFloat}" +
                $" convertido a un tipo de dato 'double' da como resultado: {numeroDouble}");

            /**
             * Conversion de tipo
             * 
             * Se convierte un tipo de dato entero o numerico a un dato de tipo string
             * No se pierde informacion en este proceso
             * Pero el valor pasa a ser string y no se podran hacer operaciones matematicas
             * porquue su nuevo valor es de tipo string
             * serria usado para mostrar informacion en pantalla numerica como texto
             */

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nCONVERSION DE TIPO");
            Console.ResetColor();

            // Convertimos un entero a un string
            int numeroPrueba = 13;
            string numeroString = numeroPrueba.ToString();
            Console.WriteLine($"\nEl número 'int' con valor de {numeroPrueba}" +
                $" convertido a un tipo de dato 'string' da como resultado: {numeroString} pero con valor de string");

            bool elSolBrilla = true;
            string miBoolString = elSolBrilla.ToString();
            Console.WriteLine($"\nEl valor booleano 'bool' con valor de {elSolBrilla}" +
                $" convertido a un tipo de dato 'string' da como resultado: {miBoolString} pero con valor de string");

            Console.ReadKey();
        }
    }
}




