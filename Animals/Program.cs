using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            ZOO zoo = new ZOO();
            string moznost = "";

            do
            {

                Console.WriteLine("\nZOO MENU");
                Console.WriteLine("1. Pridat Zvire");
                Console.WriteLine("2. Odstranit Zvire");
                Console.WriteLine("3. Vypis Zvirat");
                Console.WriteLine("4. Ukoncit Program");
                Console.Write("\nVyberte si moznost: ");
                moznost = Console.ReadLine();

                switch (moznost)
                {
                    case "1":
                        zoo.PridatZvire();
                        break;
                    case "2":
                        zoo.OdstranitZvire();
                        break;
                    case "3":
                        zoo.VypisZvirat();
                        break;
                    default:
                        Console.WriteLine("Spatne zadana moznost");
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            } while (moznost != "4");

        }
    }
}
