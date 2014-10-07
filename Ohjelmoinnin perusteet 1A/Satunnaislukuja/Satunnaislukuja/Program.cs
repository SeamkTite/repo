using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satunnaislukuja
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generaattori = new Random();

            int luku = generaattori.Next();
            Console.WriteLine(luku);

            int i = 0;
            while (i < 20)
            {
                // nopanheitto
                luku = generaattori.Next(1, 7);
                Console.WriteLine(luku);
                i++;
            }

        }
    }
}
