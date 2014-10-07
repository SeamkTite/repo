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
            Console.Write("Sivun pituus: ");
            int sivu = int.Parse(Console.ReadLine());
            int nelionAla = sivu * sivu;
            Console.WriteLine("Neliön ala on " + nelionAla);

            Console.Write("Säde: ");
            double sade = double.Parse(Console.ReadLine());
            //double ympyranAla = Math.PI * sade * sade;
            double ympyranAla = Math.PI * Math.Pow(sade, 2);
            Console.WriteLine("Ympyrän ala on " + ympyranAla);

            double alaYht = nelionAla + ympyranAla;
            Console.WriteLine("Pinta-alat yhteensä {0:F1}", alaYht);

        }
    }
}
