using System;

namespace Cviceni5
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Jste klientem banky? (ano/ne)");
            string klient = Console.ReadLine();

            Console.WriteLine("1.Hypoteky - 500");
            Console.WriteLine("2.Sporici Ucty - 600");
            Console.WriteLine("3.Podilove fondy - 700");
            Console.Write("Vyberte si moznost (1,2,3): ");
            string moznost = Console.ReadLine();

            if (moznost == "1" && klient == "ano")
            {
                Console.WriteLine("Cislo je: 100 200 500");
            }
            else if (moznost == "1" && klient == "ne")
            {
                Console.WriteLine("Cislo je: 100 300 500");
            }
            else if (moznost == "2" && klient == "ano")
            {
                Console.WriteLine("Cislo je: 100 200 600");
            }
            else if (moznost == "2" && klient == "ne")
            {
                Console.WriteLine("Cislo je: 100 300 600");
            }
            else if (moznost == "3" && klient == "ano")
            {
                Console.WriteLine("Cislo je: 100 200 700");
            }
            else if (moznost == "3" && klient == "ne")
            {
                Console.WriteLine("Cislo je: 100 300 700");
            }
            else
            {
                Console.WriteLine("Spatna zadana volba");
            }
        }
    }
}