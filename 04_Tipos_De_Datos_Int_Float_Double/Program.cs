using System;

namespace _04_Tipos_De_Datos_Int_Float_Double
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tipos de datos int, float y double";

            //DECLARACION MULTIPLE DE VARIABLES EN UNA SOLA LINEA.
            int  a,b,c;
            double x, y, z;
            float m, n, o;

            //En este apartado utilizaremos tipos de datos comolo son:
            //int, float y double

            //VARIABLES DE TIPO INT = ENTERO
            int num1 = 10;
            int num2 = 20;

            //Suma de los dos valores de tipo entero
            int suma = num1 + num2;

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nSUMA DE VALORES ENTEROS:");
            Console.ResetColor();

            //Mostramos el resultado con interpolaciuon de string o cadenas de texto
            Console.WriteLine($"\nla suma de {num1} + {num2} es: {suma}");

            //Mostramos el resultado con concatenación de string o cadenas de texto
            Console.WriteLine("\nla suma de " + num1 + " + " + num2 + " es: " + suma);

            //Mostramos el resultado usando concatenacion por medio de indices
            Console.WriteLine("\nla suma de {0} + {1} es: {2}", num1, num2, suma);


            //VARIABLES DE TIPO DOUBLE = DECIMAL
            double numDouble1 = 10.5;
            double numDouble2 = 20.5;

            double sumaDouble = numDouble1 + numDouble2;

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nSUMA DE VALORES DOUBLE:");
            Console.ResetColor();

            Console.WriteLine($"\nla suma de {numDouble1} + {numDouble2} es: {sumaDouble}");


            //SUMA DE VALOR INT EN UN DOUBLE
            double sumaWhitIntAndDouble = num1 + numDouble1;

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nSUMA DE VALORES INT DENTRO DE UN DOUBLE:");
            Console.ResetColor();

            Console.WriteLine($"\nla suma del numero entero {num1} más el numerodouble {numDouble1} es: {sumaWhitIntAndDouble}");


            //VARIABLES DE TIPO FLOAT = DECIMAL
            float numFloat1 = 10.5f;
            float numFloat2 = 20.5f;
            float sumaFloat = numFloat1 + numFloat2;

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nSUMA DE VALORES FLOAT:");
            Console.ResetColor();

            Console.WriteLine($"\nla suma de {numFloat1} + {numFloat2} es: {sumaFloat}");

            //Esperemos la ejecución de la consola.
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nPresiona una tecla para continuar...");
            Console.ResetColor();
            Console.ReadKey(); 
        }
    }
}


