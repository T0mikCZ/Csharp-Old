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
                Console.WriteLine("7. Hledat zvirata podle jmena");
                Console.WriteLine("8. Pocet zvirat");
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
                            Console.WriteLine("1. Pridat Zamestnance");
                            Console.WriteLine("2. Odstranit Zamestnance");
                            Console.WriteLine("3. Upravit Zamestnance");
                            Console.WriteLine("4. Vypis Zamestnancu");
                            Console.WriteLine("5. Zmenit do ZOO menu");
                            Console.WriteLine("6. Pocet Zamestnancu");
                            Console.WriteLine("7. Vypis Prumer mzdy vsech zamestnancu");
                            Console.Write("\nVyberte si moznost: ");
                            zMoznost = Console.ReadLine();

                            switch (zMoznost)
                            {
                                case "1":
                                    zamestnanci.PridatZamestnance();
                                    break;
                                case "2":
                                    zamestnanci.OdstranitZamestnance();
                                    break;
                                case "3":
                                    zamestnanci.UpravitZamestnance();
                                    break;
                                case "4":
                                    zamestnanci.VypisZamestnancu();
                                    Console.ReadKey();
                                    break;
                                //Case 5 je pro zmenu menu  
                                case "6":
                                    zamestnanci.PocetZamestnancu();
                                    Console.ReadKey();
                                    break;
                                case "7":
                                    Console.WriteLine("Prumer Mezd: {0}",zamestnanci.PrumerMezd());
                                    Console.ReadKey();
                                    break;
                                default:
                                    Console.WriteLine("Spatne zadana moznost");
                                    break;
                            }

                            Console.Clear();
                        } while (zMoznost != "5");
                        break;
                    case "7":
                        zoo.HledatZvire();
                        break;
                    case "8":
                        zoo.PocetZvirat();
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
