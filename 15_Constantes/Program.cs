namespace _15_Constantes
{
    internal class Program
    {
        //Constantes declaradas de forma global
        //Los valores de las constantes no pueden cambiar su valor en tiempo de ejecución.
        //Ya que estos son valores ya definidos en si que su valor no de be y no se puede cambiar
        //Por ejemplo  el numero PI, Nuestra fecha de nacimiento y demas.

        const double PI = 3.14159265359;
        const int semanas = 52, meses = 12;
        const string nacimiento = "07/02/2005";

        static void Main(string[] args)
        {
            Console.WriteLine("Mi nacimiento fue el: {0}", nacimiento);
            Console.Read();
        }
  
    }
}
