using System;

namespace _08_Convenciones_Para_Nombres_Y_Estandares_De_Programacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONVENCIONES DE ESCRITURA EN PROGRAMACIÓN

            // Tipos de notación:
            // - camelCase: nombreDeVariable
            // - PascalCase: NombreDeVariable
            // - snake_case: nombre_de_variable

            /* 
             * En C# se utilizan principalmente:
             * - PascalCase → para clases, métodos públicos y propiedades
             * - camelCase  → para variables locales, parámetros y campos privados (con _ en algunos casos)
             */

            // ──────────────────────────────────────────────
            // Convención para clases → PascalCase

            /*
             public class Persona
             {
                 // Código de la clase
             }
            */

            // ──────────────────────────────────────────────
            // Convención para variables → camelCase

            /*
             int edadPersona = 20;
            */

            // ──────────────────────────────────────────────
            // Convención para métodos → PascalCase (para públicos) / camelCase (para privados)

            /*
             public void MostrarMensaje()
             {
                 // Código del método
             }
            */

            // ──────────────────────────────────────────────
            // No comenzar nombres con números

            /*
             int 1numero = 10;    // ❌ Incorrecto
             int numero1 = 10;    // ✅ Correcto
            */

            // ──────────────────────────────────────────────
            // No usar guiones en los nombres

            /*
             int -numero = 10;    // ❌ Incorrecto
            */

            // En campos privados, a veces se usa guion bajo (_):

            /*
             private int _numero = 10;    // ✅ Correcto en campos privados
            */

            // ──────────────────────────────────────────────
            // Evitar notación húngara (prefijos con tipo)

            /*
             int ctrUsers;               // ❌ Incorrecto
             int controlUsuarios;        // ✅ Correcto
            */

            // ──────────────────────────────────────────────
            // No usar palabras reservadas como nombres de variables

            /*
             int int = 10;               // ❌ Incorrecto
             int numero = 10;            // ✅ Correcto
            */

            // ──────────────────────────────────────────────
            // Final

            Console.WriteLine("""
                Esto es todo. Espero que esta clase sobre convenciones y estándares de nombres en C# te haya sido útil.
               
                """);

            Console.WriteLine("Nos vemos en la siguiente clase. ¡Sigue aprendiendo y programando!");
            Console.ReadKey();
        }
    }
}
