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
            int a = 5;
            double x = 4.3;
            int b = 7;

            // desimaalit katkeaa kokonaislukujaossa
            double tulos = a / b;
            Console.WriteLine(tulos);

            int jakojaannos = a % b;
            Console.WriteLine("jakojäännös " + jakojaannos);

            // jos desimaalit halutaan säilyttää, pitää tehdä tyyppipakotus
            tulos = (double)a / b;
            Console.WriteLine(tulos);

            tulos = x / b;
            Console.WriteLine(tulos);

            string nimi = "Petteri";
            string s = "Terve";

            string kaikki = s + " " + nimi + " " + (a + b);
            Console.WriteLine(kaikki);

            char merkki = '!';
            kaikki = kaikki + merkki;
            Console.WriteLine(kaikki);

            // muuttujan nimen pitää alkaa kirjaimella
            //int 9z;
            double _x;
            string etunimi;

            //int case;
        }
    }
}
