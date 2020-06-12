using System;

namespace Cviceni16
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Narozeniny(new DateTime(2004, 6, 6));

            Console.ReadKey();
        }

        private static void Narozeniny(DateTime datumNarozeni)
        {
            int pocetLet = DateTime.Now.Year - datumNarozeni.Year;
            Console.WriteLine("Pocet let: {0}", pocetLet);
            if (datumNarozeni.Date == DateTime.Now.Date)
            {
                Console.WriteLine("Blahopreji k narozeninam!");
            }
            else
            {
                Console.WriteLine("Pocet dni do narozenin: ");
                if (datumNarozeni.Date.DayOfYear > DateTime.Now.DayOfYear)
                {
                    Console.WriteLine(datumNarozeni.DayOfYear - DateTime.Now.DayOfYear);
                }
                else
                {
                    Console.WriteLine(365 - (DateTime.Now.DayOfYear - datumNarozeni.DayOfYear));
                }
            }
        }
    }
}