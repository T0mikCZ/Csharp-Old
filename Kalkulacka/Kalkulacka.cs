using System;

namespace Kalkulacka
{
    internal class Kalkulacka
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Super kalkulacka zadarmo, ktera umi pouzivat jenom 2 cisla a neumi desetinna. Lul");

            //TODO pridat odpoved kdyz nezada cislo
            //TODO pridat cyklus abys nemusel porad zapinat program DONE
            //TODO byt mozne vlozit vic jak 2 cisla
            //TODO komplexnejsi operace
            //TODO napise error kdyz nezadas cislo
            string vypocet;

            do
            {
                Console.Write("Zadejte pocet cisel: ");
                int pocetCisel = int.Parse(Console.ReadLine());

                int[] poleCisel = new int[pocetCisel];

                int soucet = 0;
                int soucin = 1;
                int podil = 0;

                for (int i = 0; i < pocetCisel; i++)
                {
                    Console.Write("{0}. cislo = ", i + 1);
                    int cislo = int.Parse(Console.ReadLine());
                    poleCisel[i] = cislo;
                    soucet = soucet + cislo;
                    soucin = soucin * cislo;
                }

                Console.WriteLine("Soucet = {0}", soucet);
                Console.WriteLine("Podil = {0}", podil);
                Console.WriteLine("Soucin = {0}", soucin);

                Console.Write("Chcete provest dalsi vypocet? ");
                vypocet = Console.ReadLine();
            } while (vypocet == "ano");
        }
    }
}