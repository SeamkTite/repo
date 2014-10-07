using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NimetTiedostoon
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter tiedosto = new StreamWriter("c:\\tmp\\nimet.txt");
            while (true)
            {
                Console.Write("nimi: ");
                string nimi = Console.ReadLine();

                if (nimi.Length == 0)
                    break; // lopettaa toiston
                tiedosto.WriteLine(nimi);
            }
            tiedosto.Close();

        }
    }
}
