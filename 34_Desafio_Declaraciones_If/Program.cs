namespace _34_Desafio_Declaraciones_If
{
    internal class Program
    {
        //Variables globales
        static string nombreDeUsuario;
        static string clave;
        

        static void Main(string[] args)
        {
            /*
                * CREA UN SISTEMA DE INICIO DE SESIÓN DE USUARIO, DONDE EL USUARIO 
                * PUEDE PRIMERO REGISTRARSE Y LUEGO INICIAR SESIÓN.
                * 
                * EL PROGRAMA DEBE VERIFICAR SI EL USUARIO HA INGRESADO EL NOMBRE 
                * DE USUARIO Y LA CONTRASEÑA CORRECTOS AL INICIAR SESIÓN, 
                * (ES DECIR, LOS MISMOS QUE UTILIZÓ AL REGISTRARSE).
            */

            Registro();
            Ingreso();
            Console.ReadKey();  
        }

        //Metodos
        public static void Registro()
        {
            Console.WriteLine("Por favor ingrese su nombre de usuario");
            nombreDeUsuario = Console.ReadLine();
            Console.WriteLine("Por favor ingrese su claveo");
            clave = Console.ReadLine();
            Console.WriteLine("Registro exitoso");
            Console.WriteLine("--------------------");
        }

        public static void Ingreso()
        {
            Console.WriteLine("Por favor ingrese su nombre de usuario");
            if (nombreDeUsuario == Console.ReadLine())
            {
                Console.WriteLine("Por favor ingrese su clave");
                if (clave == Console.ReadLine())
                {
                    Console.WriteLine("Ingreso exitoso!");
                }
                else
                {
                    Console.WriteLine("Clave incorrecta, por favor reinicie el programa");
                }

            }
            else
            {
                Console.WriteLine("Nombre de usuario incorrecto, por favor reinicie el programa");
            }
        }
    }
}
