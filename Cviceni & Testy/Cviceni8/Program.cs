using System;
using System.Linq;

namespace Cviceni8
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Najdi min a max cislo using for loopu
            Console.Write("Zadejte pocet cisel: ");
            int pocetCisel = int.Parse(Console.ReadLine());

            int[] poleCisel = new int[pocetCisel];

            for (int i = 0; i < pocetCisel; i++)
            {
                Console.Write("{0}. cislo: ", i + 1);
                poleCisel[i] = int.Parse(Console.ReadLine());
            }

            int min = poleCisel.Min(); //alternativni
            int max = poleCisel.Max(); //alternativni
            /*
            for (int i = 0; i < poleCisel.GetLength(0); i++)
            {
                if (poleCisel[i] < min)
                {
                    min = poleCisel[i];
                }
            }
            */

            /*
            for (int i = 0; i < poleCisel.GetLength(0); i++)
            {
                if (poleCisel[i] >  max)
                {
                    max = poleCisel[i];
                }
            }
            */
            Console.WriteLine("Nejmensi cislo: {0}", min);
            Console.WriteLine("Nejvetsi cislo: {0}", max);
        }
    }
}