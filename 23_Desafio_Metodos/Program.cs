using System;

namespace _23_Desafio_Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Forma natural de hacerla pero hacemos muchas llamadas hagamoslo de otra forma.

            String amigo1 = "Margie";
            String amigo2 = "Esteban";
            String amigo3 = "Abimael";
            String amigo4 = "Hernando";

            Console.WriteLine(SaludarAmigo(amigo1));
            Console.WriteLine(SaludarAmigo(amigo2));
            Console.WriteLine(SaludarAmigo(amigo3));
            Console.WriteLine(SaludarAmigo(amigo4));

            Console.WriteLine("\n\n");
            //Segunda forma de como hacerlo.
            string friend1 = "Margie";
            string friend2 = "Esteban"; 
            string friend3 = "Abimael";
            string friend4 = "Hernando";

            //SaludarAmigo2(friend1, friend2, friend3, friend4);
            SaludarAmigo2("karol", "luisa", "stiven", "carlos");
            Console.ReadKey();
        }

        /*
            * En este desafío, profundizarás tu comprensión 
            * de los métodos. La consigna es que crees 4
            * variables con los nombres de tus amigos.
            * 
            * Luego, crea un método llamado "SaludarAmigo" 
            * que escriba algo como: 
            * "¡Hola (nombre del amigo), que tengas un buen día!" 
            * en la consola. Donde dice "nombre del amigo" debe 
            * reemplazarse con el nombre que hayas puesto al 
            * llamar al método con un argumento.
            * 
            * Por lo tanto, el método necesitará un parámetro 
            * (decide tú qué tipo de datos es el mejor).
        */

        //FORMA 1 DE HACERLO PERO MAS REPETITIVO
        public static string SaludarAmigo(string amigo)
        {
            return $"¡Hola {amigo}, que tengas un buen día!";
        }

        //FORMA 2  DE HACERLO Y MENOS REPETITIVO PERO USANDO VOID

        public static void SaludarAmigo2(string friend1, string friend2, string friend3, string friend4)
        {
            Console.WriteLine($"¡Hola {friend1}, que tengas un buen día!");
            Console.WriteLine($"¡Hola {friend2}, que tengas un buen día!");
            Console.WriteLine($"¡Hola {friend3}, que tengas un buen día!");
            Console.WriteLine($"¡Hola {friend4}, que tengas un buen día!");
        }

        //No te quedes solo con mi solución hay mas forma de hacerlo puede ser con metodos sin retorno void o como desees
        //o como puedas desarrollarlo , sigue aprendiendo, con cariño Jose David Carranza Futuro Ingeniero de Sistemas.
    }
}
