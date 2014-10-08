using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TiedostonLuku
{
    class Program
    {
        static void Main(string[] args)
        {
            // ohjelma lukee tiedoston rivi riviltä

            // avataan tiedosto
            StreamReader tiedosto = new StreamReader("C:\\tmp\\numbers.txt");

            string rivi;
            int i = 0;
            double summa = 0;

            // luetaan tiedosto rivi riviltä
            while (true)
            {
                rivi = tiedosto.ReadLine();
                if (rivi == null)
                    break;
                // muuta string tyyppinen muuttuja rivi numeroksi x
                double x = double.Parse(rivi);
                summa += x;
                i++;
            }
            tiedosto.Close();
            // tulosta summa ja keskiarvo
            Console.WriteLine("Summa on " + summa);
            double keskiarvo = summa / i;
            Console.WriteLine("Keskiarvo on " + keskiarvo);

        }
    }
}
