using System;

namespace _20_Ejercicio_Practico_Void
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                * Crea un método de tipo void que se llame Animales() ->
                * dentro del cual se debe imprimir en consola el siguiente mensaje: Hola. Habla el elefante ->
                * Recuerda luego agregar el llamado al nuevo método, dentro del método Main.
            */

            Animales();
            Console.ReadKey();
        }

        //Declarracion del metodo
        public static void Animales()
        {
            Console.WriteLine("Hola. Habla el elefante");
        }
    }
}
