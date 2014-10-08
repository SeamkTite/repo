using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PintaAloja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna neliön sivun pituus: ");
            int sivu = int.Parse(Console.ReadLine());
            int nelionAla = sivu * sivu;
            Console.WriteLine("Neliön ala on {0}", nelionAla);

            Console.Write("Anna ympyrän säde:");
            double sade = double.Parse(Console.ReadLine());
            double ympyranAla = Math.PI * sade * sade;
            Console.WriteLine("Ympyran ala on {0:F2}", ympyranAla);

            double alaYht = nelionAla + ympyranAla;
            Console.WriteLine("Pinta-alat yhteensä on {0:F2}", alaYht);
        }
    }
}
