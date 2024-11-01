using System;

namespace _12_Ejercicio_Practico_Metodos_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Ahora que conoce el uso de varias funciones de string, creemos una pequeña aplicación de consola para practicar esto.

                Declara una variable string y no le asignes ningún valor.

                Imprime en la consola “Por favor, ingresa tu nombre y presiona Enter”. A continuación, puedes ingresar tu nombre o cualquier otro string válido.

                Asigne ese string ingresado a la variable string que habías declarado inicialmente.

                El programa debe escribir en la consola:

                En la primera línea, ese string en mayúsculas

                En la segunda línea el mismo string en minúsculas

                En la tercera línea, escribe en la consola el string sin espacios en blanco al final o al principio (por ejemplo, si se ingresa " Federico ", debería escribirse en la consola "Federico").

                Y en la última línea, debe escribir el Substring del string ingresado en la consola.

                Este tipo de recursos se utilizan, por ejemplo, para crear una pantalla de inicio de sesión, para que el sistema elimine los espacios en blanco anteriores o finales, o que ignore la mayúscula del nombre de usuario ingresado.
            */


            //Mi solución al Planteamiento dado:
            //Variable declarada
            string nombre;

            //Pedida de información al usuario y luego almacenada en la variable declarada anteriormente.
            Console.WriteLine("Por favor, ingresa tu nombre y presiona Enter: ");
            nombre = Console.ReadLine();

            //Imprimir la información en mayusculas y minúsculas
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nSALIDA EN MAYUSCULAS:");
            Console.ResetColor();
            Console.WriteLine($"\n{nombre.ToUpper()}");//Salida mayúsculas

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nSALIDA EN MINUSCULAS:");
            Console.ResetColor();
            Console.WriteLine($"{nombre.ToLower()}");//Salida minúsculas

            //Imprimir valores sin espacios al comienzo y final de la cadena
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nSALIDA SIN ESPACIOS AL COMIENZO Y FINAL DE LA CADENA:\n");
            Console.ResetColor();
            Console.WriteLine($"{nombre.Trim()}");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nSALIDA DE SUBSTRING:");
            Console.ResetColor();
            //Imprimir el substring de la cadena
            Console.WriteLine($"\n{nombre.Substring(2)}");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nSalida de la informacion con el .Format");
            Console.ResetColor();
            string miNombreMayusculas = string.Format("\nMi nombre en mayusculas es: {0}", nombre.ToUpper());
            string miNombreMinusculas = string.Format("\nMi nombre en minusculas es: {0}", nombre.ToLower());
            string miNombreSinEspacios = string.Format("\nMi nombre sin espacios al inicio y final es: {0}", nombre.Trim());
            string miNombreSubstring = string.Format("\nMi nombre con un substring es: {0}", nombre.Substring(2));

            //Salidas
            Console.WriteLine(miNombreMayusculas);
            Console.WriteLine(miNombreMinusculas);
            Console.WriteLine(miNombreSinEspacios);
            Console.WriteLine(miNombreSubstring);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nEsto es todo por hoy  de los datos en distintos formatos usaando los metodoss de string" +
                " nos vemos en la otra clase, presiona cualquiera tecla para salir");
            Console.ResetColor();

            Console.ReadKey();
        }
    }
}
