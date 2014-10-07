using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerkkijonojenVertailu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna nimi: ");
            string nimi1 = Console.ReadLine();

            Console.Write("Anna nimi: ");
            string nimi2 = Console.ReadLine();

            int result = nimi1.CompareTo(nimi2);

            if (result == 0)
                Console.WriteLine("Nimet ovat samoja");
            else if (result < 0)
                Console.WriteLine("{0} on aakkosjärjestyksessä ensin", nimi1);
            else //(result > 0)
                Console.WriteLine("{0} on aakkosjärjestyksessä ensin", nimi2);

        }
    }
}
