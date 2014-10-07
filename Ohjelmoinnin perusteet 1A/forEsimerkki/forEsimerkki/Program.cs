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
            // tulostetaan numerot 0...4
            for (int i = 0; i < 5; i++)
            {
                Console.Write(i);
            }
            Console.WriteLine();

            // tulostetaan numerot 1...5
            for (int i = 1; i <= 5; i++)
            {
                Console.Write(i);
            }
            Console.WriteLine();

            // Count fives
            for (int i = 0; i < 100; i+=5)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }
    }
}
