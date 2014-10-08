using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // saadaan tiedostojen käsittely käyttöön

namespace Sinikäyrä
{
    class Program
    {
        static void Main(string[] args)
        {
            // avataan tiedosto kirjoittamista varten
            // TextWriter tiedosto = new StreamWriter("C:\\tmp\\sini.txt");
            StreamWriter tiedosto = new StreamWriter(@"C:\tmp\sini.txt");
            for (double x = -10; x < 10; x += 0.1)
            {
                double y = Math.Sin(x);
                Console.WriteLine("{0,6:F2}\t{1,6:F2}", x, y);
                // kirjoitetaan tiedostoon
                tiedosto.WriteLine("{0,6:F2}\t{1,6:F2}", x, y);
            }
            // suljetaan tiedosto
            tiedosto.Close();
        }
    }
}
