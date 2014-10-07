using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valtionvero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna vuositulot");
            double tulot = double.Parse(Console.ReadLine());

            double vero = 0;
            if (tulot < 12600)
                vero = 0;
            else if (tulot < 20800)
                vero = 8 + (tulot - 12600) * 0.085;
            else if (tulot < 34000)
                vero = 705 + (tulot - 20800) * 0.19;
            else if (tulot < 62000)
                vero = 3213 + (tulot - 34000) * 0.235;
            else
                vero = 9793 + (tulot - 62000) * 0.315;

            Console.WriteLine("Vero on {0:F0} euroa", vero);
        }
    }
}
