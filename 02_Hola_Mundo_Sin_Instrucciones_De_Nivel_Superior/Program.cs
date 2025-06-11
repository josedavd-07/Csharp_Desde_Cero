using System; // Uso de las bibliotecas base del sistema de C#

namespace _02_Hola_Mundo_Sin_Instrucciones_De_Nivel_Superior // Espacio de nombres del proyecto
{
    internal class Program // Clase principal del programa
    {
        // Método principal de ejecución
        static void Main(string[] args)
        {
            // Mensaje básico en consola
            Console.WriteLine("Hello, World!");

            // Mensaje explicativo sobre el uso tradicional de C#
            Console.WriteLine(
                "\nEste mensaje indica que fue escrito SIN usar las instrucciones de nivel superior en C#. " +
                "Es decir, es la forma tradicional anterior a .NET 6, en la cual aún se desarrollan muchos proyectos.\n"
            );

            // Mensaje multilínea usando comillas triples
            Console.WriteLine("""
                Hola, esto es un mensaje con formato multilínea,
                usando comillas triples. Es una forma moderna de escribir texto
                en varias líneas sin utilizar el carácter de salto de línea \n.
                Ideal para mensajes largos o documentación embebida.
                """
            );

            // Mensaje de cierre
            Console.WriteLine("\nPresiona cualquier tecla para continuar...");
            Console.ReadKey(); // Espera la pulsación de una tecla antes de cerrar
        }
    }
}
