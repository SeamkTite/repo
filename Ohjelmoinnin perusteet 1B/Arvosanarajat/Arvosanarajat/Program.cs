using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arvosanarajat
{
    class Program
    {
        static void Main(string[] args)
        {
            // 0 – 10:	0
            // 11 – 20:	1
            // 21 – 30:	2
            // 31 – 40:	3

            Console.Write("Anna pisteet: ");
            int pisteet = int.Parse(Console.ReadLine());

            int arvosana = 0;

            if (pisteet < 0 || pisteet > 40)
                arvosana = -1;
            else if (pisteet <= 10)
                arvosana = 0;
            else if (pisteet <= 20)
                arvosana = 1;
            else if (pisteet <= 30)
                arvosana = 2;
            else if (pisteet <= 40)
                arvosana = 3;

            if (arvosana == -1)
            {
                Console.WriteLine("Pisteiden pitää olla välillä 0...40");
            }
            else
            {
                Console.WriteLine("Arvosanasi on " + arvosana);
            }

        }
    }
}
