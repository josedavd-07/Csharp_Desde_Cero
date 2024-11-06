using System;

namespace _29_Ejercicios_Practicos_Toma_de_Decisiones_If
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EN AMBOS EJERCICIOS UTILIZAREMOS SOLO LA SECUENCIA, IF , MAS ADELANTE VEREMOS LOS ELSE IF Y ELSE

            /*
                * EJERCICIO NUMERO 1.
                * 
                * Dada la variable edad, crear una estructura condicional con dos if 
                * donde se valide si la edad es menor a 18 o mayor o igual a 18.
                * 
                * Se debe imprimir en consola los mensajes:
                * 
                * - "Eres menor de edad" si la edad es menor a 18.
                * - "Eres mayor de edad" si la edad es mayor o igual a 18.
            */


            int edad = 19;

            if (edad < 18)
            {
                Console.WriteLine("Eres menor de edad");
            }
            if (edad >= 18)
            {
                Console.WriteLine("Eres mayor de edad");
            }


            /*
                * EJERCICIO NUMERO 2.
                * 
                * Dada la variable resultadoExamen, crear una estructura condicional con tres if 
                * donde se valide el resultado e imprima en consola un mensaje en cada caso:
                * 
                * - Si la nota es menor a 4, se debe escribir el mensaje "Aplazado".
                * - Si la nota es igual a 4, se debe escribir el mensaje "Aprobado".
                * - Si la nota es mayor a 4, se debe escribir el mensaje "Felicitaciones".
            */

            int resultadoExamen = 6;

            if (resultadoExamen < 4)
            {
                Console.WriteLine("Aplazado");
            }
            if (resultadoExamen == 4)
            {
                Console.WriteLine("Aprobado");
            }
            if (resultadoExamen > 4)
            {
                Console.WriteLine("Felicitaciones");
            }

            Console.ReadKey();
        }
    }
}
