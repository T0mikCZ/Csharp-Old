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
            Zamestnanci zamestnanci = new Zamestnanci();

            string moznost = "";
            string zMoznost = "";
            do
            {

                Console.WriteLine("\nZOO MENU");
                Console.WriteLine("1. Pridat Zvire");
                Console.WriteLine("2. Odstranit Zvire");
                Console.WriteLine("3. Upravit Zvire");
                Console.WriteLine("4. Vypis Zvirat");
                Console.WriteLine("5. Ukoncit Program");
                Console.WriteLine("6. Prepnout na Zamestnantsky mod");
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
                        zoo.UpravitZvire();
                        break;
                    case "4":
                        zoo.VypisZvirat();
                        Console.ReadKey();
                        break;
                    //Case 5 je pro ukonceni  
                    case "6":
                        Console.Clear();
                        do
                        {

                            Console.WriteLine("\nZAMESTNANCI MENU");
                            Console.WriteLine("1. Pridat Zvire");
                            Console.WriteLine("2. Odstranit Zvire");
                            Console.WriteLine("3. Upravit Zvire");
                            Console.WriteLine("4. Vypis Zvirat");
                            Console.WriteLine("5. Ukoncit Program");
                            Console.WriteLine("6. Prepnout na Zamestnantsky mod");
                            Console.Write("\nVyberte si moznost: ");
                            zMoznost = Console.ReadLine();

                            switch (moznost)
                            {
                                case "1":
                                    zoo.PridatZvire();
                                    break;
                                case "2":
                                    zoo.OdstranitZvire();
                                    break;
                                case "3":
                                    zoo.UpravitZvire();
                                    break;
                                case "4":
                                    zoo.VypisZvirat();
                                    Console.ReadKey();
                                    break;
                                //Case 5 je pro ukonceni  
                                case "6":

                                    Console.ReadKey();
                                    break;
                                default:
                                    Console.WriteLine("Spatne zadana moznost");
                                    break;
                            }

                            Console.Clear();
                        } while (moznost != "5");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Spatne zadana moznost");
                        break;
                }

                Console.Clear();
            } while (moznost != "5");

        }
    }
}
