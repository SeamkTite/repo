using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satunnailuvut
{
    class Program
    {
        static void Main(string[] args)
        {
            // luodaan satunnaislukugeneraattori
            Random generaattori = new Random();

            int a = generaattori.Next();
            Console.WriteLine(a);

            int i = 0;
            while (i < 7)
            {
                int luku = generaattori.Next(39) + 1;
                Console.WriteLine(luku);
                i++;
            }
            Console.WriteLine("------------------------------");
            i = 0;
            while (i < 20)
            {
                int luku = generaattori.Next(1, 7); // 1...6
                Console.WriteLine(luku);
                i++;
            }

        }
    }
}
