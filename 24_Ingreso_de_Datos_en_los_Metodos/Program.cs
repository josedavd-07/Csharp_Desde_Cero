using System;

namespace _24_Ingreso_de_Datos_en_los_Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ESTO FUNCIONA SOLO DESCOMENTALO Y CORRERA
            /*
            string input = Console.ReadLine();
            */

            // Llamamos al método Calcular y mostramos el resultado en consola
            Console.WriteLine($"\nEl resultado de la suma de los valores ingresados es: {Calcular()}");
            

            Console.WriteLine($"\n\n\n");
               
            //DEMOSTRACIÓN NUMERO 2
            // Llamamos al método ObtenerDatos y descomponemos la tupla es decir pasamos los valores retornados
            // a las variables name y age , y mostramos el mensaje con los datos obtenidos.
            (string name, int age) = ObtenerDatos("",0);

            
            // Ahora mostramos el mensaje usando los datos obtenidos
            Console.WriteLine($"\nHola, mi nombre es {name} y tengo {age} años.");

            Console.ReadKey();
        }

        public static int Calcular()
        {
            Console.Write("Por favor, ingresa un número: ");
            string numero1Input = Console.ReadLine();
            Console.Write("\nPor favor, ingresa otro número: ");
            string numero2Input = Console.ReadLine();

            //Conversiones de datos
            int num1 = int.Parse(numero1Input);
            int num2 = int.Parse(numero2Input);

            int resultado = num1 + num2;
            return resultado;
        }
        
        /*
            * Método que retorna una tupla, es decir, un conjunto de datos.
            * Recibimos dos parámetros: un string y un entero.
            * El método comparte dos tipos de datos en una tupla,
            * y así la podemos usar en el método Main.
        */

        public static (string, int) ObtenerDatos(string name, int age)
        {
            Console.Write("\nPor favor, ingresa tu nombre: ");
            name = Console.ReadLine();

            Console.Write("\nPor favor, ingresa tu edad: ");
            age = int.Parse(Console.ReadLine());

            return (name, age);
        }
    } 
}
