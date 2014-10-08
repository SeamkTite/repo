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
            // - Open the file first
            TextWriter tiedosto = new StreamWriter("C:\\tmp\\nimet.txt");
            // - Make a while loop
            while (true)
            {
                // - Inside the while loop ask the user to give the name
                Console.Write("Anna nimi: ");
                string nimi = Console.ReadLine();

                // - In case of empty string stop the loop by a break statement
                if (nimi.Length == 0)
                    break;
                // - Otherwise, write the name to the file
                tiedosto.WriteLine(nimi);
            }                       
            // - After the while loop close the file
            tiedosto.Close();

        }
    }
}
