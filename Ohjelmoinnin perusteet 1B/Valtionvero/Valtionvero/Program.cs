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
            // 12600 	8	    8,5 %
            // 20800	705	    19,0 %
            // 34000	3213	23,5 %
            // 62000	9793	31,5 %
            Console.Write("Anna vuositulo: ");
            double tulot = double.Parse(Console.ReadLine());

            double verot = 0;
            if (tulot >= 12600 && tulot < 20800)
            {
                verot = 8 + (tulot - 12600) * 0.085;
            }
            else if (tulot >= 20800 && tulot < 34000)
            {
                verot = 705 + (tulot - 20800) * 0.19;
            }
            else if (tulot >= 34000 && tulot < 62000)
            {
                verot = 3213 + (tulot - 34000) * 0.235;
            }
            else if (tulot >= 62000)
            {
                verot = 9793 + (tulot - 62000) * 0.315;
            }
            Console.WriteLine("Verot on {0:F2} euroa", verot);
        }
    }
}
