using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yhtasuuruus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna luku 1: ");
            int luku1 = int.Parse(Console.ReadLine());

            Console.Write("Anna luku 2: ");
            int luku2 = int.Parse(Console.ReadLine());

            if (luku1 == luku2)
            {
                Console.WriteLine("luvut ovat yhtäsuuria");
            }
            else
            {
                Console.WriteLine("luvut ovat erisuuria");
                if (luku1 > luku2)
                {
                    Console.WriteLine("luku 1 oli suurempi");
                }
                else
                {
                    Console.WriteLine("luku 2 oli suurempi");
                }
            }
        }
    }
}
