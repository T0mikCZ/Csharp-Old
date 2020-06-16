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

                Console.WriteLine("ZOO MENU");
                Console.WriteLine("1. Pridat Zvire");
                Console.WriteLine("2. Odstranit Zvire");
                Console.WriteLine("3. Vypis Zvirat");
                Console.WriteLine("4. Ukoncit Program");
                Console.WriteLine("Vyberte si moznost: \n");
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

            } while (moznost != "4");

            Console.ReadKey();

        }
    }
}
