using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlvProsentti
{
    class Program
    {
        static void Main(string[] args)
        {
            // ohjelma laskee verollisen hinnan.
            // Veroton hinta ja ALV%
            // kysytään käyttäjältä
            Console.Write("Veroton hinta: ");
            double verotonHinta = double.Parse(Console.ReadLine());

            Console.Write("ALV%: ");
            double alvPros = double.Parse(Console.ReadLine());

            // lasketaan ensin vero
            double vero = verotonHinta * alvPros / 100.0;

            double verollinen = verotonHinta + vero;
            Console.WriteLine(verollinen);

            Console.Read();
        }
    }
}
