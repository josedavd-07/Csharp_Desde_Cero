using System;

namespace _07_Cambiar_Colores_A_La_Consola_De_Ejecución
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Cambiar colores de la consola";

            // --- PRIMER BLOQUE: Cambiar color del texto ---
            Console.WriteLine("Aquí cambiamos el color del texto de la consola.");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nEste texto es de color verde");

            Console.ResetColor();
            Console.WriteLine("\nPresiona cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            // --- SEGUNDO BLOQUE: Mostrar mensaje con color de texto (sin cambiar fondo aún) ---
            string mensaje = """

                Aquí cambiamos el color del fondo de la consola a blanco y este texto es magenta,
                pero lo verás en la siguiente ejecución. Mientras tanto, este texto será magenta.

                """;

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"\n{mensaje}");
            Console.ResetColor();

            Console.WriteLine("\nPresiona cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            // --- TERCER BLOQUE: Cambiar fondo (aún no limpia toda la consola) ---
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine($"\n{mensaje}\n Ahora se muestra con fondo blanco," +
                $" pero veremos toda la consola en blanco en la siguiente ejecución.");

            Console.ResetColor();
            Console.WriteLine("\nPresiona cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            // --- CUARTO BLOQUE: Fondo blanco aplicado a toda la consola ---
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear(); // aplica el fondo blanco a toda la consola

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"\n{mensaje}\nAhora se muestra completamente con fondo blanco y texto magenta.");

            Console.WriteLine("\nPresiona cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            // --- FINAL ---
            Console.ResetColor();
            Console.Clear();

            Console.WriteLine("Fin del programa. Espero que te sirva este recurso y te sea de gran ayuda.");
            Console.WriteLine("Presiona cualquier tecla antes de salir, y sigue programando. ¡Este camino es maravilloso!");

            Console.ReadKey();
        }
    }
}

