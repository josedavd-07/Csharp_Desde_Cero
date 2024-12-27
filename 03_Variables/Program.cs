using System; //Uso del sistema de bibliotecas de C#
namespace _03_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Elmentos de una variable:

            /**
             * Elemento 1 = Tipo de dato
             * 
             * Elemento 2 = Nombre de la variable
             * 
             *  Elemento 3 = Valor de la variable
             */

            // Tipo nombre = valor;

            //Variable de tipo entero inicializada con el valor 10
            int numero = 10;
            int notaFinalCurso = 500; //Variable de tipo entero inicializada con el valor 500

            //Variable de tipo flotante inicializada con el valor 10.5
            float numeroFlotante = 10.5f;
            float numeroNotaFinalFlotante = 2.9f;

            //Variable sin inicializar que luego de cambiara su valor
            int numero2;
            string texto;

            //Mostramos los valores de las variables

            Console.WriteLine("El valor de la variable numero es: " + numero);
            Console.WriteLine("\nEl valor de la variable numeroFlotante es: " + numeroFlotante);
            Console.WriteLine("\nla nota final del curso es : " + notaFinalCurso);
            Console.WriteLine("\nla nota final del curso en flotante es : " + numeroNotaFinalFlotante);


            //Asignamos un nuevo valor a la variable numero
            Console.Write("\nIngrese un nuevo valor para la variable numero: ");
            numero2 = int.Parse(Console.ReadLine());

            //Aasignamos un nuevo valor a la variable texto
            Console.Write("\nIngrese un nuevo valor para la variable texto: ");
            texto = Console.ReadLine();

            //Esperamos la ejecucion de la consola.
            Console.WriteLine("\npresione una tecla para cerrar la consola.");
            Console.ReadKey();
        }
    }
}
