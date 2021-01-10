using System;

namespace Cviceni19
{
    internal class Program
    {
        //TODO vyresit error DONE
        private static void Main(string[] args)
        {
            DateTime narozeniny1 = new DateTime(2004, 6, 6);
            DateTime narozeniny2 = new DateTime(2014, 6, 6);

            PorovnaniVekuANarozeni("Tom", narozeniny1, "David", narozeniny2);

            Console.ReadKey();
        }

        private static void PorovnaniVekuANarozeni(string jmeno1, DateTime datumNarozeni1, string jmeno2, DateTime datumNarozeni2)
        {
            int pocetLet1 = DateTime.Now.Year - datumNarozeni1.Year;
            int pocetLet2 = DateTime.Now.Year - datumNarozeni2.Year;

            Console.WriteLine("{0} je stary {1} let", jmeno1, pocetLet1);
            Console.WriteLine("{0} je stary {1} let", jmeno2, pocetLet2);

            if (pocetLet1 > pocetLet2)
            {
                Console.WriteLine("{0} je starsi nez {1} o {2} dni", jmeno1, jmeno2, datumNarozeni1.DayOfYear - datumNarozeni2.DayOfYear);
            }
            else if (pocetLet1 == pocetLet2)
            {
                Console.WriteLine("{0} a {1} jsou stejne stary", jmeno1, jmeno2);
            }
            else
            {
                Console.WriteLine("{0} je starsi nez {1} o {2} dni", jmeno2, jmeno1, datumNarozeni2.DayOfYear - datumNarozeni1.DayOfYear);
            }
        }
    }
}