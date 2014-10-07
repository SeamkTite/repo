using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pesäpallo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna lähtönopeus (m/s): ");
            double nopeus = double.Parse(Console.ReadLine());
            const double kiihtyvyys = 9.81;

            double korkeus = nopeus * nopeus / (2 * kiihtyvyys);
            Console.WriteLine("Pesäpallo nousee {0:F1} metrin korkeudelle", korkeus);
        }
    }
}
