using System;

namespace Cviceni4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //TODO Moznost vybrat si s kategorii jidlo
            Console.WriteLine("Menu Restaurace: ");
            Console.WriteLine("Na vyber mame s kategorii: ");
            Console.WriteLine("1.Polevky");
            Console.WriteLine("2.Predkrmy");
            Console.WriteLine("3.Chody");
            Console.WriteLine("4.Dezerty");
            Console.Write("Vybrana kategorie (1,2,3,4): ");

            string kategorie = Console.ReadLine();

            switch (kategorie)
            {
                case "1":
                    Console.WriteLine("------Polevky------");
                    Console.WriteLine("1. Bramborova polevka");
                    Console.WriteLine("2. Cesnekova polevka");
                    Console.WriteLine("2. Borsc");
                    break;

                case "2":
                    Console.WriteLine("------Predkrmy------");
                    Console.WriteLine("1. Rolada");
                    Console.WriteLine("2. Topinka");
                    Console.WriteLine("2. Bramburky");
                    break;

                case "3":
                    Console.WriteLine("------Chody------");
                    Console.WriteLine("1. Gulas");
                    Console.WriteLine("2. Svickova");
                    Console.WriteLine("2. Rizek s kasi");
                    break;

                case "4":
                    Console.WriteLine("------Dezerty------");
                    Console.WriteLine("1. Cheese cake");
                    Console.WriteLine("2. Zmrzlina");
                    Console.WriteLine("2. Dort");
                    break;

                default:
                    Console.WriteLine("Spatne zadana kategorie");
                    break;
            }
        }
    }
}