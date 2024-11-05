using System;

namespace _22_Ejercicio_Practico_Metodos_Retorno_de_Valores_y_Parametros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio de resta
            Console.Write("La Resta de los valores 15 + 8 da como resultado el valor de: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{Resta(15,8)}");
            Console.ResetColor();

            //Ejercicio de trabajar cojn string
            Console.Write(MiNombre("Federico"));

            Console.ReadKey();
        }

        /*
            * Declara un nuevo método que retorne un valor de tipo int y que reciba dos parámetro, ->
            * también de tipo int que al llamarlo se le debe pasar los valores 15 y 8. -> 
            * El método debe retornar la resta entre estos dos valores. -> 
            * Recuerda que dentro del método Main se debe imprimir en consola el retorno del método antes mencionado. 
        */

        public static int Resta(int num1, int num2)
        {
            return num1 - num2;
        }


        /*
            * Declara un nuevo método que retorne un valor de tipo string -> 
            * y que reciba por parámetro una variable también de tipo string -> 
            * que al llamarlo se le debe pasar el valor Federico. El método debe -> 
            * retornar el siguiente mensaje: Mi nombre es Federico ->
            * Recuerda que dentro del método Main se debe imprimir en consola -> 
            * el retorno del método antes mencionado.
        */

        public static string MiNombre(string nombre)
        {
            /*
                * Formas de hacerlo verás que solo se ejecutará la primera línea de retorno.
                * Esta es la más natural, la de retornar el valor con `return nombre;`.
                * Aunque también puede ser con un método `WriteLine` o solo el mensaje en el `return`.
                * Como lo vemos más adelante, no funcionarán porque no están de primeros en la línea de ejecución.
                * Ya que esto es programación estructurada y se ejecuta de arriba hacia abajo.
            */
            // Forma natural de el return y puede ser con un `WriteLine` o solo el retur sin mensaje.
            Console.Write($"\n\nMi nombre es: "); 

            Console.ForegroundColor = ConsoleColor.Green;
            return nombre;
            Console.ResetColor();

            
            /*
                * Estas son las siguientes formas de hacerlo, las cuales comentaremos para que
                * no se ejecuten. Si deseas ver cómo funciona, puedes descomentarlas.
                * 
                * Con el atajo de teclado `Ctrl + K + U` puedes descomentar todo el bloque de código.
                * Con el atajo de teclado `Ctrl + K + C` puedes comentar todo el bloque de código.
            */

            //Esta es la más habituales:
            /*
            return ($"\nMi nombre es {nombre}");
            return "Mi nombre es " + nombre;
            return $"\nMi nombre es {nombre}";
            
            //Estas son menos habituales:
            return string.Format("Mi nombre es {0}", nombre);
            return string.Concat("Mi nombre es ", nombre);
            */
        }
    }
}
