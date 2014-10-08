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
            StreamReader tiedosto = new StreamReader("C:\\tmp\\ThousandNames.txt");

            string rivi;
            int i = 0;
            // luetaan tiedosto rivi riviltä
            while ((rivi = tiedosto.ReadLine()) != null)
            {
                Console.WriteLine(rivi);
                i++;
            }
            tiedosto.Close();

        }
    }
}
