using System;
using MatesLib; // Això importa la teva llibreria!

namespace MatesConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ENTRA UN NÚMERO DE 1 A 9: ");
            int num = Convert.ToInt32(Console.ReadLine());

            while (num < 1 || num > 9)
            {
                Console.WriteLine("EL NÚMERO QUE HAS ENTRAT NO ÉS CORRECTE.");
                Console.Write("ENTRA UN NÚMERO DE 1 A 9: ");
                num = Convert.ToInt32(Console.ReadLine());
            }

            Mates.TaulaMultiplicar(num);
        }
    }
}