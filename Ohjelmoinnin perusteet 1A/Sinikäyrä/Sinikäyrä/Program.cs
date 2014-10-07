using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Sinikäyrä
{
    class Program
    {
        static void Main(string[] args)
        {
            // avataan tiedosto
            TextWriter tiedosto = new StreamWriter("C:\\tmp\\sini.txt");

            for (double x = -5; x < 5; x+=0.1)
            {
                double y = Math.Sin(x);
                Console.WriteLine("{0:F2} {1:F2}", x, y);
                // kirjoitetaan tiedostoon
                tiedosto.WriteLine("{0:F2} {1:F2}", x, y);
            }
            // suljetaan tiedosto
            tiedosto.Close();
        }
    }
}
