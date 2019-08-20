using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("Imprime los números del x al 60 de 3x3");
            Console.WriteLine("De donde arrancamos el ciclo: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("De donde terminamos el ciclo (Menor):");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("De cuanto en cuanto: ");
            z = Convert.ToInt32(Console.ReadLine());
            for (int i = x; i > y; i -= z)
            {
                Console.WriteLine("i = " + i);
            }
        }
    }
}
