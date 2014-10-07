using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Säästötili
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ohjelma simuloi säästötilin karttumista
            // Kysy käyttäjältä
            // - talletettava summa
            // - korkoprosentti
            // - säästöaika vuosina
            // ohjelma laskee kuinka paljon rahaa on tilillä säästöajan loputtua
            Console.WriteLine("Anna talletettava summa: ");
            double talletus = double.Parse(Console.ReadLine());

            Console.WriteLine("Anna korkoprosentti: ");
            double korkopros = double.Parse(Console.ReadLine());

            Console.WriteLine("Anna talletusaika: ");
            int aika = int.Parse(Console.ReadLine());

            double saldo = talletus;

            // avataan tiedosto
            TextWriter tiedosto = new StreamWriter("c:\\tmp\\rahat.txt");
            for (int i = 0; i < aika; i++)
            {
                double korko = saldo * korkopros / 100.0;
                saldo += korko; // saldo = saldo + korko
                Console.WriteLine("{0,2}\t{1,6:F2}\t{2,8:F2}", i + 1, korko, saldo);
                tiedosto.WriteLine("{0,2}\t{1,6:F2}\t{2,8:F2}", i + 1, korko, saldo);
            }
            tiedosto.Close();

            // kokeillaan "korkoa korolle" kaavaa
            double saldo2 = talletus * Math.Pow(1 + korkopros/100, aika);
            Console.WriteLine("{0:F2}", saldo2);
        }
    }
}
