// See https://aka.ms/new-console-template for more information

/*
    * Hola Mundo con instrucciones de nivel superior en C#
    * =====================================================
    * Este enfoque está disponible desde .NET 6.0 en adelante y 
    * permite escribir código directamente sin declarar una clase o método Main.
    *
    * Características importantes:
    *> Se usa para dar saltos de línea en consola:  \n
    *> Se utiliza para concatenar cadenas de texto con el operador: +
    *> Cada instrucción debe finalizar con punto y coma para cerrar la instrucción: ;
*/

// Imprimir mensaje clásico de bienvenida
Console.WriteLine("Hello, World!");

// Imprimir un mensaje informativo con salto de línea (\n) y concatenación
Console.WriteLine("\nEste mensaje es para recordarte que este programa fue escrito " +
    "usando las instrucciones de nivel superior en C#");

// Imprimir otro mensaje motivacional sin salto de línea final
Console.Write("\nHola, si ves esto, es el comienzo de algo maravilloso. " +
    "Créeme, pensarás que esto es difícil, pero es lo más genial que puedes estar haciendo: invertir en ti.");

// Espera antes de cerrar la consola
Console.WriteLine("\n\nPresiona una tecla para continuar...");
Console.ReadKey();
