using System;

namespace _18_Metodos_Teoría
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
                * Teoría de  los Métodos:
                * 
                * ¿ Qué es un método?
                * 
                * Un metod es un bloque de codigo que contiene una serie de instrucciones.
                * un programa hace que se ejecute una serie de instrucciones en un orden determinado. ->
                * al llamar al metodo y especificando sus argumentos del metodo que necesita para funciona.
                * 
                * todas las instrucciones se ejecutan en el orden en el que se escriben en el metodo principal Main.->
                * 
                * El metodo Main es el punto de entrada de un programa en C# para cada aplicación. ->
                * 
                * y se llama mediante Common Language Runtime (CLR) cuando se ejecuta el programa.
                * 
            */

            /* 
                * Sinstaxis de un metodo:
                * 
                * <Especificador de acceso> <Tipo de retorno> <Nombre del metodo> (parametros)
                * {
                *       Cuerpo del Metodo
                * }
            */

            /* 
                * Ejemplo de un metodo:
                * 
                * public int Suma(int a, int b)
                * {
                *       return a + b;
                * }
            */

            /* 
                * Especificador de acceso: Determina la visibilidad del metodo desde otras clases.
                * 
                * public: el metodo es accesible desde cualquier parte del programa.
                * 
                * private: el metodo solo es accesible desde la clase en la que se define.
                * 
                * protected: el metodo es accesible desde la clase en la que se define y desde las clases derivadas.
                * 
                * internal: el metodo es accesible desde el ensamblado en el que se define.
                * 
                * protected internal: el metodo es accesible desde la clase en la que se define,->
                * desde las clases derivadas y desde el ensamblado en el que se define.
            */

            /* 
                * Tipo de retorno: Especifica el tipo de valor que devuelve el metodo, el tipo de retorno es el tipo de dato, ->
                * del valor que va a devolver el metodo, si el metodo no devuelve ningun valor se utiliza la palabra clave void.
                * 
                * void: el metodo no devuelve ningun valor.
                * 
                * int: el metodo devuelve un valor entero.
                * 
                * string: el metodo devuelve un valor de tipo cadena.
                * 
                * bool: el metodo devuelve un valor booleano.
                * 
                * double: el metodo devuelve un valor de tipo doble.
            */

            /* 
                * Nombre del metodo: Es un identificador unico y sensibloe a mayusculas,  no puede ser igual ->
                * al nombre de la misma clase ,ademas el nombre que se le da al metodo, -> 
                * se utiliza para llamar al metodo desde otras partes del programa.
                * 
                * Los nombres de los metodos deben seguir las reglas de identificadores de C#.
                * 
                * Los nombres de los metodos deben ser descriptivos y deben indicar la funcionalidad del metodo.
            */

            /* 
                * Parametros: Son valores que se pasan al metodo para que pueda realizar su tarea. ->
                * Estan encerrados entre parentesis , los parametros se utilizan para pasar y recibir datos en un metodo -> 
                * los parametros son opcionales pueden contener o contenerlos internamentente en ellos.
                * 
                * Los parametros son opcionales y se pueden especificar cualquier numero de parametros.
                * 
                * Los parametros se especifican entre parentesis y se separan por comas.
                * 
                * Los parametros se componen de un tipo de dato y un nombre.
                * 
                * Los parametros se utilizan para pasar valores al metodo.
            */

            /* 
                * Cuerpo del metodo: Es el bloque de codigo que contiene las instrucciones que se ejecutan cuando se llama al metodo ->
                *´para llevar a cabo las actividades para la cual fue creado el metodo y cumplir las actividades requeridas.
                * 
                * El cuerpo del metodo se encierra entre llaves.
                * 
                * El cuerpo del metodo contiene las instrucciones que se ejecutan cuando se llama al metodo.
                * 
                * El cuerpo del metodo puede contener cualquier numero de instrucciones.
            */
        }
    }
}
