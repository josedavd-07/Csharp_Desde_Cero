using System;

namespace _25_Manejo_de_Errores_Try_Catch_y__Finally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                * En sentido practico veremos el Try Catch y Finally
                * 
                * en si este significa atrapar errores y finalmente hacer algo para corregirlo.
                * 
                * 
            */

            //VALOR DE USO DE TRY CATCH Y FINALLY
            Console.Write("Por favor, ingresa un número: ");
            string valorIngresado = Console.ReadLine();

            //Variables del primer ejemplo
            int num1 = 5;
            int num2 = 0;
            int resultado;

            //Ejemplo numero 1
            try
            {
                //No se puede dividir por cero por lo que se generará una excepción
                resultado = num1 / num2;
            }
            catch (DivideByZeroException)
            {

                Console.WriteLine("No se puede dividir por cero");
            }


            //Ejemplo numero 2
            // Si deseamos que se manejen todos las excepciones solo usamos la clase Exception yo si no solo las nombramos una por una.
            try
            {
                int valorComoInt = int.Parse(valorIngresado);
            }
            catch (FormatException)
            {
                Console.WriteLine("El formato del valor ingresado es incorrecto");

            }
            catch (OverflowException)
            {
                Console.WriteLine("El numero ingresado es demasiado largo o demasiado corto");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("No se ha ingresado ningún valor");
            }
            finally
            {
                Console.WriteLine("Esta frase aparecerá pase lo que pase");
            }

            Console.ReadKey();
        }
    }
}
