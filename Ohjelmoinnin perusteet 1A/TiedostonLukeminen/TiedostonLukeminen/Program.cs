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
            string tiedNimi = @"c:\tmp\ThousandNames.txt";

            if (File.Exists(tiedNimi))
            {
                // avataan tiedosto
                StreamReader tiedosto = new StreamReader(tiedNimi);
                string rivi;
                int i = 0; // laskee rivien lukumäärän

                // luetaan tiedostoa rivi riviltä
                while ((rivi = tiedosto.ReadLine()) != null)
                {
                    Console.WriteLine(i + ": " + rivi);
                    i++;
                }
            }
            else
            {
                Console.WriteLine("Tiedostoa {0} ei ole", tiedNimi);
            }
        }
    }
}
