using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arvonlisävero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna tuotteen veroton hinta: ");
            double verotonHinta = double.Parse(Console.ReadLine());

            Console.Write("Anna ALV%: ");
            double alvPros = double.Parse(Console.ReadLine());

            // lasketaan vero
            double vero = verotonHinta * alvPros / 100.0;
            // lasketaan verollinen hinta
            double verollinenHinta = verotonHinta + vero;
            Console.WriteLine("Verollinen hinta on {0:F2}", verollinenHinta);
        }
    }
}
