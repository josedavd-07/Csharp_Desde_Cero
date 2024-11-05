using System;

namespace _19_Metodo_Void
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Método void sin parametro.
            EscribeAlgo();

            // Método void con parametro.
            EscribeAlgoEspecifico("Soy un argumento y me llamaron desde un método, por medio  de un " +
                "parametro que fui asignado");


            Console.ReadKey();
        }

        // NivelDeAcceso - (static) - TipoDeRetorno - NombreDelMétodo (Parámetro1, Parámetro2)
        public static void EscribeAlgo()
        {
            Console.WriteLine("Yo nací en un método el cual se llama 'EscribeAlgo' y soy publico de tipo" +
                " estatico yu no retorno datos");
        }

        public static void EscribeAlgoEspecifico(string miTexto)
        {
            Console.WriteLine($"\n{miTexto}");
        }
    }
}
