using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // tulostetaan numero 0...4
            int i = 0;
            while (i < 5)
            {
                Console.Write(i + " ");
                i = i + 1;
            }
            Console.WriteLine();

            // tulostetaan numerot 1...5
            i = 1;
            while (i <= 5)
            {
                Console.Write(i + " ");
                // i = i + 1;
                // i += 1;
                i++;
            }
            Console.WriteLine();

            int x = 10;
            int y = x++;
            Console.WriteLine("y = " + y);

            x = 10;
            y = ++x;
            Console.WriteLine("y = " + y);

            // tulostetaan merkit a...z
            char c = 'a';
            while (c <= 'z')
            {
                Console.Write(c);
                c++;
            }
            Console.WriteLine();
        }
    }
}
