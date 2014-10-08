using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forEsimerkki
{
    class Program
    {
        static void Main(string[] args)
        {
            // 0...4
            for (int i = 0; i < 5; i++)
            {
                Console.Write(i);
            }
            Console.WriteLine("\n--------------------------------");
            // 1...5
            for (int i = 1; i <= 5; i++)
            {
                Console.Write(i);
            }
            Console.WriteLine("\n--------------------------------");
            // Count fives
            for (int i = 0; i <= 100; i+=5)
            {
                Console.Write(i+ " ");
            }
            Console.WriteLine("\n--------------------------------");
            // -PI....PI, 0.1 välein
            for (double x = -Math.PI; x < Math.PI; x+=0.1)
            {
                Console.WriteLine("{0,5:F2}", x);
            }
            Console.WriteLine("\n--------------------------------");
            // merkit a...z
            for (int i = 'a'; i <= 'z'; i++)
            {
                char c = (char)i;
                Console.Write(c + " ");
            }
            Console.WriteLine("\n--------------------------------");
        }
    }
}
