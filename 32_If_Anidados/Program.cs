// EL  using System; puedes llamarlo o no , el compilador lo agrega por defecto. internamente esta envuelto en un namespace
// el using Systesm es mas que todo por copmpatibilidad con versiones anteriores, en este caso usamso la version 8.0
namespace _32_If_Anidados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool esAdmin = false;
            bool estaRegistrado = true;
            string nombreDeUsuario = "";

            // FORMA MAS EFICIENTE DE REALIZAR EL MISMO CODIGO usando operadores logicos Y = & e O = ||
            Console.Write("Por favor, ingrese su nombre de usuario: ");
            nombreDeUsuario = Console.ReadLine();
            if (estaRegistrado && nombreDeUsuario != "" && nombreDeUsuario.Equals("Admin"))
            {
                Console.WriteLine("\nHola usuario registrado");
                Console.WriteLine("\nHola " + nombreDeUsuario);
                Console.WriteLine("\nHola Admin");
            }

            if (esAdmin || estaRegistrado)
            {
                Console.WriteLine("\nEstás loguado");
            }
            
            
            Console.WriteLine("\n\n");


            // EL IF ANIDADO ES  UN IF DENTRO DE OTRO IF SIGUIENDO LAS SECUENCIAS DE IF

            if(estaRegistrado)
            {
                if (nombreDeUsuario != "")
                {
                    if (nombreDeUsuario.Equals("Admin"))
                    {
                        Console.WriteLine("\nHola usuario registrado");
                        Console.WriteLine("\nHola " + nombreDeUsuario);
                        Console.WriteLine("\nHola Admin");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
