using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arvosanat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna pisteet: ");
            int pisteet = int.Parse(Console.ReadLine());

            int arvosana;

            if (pisteet < 0)
            {
                arvosana = -1;
            }
            else if (pisteet <= 10)
            {
                arvosana = 0;
            }
            else if (pisteet <= 20)
            {
                arvosana = 1;
            }
            else if (pisteet <= 30)
            {
                arvosana = 2;
            }
            else if (pisteet <= 40)
            {
                arvosana = 3;
            }
            else
            {
                arvosana = -1;
            }

            if (arvosana == -1)
                Console.WriteLine("Arvosanan pitää olla välillä 0-40");
            else
                Console.WriteLine("Arvosana on " + arvosana);

        }
    }
}
