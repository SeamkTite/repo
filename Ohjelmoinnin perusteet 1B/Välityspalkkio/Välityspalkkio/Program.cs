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
            // 33.	Tee ohjelma, joka laskee asunnonvälittäjän perimän palkkion.
            // Palkkio on suuruudeltaan 5% asunnon hinnasta,
            // kuitenkin vähintään 2000€ ja enintään 15000€.
            Console.Write("Anna asunnon hinta: ");
            double hinta = double.Parse(Console.ReadLine());

            // lasketaan 5% palkkio
            double palkkio = hinta * 0.05;
            if (palkkio < 2000)
                palkkio = 2000;
            else if (palkkio > 15000)
                palkkio = 15000;

            Console.WriteLine("Palkkio on {0:F2} euroa", palkkio);
        }
    }
}
