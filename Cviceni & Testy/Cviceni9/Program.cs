using System;
using System.Linq;

namespace Cviceni9
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Zadejte pocet zamestanancu:");
            int pocetZamestnancu = int.Parse(Console.ReadLine());

            int[] poleMzdy = new int[pocetZamestnancu];
            Console.WriteLine("Zadejte mzdu jednotliveho zamestnance: ");
            for (int i = 0; i < pocetZamestnancu; i++)
            {
                Console.Write("{0}. mzda zamestnance = ", i + 1);
                poleMzdy[i] = int.Parse(Console.ReadLine());
            }
            int prumer = poleMzdy.Sum();
            for (int i = 0; i < poleMzdy.GetLength(0); i++)
            {
                prumer = (poleMzdy[i]) / pocetZamestnancu;
            }
            Console.Write("Prumerna mzda: {0}", prumer);
        }
    }
}