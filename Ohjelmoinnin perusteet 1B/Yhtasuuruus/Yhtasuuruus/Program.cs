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
            Console.Write("Luku 1: ");
            int luku1 = int.Parse(Console.ReadLine());

            Console.Write("Luku 2: ");
            int luku2 = int.Parse(Console.ReadLine());

            if (luku1 == luku2)
            {
                Console.WriteLine("luvut oli yhtäsuuria");
            }
            else
            {
                //Console.WriteLine("luvut oli erisuuria");
                if (luku1 > luku2)
                {
                    Console.WriteLine("luku1 oli suurempi");
                }
                else
                {
                    Console.WriteLine("luku2 oli suurempi");
                }
            }

        }
    }
}
