using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuuttujienTyypit
{
    class Program
    {
        static void Main(string[] args)
        {
            string etunimi;
            string sukunimi;
            etunimi = "Petteri";
            sukunimi = "Mäkelä";            

            char merkki = ',';

            string kokonimi = etunimi + " " + sukunimi;
            Console.WriteLine(kokonimi);

            kokonimi = sukunimi + merkki + " " + etunimi;
            Console.WriteLine(kokonimi);

            byte tavu = byte.MaxValue;
            Console.WriteLine(tavu);

        }
    }
}
