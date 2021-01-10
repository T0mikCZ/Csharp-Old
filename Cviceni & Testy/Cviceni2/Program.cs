using System;

namespace Cviceni2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Zadejte prvni cislo: ");
            float cislo1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte druhe cislo: ");
            float cislo2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Soucet cisel {0} + {1} je {2}", cislo1, cislo2, cislo1 + cislo2);
            Console.WriteLine("Rozdil cisel {0} - {1} je {2}", cislo1, cislo2, cislo1 - cislo2);
            Console.WriteLine("Soucin cisel {0} * {1} je {2}", cislo1, cislo2, cislo1 * cislo2);
            Console.WriteLine("Podil cisel {0} / {1} je {2} zbytek ({3})", cislo1, cislo2, cislo1 / cislo2, cislo1 % cislo2);
        }
    }
}