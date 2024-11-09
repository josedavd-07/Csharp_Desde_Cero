namespace _33_Ejercicios__Practicos_If_Anidados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                * EJERCICIO NUMERO 1
                * 
                * UTILIZANDO IF ANIDADOS, SE DEBE CREAR UNA ESTRUCTURA QUE CUMPLA 
                * CON LA SIGUIENTE LÓGICA:
                * 
                * - Si el valor de resultadoExamen es menor a 4, se debe imprimir 
                *   en consola el mensaje "Aplazado".
                * 
                * - Si el valor de resultadoExamen es mayor o igual a 4 pero menor a 7, 
                *   se debe imprimir en consola el mensaje "Aprobado".
                * 
                * - Si el valor de resultadoExamen es mayor o igual a 7, se debe imprimir 
                *   en consola el mensaje "Promocionado".
            */

            int resultadoExamen = 8;

            if (resultadoExamen < 4)
            {
                Console.WriteLine("Aplazado");
            }
            else
            {
                if (resultadoExamen < 7)
                {
                    Console.WriteLine("Aprobado");
                }
                else
                {
                    Console.WriteLine("Promocionado");
                }
            }
             
            Console.WriteLine("\n\n");

            /*
                * EJERCICIO NUMERO 2
                * 
                * DADAS LAS DOS VARIABLES BOOLEANAS, DECLARAR UN IF COMPUESTO CON 
                * DICHAS DOS VARIABLES. 
                * 
                * ES DECIR, UTILIZANDO LOS OPERADORES CONDICIONALES, SE DEBE 
                * VERIFICAR QUE AMBAS CONDICIONES SEAN VERDADERAS (&&).
                * 
                * - Si la condición total es verdadera, se debe imprimir en consola 
                *   el mensaje "La condición es verdadera".
                * 
                * - En caso contrario, se debe imprimir en consola el mensaje 
                *   "La condición es falsa".
            */

            bool esMayor = 5 > 7;
            bool condicion = true;

            if (esMayor && condicion)
            {
                Console.WriteLine("La condicion es verdadera");
            }
            else
            {
                Console.WriteLine("La condicion es falsa");
            }
            Console.ReadKey();
        }
    }
}
