using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TiedostonLukeminen
{
    class Program
    {
        static void Main(string[] args)
        {
            // "c# how to read text file line by line"
            // http://msdn.microsoft.com/en-us/library/aa287535(v=vs.71).aspx

            //string tiedNimi = "c:\\tmp\\ThousandNames.txt";
            string tiedNimi = @"c:\tmp\numbers.txt";

            if (File.Exists(tiedNimi))
            {
                // avataan tiedosto
                StreamReader tiedosto = new StreamReader(tiedNimi);
                string rivi;
                int i = 0; // laskee rivien lukumäärän
                double summa = 0;

                // luetaan tiedostoa rivi riviltä
                while ((rivi = tiedosto.ReadLine()) != null)
                {
                    // rivillä oleva tieto muutettiin numeroksi
                    double x = double.Parse(rivi);
                    //summa = summa + x;
                    summa += x;

                    //Console.WriteLine(i + ": " + rivi);
                    i++;
                }
                Console.WriteLine("Summa on {0:F1}", summa);
                double keskiarvo = summa / i;
                Console.WriteLine("Keskiarvo on {0:F1}", keskiarvo);
            }
            else
            {
                Console.WriteLine("Tiedostoa {0} ei ole", tiedNimi);
            }
        }
    }
}
