using System;

namespace _14_Ejercicio_Practicas_Tipos_Datos_y_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Practicas de declaraciones de los tipos de datos en C# con los datos que existen.
            byte miByte = 25;
            Console.WriteLine(miByte);
            sbyte miSbyte = 15;
            Console.WriteLine(miSbyte);
            int miInt = 12318925;
            Console.WriteLine(miInt);
            uint miUint = 123091;
            Console.WriteLine(miUint);
            short miShort = -32768;
            Console.WriteLine(miShort);
            ushort miUshort = 65535;
            Console.WriteLine(miUshort);
            float miFloat = -31.1289f;
            Console.WriteLine(miFloat);
            double miDouble = -12.1231250;
            Console.WriteLine(miDouble);
            char miChar = 'A';
            Console.WriteLine(miChar);
            bool miBool = true;
            Console.WriteLine(miBool);
            string miTexto = "Yo controlo el texto";
            Console.WriteLine(miTexto);
            string numTexto = "15";

            int miNumeroDesdeTexto = int.Parse(numTexto);
            Console.WriteLine(miNumeroDesdeTexto);
            Console.ReadKey();
        }
    }
}
