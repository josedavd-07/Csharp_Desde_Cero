using System;

namespace _07_Cambiar_Colores_A_La_Consola_De_Ejecución
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Cambiar colores de la consola";

            //Cambiar el color del texto de la consola
            Console.WriteLine("Aca cambiamos el color del texto de la consola.");

            Console.ForegroundColor = ConsoleColor.Green; //Asignamos color al texto con esta sentencia
            Console.WriteLine("\nEste texto es de color verde");
            Console.ResetColor(); // Reseteamos el color del texto a su valor por defecto en este caso el blanco

            Console.WriteLine("\npresiona cualquiera tecla  para continuar con la ejecución del programa");
            Console.ReadKey();
            Console.Clear();

            //Cambiar el color del fondo de la consola
            string mensaje = ("Aca cambiamos el color del fondo de la consola a blanco y este texto es Magenta" +
                " pero lo veras en la siguiente ejecución , mientras tanto este texto sera magenta");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{mensaje} y todo en conjunto se vera en la siguiente ejecución. ");
            Console.ResetColor ();

            Console.WriteLine("\npresiona cualquiera tecla  para continuar con la ejecución del programa");
            Console.ReadKey();
            Console.Clear();

            //Cambio de fondo con texto completo.
            Console.BackgroundColor = ConsoleColor.White; //Asignamos color al fondo de la consola con esta sentencia
            Console.ForegroundColor = ConsoleColor.Magenta; //Asignamos color al texto con esta sentencia
            Console.WriteLine($"{mensaje} y ahora junto con el fondo blanco pero aun falta" +
                $" que todo sea blanco en la consola y lo veremos en la siguiente ejecucion");
            Console.ResetColor(); // Reseteamos el color del texto a su valor por defecto en este caso el blanco

            Console.WriteLine("\npresiona cualquiera tecla  para continuar con la ejecución del programa");

            Console.ReadKey(); //Esperamos a que el usuario presione una tecla para continuar
            Console.Clear(); //Limpiamos la consola

            //Cambio de fondo con texto completo.
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{mensaje} y ahora junto con el fondo  todo balnco y el texto correspondiente en magenta");

            Console.WriteLine("\n\npresiona cualquiera tecla  para continuar con la ejecución del programa");
            Console.ReadKey();
            Console.Clear();

            Console.ResetColor();
            Console.Clear();

            Console.WriteLine("Fin del programa, espero que te sirva este recurson y te sea de gran ayuda," +
                " presiona cualquiera tecla antes de salir, y sigue programando que este camino es maravilloso");
            Console.ReadKey ();
        }
    }
}
