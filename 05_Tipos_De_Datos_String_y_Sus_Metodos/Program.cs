using System;

namespace _05_Tipos_De_Datos_String_y_Sus_Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable de tipo string
            string myName = "Jose David";
            string message = $"Hola me permito presentarme mi nombre es: {myName}";

            //Imprimimos el valor de la forma mas basica
            Console.WriteLine(myName);

            //Imprimimos el valor de la variable con interpolacion de string y un mensaje adicional
            Console.WriteLine($"\nHola me permito presentarme mi nombre es: {myName}");

            //Imprimimos el valor de la variable con concatenacion de string y un mensaje adicional
            Console.WriteLine($"\n{message} {myName}\n");
            Console.WriteLine(message);

            //Mostrar mensajes con los metodos de string
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nMENSAJES CON METODOS DE STRING:");
            Console.ResetColor();

            //Metodo ToUpper() convierte el texto a mayusculas
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nMENSAJES CON METODO ToUpper()");
            Console.ResetColor();

            Console.WriteLine($"\nEste mensaje usa  el Metodo ToUpper() para poner todo el" +
                $" siguinte texto de mi nombre en MAYUSCULA: {myName.ToUpper()}");

            //Metodo ToLower() convierte el texto a minusculas
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nMENSAJES CON METODO ToLower()");
            Console.ResetColor();

            Console.WriteLine($"\nEste mensaje usa  el Metodo ToLower() para poner todo" +
                $" el siguinte texto de mi nombre en minuscula: {myName.ToLower()}");

            Console.WriteLine("\nPresione una tecla para cerrar la consola.");
            Console.ReadKey();
        }
    }
}
