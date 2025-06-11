using System;

namespace _06_Clase_Console_Y_Sus_Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Título
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nMÉTODOS DE LA CLASE CONSOLE");
            Console.ResetColor();

            // ===============================
            // Método WriteLine()
            // ===============================
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nMétodo WriteLine()");
            Console.ResetColor();

            Console.WriteLine("\nHola, Mundo!");
            Console.WriteLine("Yo soy Console.WriteLine(), un método que muestra texto y luego hace un salto de línea.");

            // ===============================
            // Método Write()
            // ===============================
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nMétodo Write()");
            Console.ResetColor();

            Console.Write("Hola, Mundo!");
            Console.Write("\nYo soy Console.Write(), y escribo en la consola sin hacer un salto de línea.");
            Console.Write(" Junto con mis hermanos, podemos escribir texto seguido, línea tras línea.");

            // ===============================
            // Método Read()
            // ===============================
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\nMétodo Read()");
            Console.ResetColor();

            Console.WriteLine("\nYo soy Console.Read(), espero que ingreses un valor por teclado.");
            Console.WriteLine("Devuelvo el código ASCII del primer carácter ingresado.");

            // ===============================
            // Método ReadLine()
            // ===============================
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nMétodo ReadLine()");
            Console.ResetColor();

            Console.WriteLine("\nYo soy Console.ReadLine(), espero una línea completa de texto y la devuelvo como string.");

            // ===============================
            // Método ReadKey()
            // ===============================
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nMétodo ReadKey()");
            Console.ResetColor();

            Console.WriteLine("\nYo soy Console.ReadKey(), espero que presiones una tecla y capturo esa entrada.");
            Console.WriteLine("Puedo ser útil para pausar la ejecución del programa o detectar teclas presionadas.");

            // ===============================
            // EJEMPLOS
            // ===============================
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\nEJEMPLOS DE LOS MÉTODOS ReadLine() Y Read()");
            Console.ResetColor();

            // Leer con ReadLine()
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nEjemplo: ReadLine()");
            Console.ResetColor();

            Console.Write("Ingrese un valor y presione Enter: ");
            string leerEntrada = Console.ReadLine();
            Console.WriteLine($"El valor ingresado es: {leerEntrada}");

            // Leer con Read()
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nEjemplo: Read()");
            Console.ResetColor();

            Console.Write("Presiona una tecla para obtener su valor ASCII: ");
            int valorAscii = Console.Read();
            Console.WriteLine($"El valor ASCII de la tecla ingresada es: {valorAscii}");

            // Leer con ReadKey()
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nEjemplo: ReadKey()");
            Console.ResetColor();

            Console.Write("Presiona una tecla para obtener su información: ");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            int asciiDeLaTecla = keyInfo.KeyChar;

            Console.WriteLine($"\n\nTecla presionada: {keyInfo.Key}");
            Console.WriteLine($"Valor ASCII: {asciiDeLaTecla}");

            // Finalizar
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\nPresiona cualquier tecla para finalizar...");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
 