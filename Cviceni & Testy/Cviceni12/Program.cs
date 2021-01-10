using System;

namespace Cviceni12
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            bool ukonceniVypoctu = false;
            int pocetChyb = 0;
            int pocetDobre = 0;
            int soucet;
            string pokracovat;

            do
            {
                for (int i = 1; i <= 100; i++)
                {
                    Console.WriteLine("Nasobilka {0}", i);

                    for (int j = 1; j <= 10; j++)
                    {
                        Console.Write("{0} x {1} = ", i, j);

                        soucet = Convert.ToInt32(Console.ReadLine());

                        if (soucet != i * j)
                        {
                            pocetChyb++;
                            ukonceniVypoctu = true;
                            break;
                        }
                        else
                        {
                            pocetDobre++;
                            Console.WriteLine("Spravne!");
                        }
                    }
                    if (ukonceniVypoctu == true)
                        break;

                    Console.WriteLine();
                }

                if (pocetChyb == 0)
                {
                    Console.WriteLine("Pocet chyb: {0}", pocetChyb);
                    Console.WriteLine("Pocet Spravne vypocitanych prikladu: {0}", pocetDobre);

                    Console.WriteLine("Gratuluji mel jste vse dobre");
                }
                else
                {
                    Console.WriteLine("Pocet chyb: {0}", pocetChyb);
                    Console.WriteLine("Pocet Spravne vypocitanych prikladu: {0}", pocetDobre);
                }

                Console.Write("Chcete pokracovat? ");
                pokracovat = Console.ReadLine();
            } while (pokracovat == "ano");
        }
    }
}