using System;

namespace _27_Ejercicio_Practico_Operadores_Aritmeticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                * EJERCICIO NUMERO 1.
                * 
                * Almacenar dentro de la variable resultado, el resultado de la siguiente condición:
                * 
                * Si num1 es IGUAL (Operador de igualdad) a num2 O (Operador condicional) num3 es DISTINTO 
                * (Operador de desigualdad) a num4.
                * 
                * Imprimir en consola el valor de la variable resultado.
            */
            Console.WriteLine("Ejercicio 1:\n");
            int num1 = 5;
            int num2 = 4;
            int num3 = 9;
            int num4 = 7;
            bool resultado;

            resultado = num1 == num2 || num3 != num4;
            Console.WriteLine(resultado);



            /*
                * EJERCICIO NUMERO 2.
                * 
                * Dadas las variables ya creadas, se pide lo siguiente:
                * 
                * 1. Aumentar en uno el valor de la variable num2.
                *    Para ello, utiliza el operador de adición.
                * 
                * 2. Comparar si la variable num2 es mayor que num1 y almacenar 
                *    la respuesta en la variable resultado.
                *    Para ello, usa los operadores relacionales.
                * 
                * 3. Imprimir en consola la variable resultado, pero negado.
                *    Para ello, usa el operador unitario correspondiente.
            */
            Console.WriteLine("\n\nEjercicio 2:\n");
            int numero1 = 5;
            int numero2 = 4;
            bool resultados;

            numero2++;
            resultados = numero1 < numero2;
            Console.WriteLine(!resultados);

            Console.ReadKey();
        }
    }
    
}
