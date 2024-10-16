using System;

namespace _06_Clase_Console_Y_Sus_Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Clase Console
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nMETODOS DE LA CLASE CONSOLE");
            Console.ResetColor();


            //Metodo WriteLine(); de la clase Console
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nMetodo WriteLine();");
            Console.ResetColor();

            //Metodo WriteLine(); de la clase Console
            Console.WriteLine("\nHola, Mundo!");
            Console.WriteLine("\nHola yo Console.WriteLine(); soy un metodo de la clase Console" +
                " y los datos que doy salida lo hago con un salto de linea");

            //Metodo Write(); de la clase Console
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nMetodo Write();");
            Console.ResetColor();

            Console.Write("\nHola, Mundo!");
            Console.Write("\n\nHola yo Console.Write() soy un metodo de la clase Console" +
                " y los datos que doy salida lo hago sin un salto de linea como veras mi otro compañero Write" +
                " seguira explicando"
            );

            Console.Write(" que es lo que hace el metodo Write();, como te dije" +
                " escribo junto con mis demas hermanos write un texdto en muchas lineas pero somois uno solo");


            //Metodo Read(); de la clase Console
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\nMetodo Read();");
            Console.ResetColor();

            Console.WriteLine("\nHola yo soy Console.Read(); soy un metodo de la clase Console" +
                " y espero que ingreses un dato por teclado para poder leerlo" +
                " ademas puedo devolver un valor ASCII de lo que ingresaste"
            );

            //Metodo ReadLine(); de la clase Console
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nMetodo ReadLine();");
            Console.ResetColor();

            Console.WriteLine("\nHola yo soy Console.ReadLine(); soy un metodo de la clase Console" +
                " y espero que ingreses un dato por teclado para poder leerlo" +
                " ademas puedo devolver un valor de tipo string o int de lo que ingresaste" +
                "o el valor que lo hayas convertido"
            );

            //Metodo ReadKey(); de la clase Console
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nMetodo ReadKey();");
            Console.ResetColor();

            Console.WriteLine("\nHola yo soy Console.ReadKey(); soy un metodo de la clase Console" +
                " que  espero la ejecucion de consola al presionar cualquiera tecla" +
                " y esto nos permite ya sea  esperar la ejecucion del programa" +
                " y luego de todo ya salir con presionar alguna tecla" +
                " o esperar a que se ejecute un nuevo codigo por ejemplo antes de un Console.Clear();"
            );

            //Ejemplos de los metodos Read(); y ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nEjemplos de los metodos Read(); y ReadLine();");
            Console.ResetColor();
            
            //Metodo ReadLine(); que nos devuelve el valor de tipo string
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nMetodo ReadLine();");
            Console.ResetColor();

            Console.Write("\nIngrese un  valor y presione Enter: ");
            string leerEntrada = Console.ReadLine();
            Console.WriteLine($"\nEl valor ingresado es: {leerEntrada}");

            //Metodo Read(); que nos devuelve el valor ASCII
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nMetodo Read();");
            Console.ResetColor();

            //Aqui se muestra el valor ASCII de la tecla presionada

            Console.Write("\nIngrese cualquier valor o toque alguna tecla para saber su valor en ASCCI: ");
            int valorAscii = Console.Read();
            Console.WriteLine($"\nEl valor ASCII del valor ingresado es: {valorAscii}");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n***********************************");
            Console.ResetColor();

            //Aqui se muestra el valor ASCII de la tecla presionada y la tecla que sde presiono
            Console.Write("\nIngrese cualquier valor o toque alguna tecla para saber su valor en ASCII: ");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            int valorAsciiInput = keyInfo.KeyChar;
            Console.WriteLine($"\n\nLa tecla presionada es: {keyInfo.Key}");
            Console.WriteLine($"\nEl valor ASCII del valor ingresado es: {valorAsciiInput}");
            Console.ReadKey();

        }
    }
}
