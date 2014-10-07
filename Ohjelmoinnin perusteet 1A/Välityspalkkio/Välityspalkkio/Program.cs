using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Välityspalkkio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Asunnon hinta: ");
            double hinta = double.Parse(Console.ReadLine());
            // palkkio lasketaan
            double palkkio = hinta * 0.05;

            if (palkkio < 2000)
            {
                palkkio = 2000;
            }
            else if (palkkio > 15000)
            {
                palkkio = 15000;
            }
            Console.WriteLine("Palkkio on {0:F2} euroa", palkkio);
        }
    }
}
