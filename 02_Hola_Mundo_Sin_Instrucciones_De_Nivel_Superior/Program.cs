using System; //Uso del sistema de bibliotecas de C#

namespace _02_Hola_Mundo_Sin_Instrucciones_De_Nivel_Superior//Nombre del espacio de nombres del proyecto 
{
    internal class Program //Clase principal del proyecto
    {
        static void Main(string[] args)  //Método principal del proyecto de ejecución
        {
            Console.WriteLine("Hello, World!");  //Impresión de texto en consola
            Console.WriteLine("\n Este mensaje es para decirte que este mensaje fue" +
                " escrito sin usar las instrucciones de nivel superior en C#"); //Impresión de texto en consola

            Console.ReadKey(); //Espera a que el usuario presione una tecla para cerrar la consola
        }
    }
}

