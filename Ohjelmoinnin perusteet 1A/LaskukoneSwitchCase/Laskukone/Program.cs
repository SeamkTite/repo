using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laskukone
{
    class Program
    {
        static void Main(string[] args)
        {
            // 28.	Ohjelmoi yksikertainen laskukone,
            // joka osaa laskea kahdesta luvusta joko
            // summan, erotuksen, tulon tai osamäärän.
            // Laskukoneelle annetaan kaksi lukua ja lukujen
            // jälkeen operaattori (+, -, *, /).
            // Esimerkiksi  4  * 5 => vastaus on 20

            // kysy kaksi kokonaislukua
            // kysy operaatiota vastaava merkki (char)
            Console.WriteLine("Anna luku 1");
            int luku1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Anna luku 2");
            int luku2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Anna laskutoimitus (+, -, *, /)");
            char operaatio = char.Parse(Console.ReadLine());

            double tulos = 0;

            // tehdään aiempi laskukone nyt swith-casella
            switch (operaatio)
            {
                case '+':
                    tulos = luku1 + luku2;
                    break;
                case '-':
                    tulos = luku1 - luku2;
                    break;
                case '*':
                    tulos = luku1 * luku2;
                    break;
                case '/':
                    tulos = luku1 / (double)luku2;
                    break;
                case '^':
                case 'p':
                    tulos = Math.Pow(luku1, luku2);
                    break;
                default:
                    tulos = 0;
                    break;
            }

            Console.WriteLine("{0} {1} {2} = {3}", luku1, operaatio, luku2, tulos);
        }
    }
}
