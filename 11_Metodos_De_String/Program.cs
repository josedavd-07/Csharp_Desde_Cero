using System;

namespace _11_Metodos_De_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
                * Métodos de string como:
                * 
                * string.Concat(string, string):
                * - Se utiliza para concatenar varias cadenas de texto.
                * 
                * Substring(int startIndex): 
                * - Obtiene una porción de la cadena de texto comenzando desde el índice especificado.
                * 
                * ToLower(): 
                * - Convierte una cadena de texto a minúsculas.
                * 
                * ToUpper():
                * - Convierte una cadena de texto a mayúsculas.
                * 
                * Trim(): 
                * - Elimina los espacios en blanco al principio y al final de una cadena de texto.
                * 
                * IndexOf(string):
                * - Devuelve el índice de la primera aparición de un carácter dentro de un string.
                * 
                * IsNullOrWhiteSpace(string):
                * - Devuelve true si la cadena de texto es nula o solo contiene espacios en blanco.
                * 
                * String.Format():
                * - Permite formatear cadenas de texto, incluyendo valores de variables o expresiones en un formato especificado.
                * - Sintaxis: string.Format("texto{índice}", valor o variable)
                * 
                * Ejemplo: 
                * 
                * var nombre = "Jose";
                * string.Format("Hola {0}", nombre);
                * - Resultado: "Hola Jose"
                */

            // Variables utilizadas para los ejemplos de cada uno de estos métodos de string
            string nombre = " Jose";
            string apellido = "Carranza";

            // Ejemplo original proporcionado de uso de Concat y Trim
            string nombreCompletoOriginal = string.Concat("", nombre, apellido, ""); // Concatena sin eliminar espacios
            Console.WriteLine(nombreCompletoOriginal.Trim()); // Salida: "JoseCarranza"

            // Ejemplo alternativo de uso de Concat y Trim
            string nombreCompletoAlternativo = string.Concat(nombre.Trim(), " ", apellido); // Concatena después de quitar los espacios en blanco
            Console.WriteLine(nombreCompletoAlternativo); // Salida: "Jose Carranza"

            // Salidas de los métodos
            Console.WriteLine(nombre.Substring(2));          // Salida: "ose"
            Console.WriteLine(nombre.ToLower());             // Salida: "jose"
            Console.WriteLine(nombre.ToUpper());             // Salida: "JOSE"
            Console.WriteLine(nombre.IndexOf("o"));          // Salida: 1
            Console.WriteLine(string.IsNullOrWhiteSpace("")); // Salida: True
            Console.WriteLine(string.IsNullOrWhiteSpace(nombre)); // Salida: False

            // Ejemplo de uso de String.Format
            var saludo = string.Format("Hola, {0} {1}", nombre.Trim(), apellido);
            Console.WriteLine(saludo); // Salida: "Hola, Jose Carranza"

            /**
                * Otros métodos de string como:
                * 
                * Contains(string):
                * - Verifica si una cadena contiene otra cadena especificada.
                * - Ejemplo: nombre.Contains("ose") devuelve True.
                * 
                * StartsWith(string):
                * - Verifica si una cadena comienza con una cadena específica.
                * - Ejemplo: nombre.StartsWith(" J") devuelve True.
                * 
                * EndsWith(string):
                * - Verifica si una cadena termina con una cadena específica.
                * - Ejemplo: apellido.EndsWith("za") devuelve True.
                * 
                * Replace(string, string):
                * - Reemplaza todas las apariciones de una subcadena por otra.
                * - Ejemplo: nombre.Replace(" ", "") devuelve "Jose".
                * 
                * Split(char):
                * - Divide una cadena en un arreglo de subcadenas, usando el carácter especificado.
                * - Ejemplo: nombreCompletoAlternativo.Split(' ') divide "Jose Carranza" en ["Jose", "Carranza"].
                * 
                * Join(string, string[]):
                * - Combina un arreglo de cadenas en una sola cadena, usando un delimitador.
                * - Ejemplo: string.Join(" ", nombreCompletoAlternativo.Split(' ')) devuelve "Jose Carranza".
            */

            // Ejemplos de uso de métodos adicionales
            Console.WriteLine(nombre.Contains("ose"));         // Salida: True
            Console.WriteLine(nombre.StartsWith(" J"));        // Salida: True
            Console.WriteLine(apellido.EndsWith("za"));        // Salida: True
            Console.WriteLine(nombre.Replace(" ", ""));        // Salida: "Jose"
            Console.WriteLine(string.Join(", ", nombreCompletoAlternativo.Split(' '))); // Salida: "Jose, Carranza"

            // Esperamos la consola antes de cerrar
            Console.ReadKey();
        }
    }
}
