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
            Console.Write("Anna lähtönopeus: ");
            double lahtoNopeus = double.Parse(Console.ReadLine());

            double korkeus = lahtoNopeus * lahtoNopeus / (2 * 9.81);

            Console.WriteLine("Pesäpallo nousee {0:F1} korkeuteen", korkeus);
        }
    }
}
