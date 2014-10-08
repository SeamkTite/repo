using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nimet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna etunimi: ");
            string etunimi = Console.ReadLine();

            Console.Write("Anna sukunimi: ");
            string sukunimi = Console.ReadLine();

            string kokonimi = etunimi + " " + sukunimi;

            Console.WriteLine("Terve " + kokonimi);
        }
    }
}
