using System;

namespace _20_Ejercicio_Practico_Void
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                * Crea un método de tipo void que se llame Animales() ->
                * dentro del cual se debe imprimir en consola el siguiente mensaje: Hola. Habla el elefante desde un metodo sin parametros ->
                * Recuerda luego agregar el llamado al nuevo método, dentro del método Main.
            */

            Animales();
            AnimalesUsandoParametros("Hola. Habla el elefante desde un metodo con parametros");
            Console.ReadKey();
        }

        //Declarracion del metodo
        public static void Animales()
        {
            Console.WriteLine("Hola. Habla el elefante desde un metodo sin parametros");
        }


        /*
            * Crea el mismo método que en el ejercicio previo, -> 
            * pero en lugar de que el mensaje se escriba dentro del método AnimalesUsandoParametros() -> 
            * el mismo debe enviarse como parámetro o argumento del método en el momento -> 
            * de hacer el llamado desde el método Main. El mensaje debe ser el mismo pero en vez de sin parametro con parametros 
        */

        public static void AnimalesUsandoParametros(string animales)
        {
            Console.WriteLine($"\n{animales}");
        }
    }
}
