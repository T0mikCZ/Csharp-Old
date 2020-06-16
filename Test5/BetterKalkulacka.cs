using System;
using System.IO;
using System.Linq;
using System.Numerics;

namespace BetterKalkulacka
{
    internal class BetterKalkulacka
    {
        private static void Main(string[] args)
        {
            //TODO Pridat loopy pro jednotlive moznosti DONE
            //TODO Pridat vice moznosti DONE
            //TODO Pridat komenty DONE
            //TODO Pridat nejaky ten colour DONE
            //TODO Predelat do UI
            //TODO Pridat Exception handlery DONE
            //MILESTONE vic jak 500 radek kodu DONE
            //MILESTONE vic jak 1000 radek kodu

            //Prototyp kalkulacky s metodamy

            //By T0M
            //MOVED TO ANOTHER VERSION

            // -----------------Verze 0.4-----------------

            System.Console.OutputEncoding = System.Text.Encoding.UTF8;

            try
            {
                //Deklarace stringu pro zeptani uzivatele jestli chce jit do menu
                string menu;

                //Do-while loop do menu
                do
                {
                    //Zepta se pro moznost uzivatele
                    //List moznosti
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Vyberte moznost:");
                    Console.WriteLine("1. Tabulka nasobeni");
                    Console.WriteLine("2. Matematicke operace pro 2 cisla: +-*/");
                    Console.WriteLine("3. Matematicke operace s libovolnym poctem cisel");
                    Console.WriteLine("4. Najde max a min");
                    Console.WriteLine("5. Najde aritmeticky prumer");
                    Console.WriteLine("6. Mocnina na kolikatou chcete");
                    Console.WriteLine("7. Vypocita obvod a obsah ctverce");
                    Console.WriteLine("8. Vypocita obvod a obsah obdelniku");
                    Console.WriteLine("9. Vypocita obvod a obsah trojuhelniku");
                    Console.WriteLine("10. Vypocita obvod a obsah kruhu");
                    Console.WriteLine("11. Vazeny prumer znamek");
                    Console.WriteLine("12. Vypocita 1% ze 100%");

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Vybrana moznost: ");

                    //Deklarace promenny, ktera ulozi hodnotu, kterou uzivatel napise
                    int vybranaMoznost = int.Parse(Console.ReadLine());

                    //Deklarace stringu pro zeptani uzivatele jestli chce pokracovat
                    string provestVypocet;

                    //do-while loop pro moznosti
                    do
                    {
                        //List if,else if, else pro moznosti
                        //Tabulka nasobilek
                        if (vybranaMoznost == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;

                            //Napise vybranou moznost
                            Console.Write("Vybrali jste moznost {0}\n", vybranaMoznost);

                            Console.ForegroundColor = ConsoleColor.Yellow;

                            //Uzivatel zada veliokost tabulky nasobeni
                            Console.Write("Zadejte velikost tabulky nasobeni: ");

                            Console.ForegroundColor = ConsoleColor.Blue;

                            //Deklaruje cislo ktere ulozi velikost do promenny
                            double cisloVelikost = int.Parse(Console.ReadLine());

                            //vyuziti metody pro vypocteni tabulky
                            Nasobilka(cisloVelikost);

                            Console.ResetColor();
                        }
                        //Matematicke operace pro 2 cisla
                        else if (vybranaMoznost == 2)
                        {
                            //deklaruje promenny pro cisla a operaci
                            double cislo1, cislo2;
                            string operace;

                            Console.ForegroundColor = ConsoleColor.Blue;

                            //Napise vybranou moznost
                            Console.Write("Vybrali jste moznost {0}\n", vybranaMoznost);

                            Console.ForegroundColor = ConsoleColor.Yellow;

                            //Zepta se uzivatele pro zadani cisla a nasledujici kod ho ulozi
                            Console.Write("Zadejte prvni cislo: ");

                            Console.ForegroundColor = ConsoleColor.Blue;

                            cislo1 = int.Parse(Console.ReadLine());

                            Console.ForegroundColor = ConsoleColor.Yellow;

                            //Zepta se uzivatele pro zadani dalsiho cisla a nasledujici kod ho ulozi
                            Console.Write("Zadejte druhe cislo: ");

                            Console.ForegroundColor = ConsoleColor.Blue;

                            cislo2 = int.Parse(Console.ReadLine());

                            Console.ForegroundColor = ConsoleColor.Yellow;

                            //Zepta se uzivatele aby napsal operaci a tu si ulozi do promenny
                            Console.Write("Zadejte operaci (+-*/): ");

                            Console.ForegroundColor = ConsoleColor.Blue;

                            operace = Console.ReadLine();

                            //ify pro jednotlive operace
                            if (operace == "+")
                            {
                                Console.WriteLine(Secti(cislo1, cislo2));
                            }
                            else if (operace == "-")
                            {
                                Console.WriteLine(Odecti(cislo1, cislo2));
                            }
                            else if (operace == "*")
                            {
                                Console.WriteLine(Krat(cislo1, cislo2));
                            }
                            else if (operace == "/")
                            {
                                Console.WriteLine(Vydel(cislo1, cislo2));
                            }

                            Console.ResetColor();
                        }
                        //Matematicke operace s libovolnym poctem cisel
                        else if (vybranaMoznost == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;

                            //Napise vybranou moznost
                            Console.Write("Vybrali jste moznost {0}\n", vybranaMoznost);

                            Console.ForegroundColor = ConsoleColor.Yellow;

                            //Zepta se uzivatele pro zadani poctu cisel a ulozi do promenne
                            Console.Write("Zadejte pocet cisel: ");

                            Console.ForegroundColor = ConsoleColor.Blue;

                            int pocetCisel = int.Parse(Console.ReadLine());

                            //Vytvori pole cisel s velikosti, kterou napsal uzivatel
                            double[] poleCisel = new double[pocetCisel];

                            //Promenny pro ulozeni jednotlivych operaci
                            double soucet = 0, rozdil = 0, soucin = 1, poddil = 1;

                            //for cyklus pro vypocet cisel
                            for (int i = 0; i < pocetCisel; i++)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;

                                //Uzivatel zada cislo a to se ulozi
                                Console.Write("{0}. cislo = ", i + 1);

                                Console.ForegroundColor = ConsoleColor.Blue;

                                double cislo = double.Parse(Console.ReadLine());

                                //Ulozi prvek z pole do cisla
                                poleCisel[i] = cislo;

                                //Vypocita vsechny cisla v poli, ktere uzivatel napsal
                                soucet += cislo;
                                rozdil -= cislo;
                                soucin *= cislo;
                            }

                            //Napise operace
                            Console.WriteLine("Soucet = {0}", soucet);
                            Console.WriteLine("Rozdil = {0}", rozdil);
                            Console.WriteLine("Soucin = {0}", soucin);
                            Console.WriteLine("Poddil = {0}", poddil);

                            Console.ResetColor();
                        }
                        //Najde nejmensi a nejvetsi cislo
                        else if (vybranaMoznost == 4)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;

                            //Napise vybranou moznost
                            Console.Write("Vybrali jste moznost {0}\n", vybranaMoznost);

                            Console.ForegroundColor = ConsoleColor.Yellow;

                            //Zepta se uzivatele pro zadani poctu cisel a ulozi do promenne
                            Console.Write("Zadejte pocet cisel: ");

                            Console.ForegroundColor = ConsoleColor.Blue;

                            int pocetCisel = Convert.ToInt32(Console.ReadLine());

                            //Vytvori pole cisel s velikosti, kterou napsal uzivatel
                            double[] poleCisel = new double[pocetCisel];

                            //for cyklus pro vypocet cisel
                            for (int i = 0; i < pocetCisel; i++)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;

                                //Uzivatel zada cislo a to se ulozi
                                Console.Write("{0}. cislo = ", i + 1);

                                Console.ForegroundColor = ConsoleColor.Blue;

                                int cislo = Convert.ToInt32(Console.ReadLine());

                                //Ulozi prvek z pole do cisla
                                poleCisel[i] = cislo;
                            }
                            //Napise nejmensi a nejvetsi cislo
                            Console.WriteLine("Nejmensi cislo je " + poleCisel.Min());
                            Console.WriteLine("Nejvetsi cislo je " + poleCisel.Max());

                            Console.ResetColor();
                        }
                        //Prumer
                        else if (vybranaMoznost == 5)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;

                            //Napise vybranou moznost
                            Console.Write("Vybrali jste moznost {0}\n", vybranaMoznost);

                            Console.ForegroundColor = ConsoleColor.Yellow;

                            //Zepta se uzivatele pro zadani poctu cisel a ulozi do promenne
                            Console.Write("Zadejte pocet cisel: ");

                            Console.ForegroundColor = ConsoleColor.Blue;

                            int pocetCisel = Convert.ToInt32(Console.ReadLine());

                            //Vytvori pole cisel s velikosti, kterou napsal uzivatel
                            double[] poleCisel = new double[pocetCisel];

                            //for cyklus pro vypocet cisel
                            for (int i = 0; i < pocetCisel; i++)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;

                                //Uzivatel zada cislo a to se ulozi
                                Console.Write("{0}. cislo = ", i + 1);

                                Console.ForegroundColor = ConsoleColor.Blue;

                                int cislo = Convert.ToInt32(Console.ReadLine());

                                //Ulozi prvek z pole do cisla
                                poleCisel[i] = cislo;
                            }

                            //Napise prumer
                            Console.WriteLine(AritPrumer(poleCisel));

                            Console.ResetColor();
                        }
                        //Mocnina
                        else if (vybranaMoznost == 6)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;

                            //Napise vybranou moznost
                            Console.Write("Vybrali jste moznost {0}\n", vybranaMoznost);

                            Console.ForegroundColor = ConsoleColor.Yellow;

                            //Vyzve uzivatele, aby zadal cislo a to si ulozi
                            Console.Write("Zadejte cislo: ");

                            Console.ForegroundColor = ConsoleColor.Blue;

                            BigInteger cislo = BigInteger.Parse(Console.ReadLine());

                            Console.ForegroundColor = ConsoleColor.Yellow;

                            //Vyzve uzivatele, aby zadal mocninove cislo pro vypocet a to si ulozi
                            Console.Write("Zadejte mocninove cislo: ");

                            Console.ForegroundColor = ConsoleColor.Blue;

                            BigInteger mocCislo = BigInteger.Parse(Console.ReadLine());

                            string path = @"C:\Users\Tomyk\source\repos\1Program\Test5\bin\Debug\MocninaLog.txt";

                            using (StreamWriter sw = File.CreateText(path))
                            {
                                Console.WriteLine("Mocnina cisla {0} na {1} = {2}", cislo, mocCislo, Mocnina(cislo, mocCislo));

                                sw.WriteLine("Mocnina cisla {0} na {1} = {2}", cislo, mocCislo, Mocnina(cislo, mocCislo));

                                sw.AutoFlush = true;
                            }
                            //Vypise konecny vysledek

                            Console.ResetColor();
                        }
                        //Ctverec
                        else if (vybranaMoznost == 7)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;

                            //Napise vybranou moznost
                            Console.Write("Vybrali jste moznost {0}\n", vybranaMoznost);

                            Console.ForegroundColor = ConsoleColor.Yellow;

                            //Vyzve uzivatele, aby zadal velikost ctverce a to si ulozi
                            Console.Write("Zadejte velikost ctverce: ");

                            Console.ForegroundColor = ConsoleColor.Blue;

                            double velikost = Convert.ToDouble(Console.ReadLine());

                            //Vypise obvod a obsah ctverce
                            Console.WriteLine("Obvod ctverce je {0}cm", ObvodCtverce(velikost));
                            Console.WriteLine("Obsah ctverce je {0}cm²", ObsahCtverce(velikost));

                            Console.ForegroundColor = ConsoleColor.Yellow;

                            Console.Write("Chcete konvertovat obvod a obsah na jinou jednotku? ");

                            Console.ForegroundColor = ConsoleColor.Blue;

                            string konvertovat = Console.ReadLine();

                            if (konvertovat == "ano")
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;

                                Console.WriteLine("Vyberte moznost:");
                                Console.WriteLine("1. m");
                                Console.WriteLine("2. mm");

                                Console.ForegroundColor = ConsoleColor.Blue;

                                Console.Write("Vybrana moznost: ");
                                int konvertMoznost = Convert.ToInt32(Console.ReadLine());

                                switch (konvertMoznost)
                                {
                                    case 1:
                                        Console.WriteLine("Obvod ctverce je {0}m", ObvodCtverce(velikost / 100));
                                        Console.WriteLine("Obsah ctverce je {0}m²", ObsahCtverce(velikost / 10000));
                                        break;

                                    case 2:
                                        Console.WriteLine("Obvod ctverce je {0}mm", ObvodCtverce(velikost * 10));
                                        Console.WriteLine("Obsah ctverce je {0}mm²", ObsahCtverce(velikost * 100));
                                        break;
                                }
                            }

                            Console.ResetColor();
                        }
                        //Obdelnik
                        else if (vybranaMoznost == 8)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;

                            //Napise vybranou moznost
                            Console.Write("Vybrali jste moznost {0}\n", vybranaMoznost);

                            Console.ForegroundColor = ConsoleColor.Yellow;

                            //Vyzve uzivatele, aby zadal velikost strany obdelniku a to si ulozi
                            Console.Write("Zadejte velikost strany obdelniku A: ");

                            Console.ForegroundColor = ConsoleColor.Blue;

                            double velikostA = Convert.ToDouble(Console.ReadLine());

                            Console.ForegroundColor = ConsoleColor.Yellow;

                            //Vyzve uzivatele, aby zadal dalsi velikost strany obdelniku a to si ulozi
                            Console.Write("Zadejte velikost strany obdelniku B: ");

                            Console.ForegroundColor = ConsoleColor.Blue;

                            double velikostB = Convert.ToDouble(Console.ReadLine());

                            //Vypise obvod a obsah obdelniku
                            Console.WriteLine("Obvod obdelinku je {0}cm", ObvodObdelniku(velikostA, velikostB));
                            Console.WriteLine("Obsah obdelinku je {0}cm²", ObsahObdelniku(velikostA, velikostB));

                            Console.ForegroundColor = ConsoleColor.Yellow;

                            Console.Write("Chcete konvertovat obvod a obsah na jinou jednotku? ");

                            Console.ForegroundColor = ConsoleColor.Blue;

                            string konvertovat = Console.ReadLine();

                            if (konvertovat == "ano")
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;

                                Console.WriteLine("Vyberte moznost:");
                                Console.WriteLine("1. m");
                                Console.WriteLine("2. mm");

                                Console.ForegroundColor = ConsoleColor.Blue;

                                Console.Write("Vybrana moznost: ");
                                int konvertMoznost = Convert.ToInt32(Console.ReadLine());

                                switch (konvertMoznost)
                                {
                                    case 1:
                                        Console.WriteLine("Obvod obdelinku je {0}m", ObvodObdelniku(velikostA / 100, velikostB / 100));
                                        Console.WriteLine("Obsah obdelinku je {0}m²", ObsahObdelniku(velikostA / 10000, velikostB / 10000));
                                        break;

                                    case 2:
                                        Console.WriteLine("Obvod obdelinku je {0}mm", ObvodObdelniku(velikostA * 10, velikostB * 10));
                                        Console.WriteLine("Obsah obdelinku je {0}mm²", ObsahObdelniku(velikostA * 100, velikostB * 100));
                                        break;
                                }
                            }

                            Console.ResetColor();
                        }
                        //Trojuhelnik
                        else if (vybranaMoznost == 9)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;

                            //Napise vybranou moznost
                            Console.Write("Vybrali jste moznost {0}\n", vybranaMoznost);

                            Console.ForegroundColor = ConsoleColor.Yellow;

                            //Vyzve uzivatele, aby zadal velikost strany trojhuelniku a to si ulozi
                            Console.Write("Zadejte velikost strany trojuhelnoku a: ");

                            Console.ForegroundColor = ConsoleColor.Blue;

                            double velikostA = Convert.ToDouble(Console.ReadLine());

                            Console.ForegroundColor = ConsoleColor.Yellow;

                            //Vyzve uzivatele, aby zadal dalsi velikost strany trojhuelniku a to si ulozi
                            Console.Write("Zadejte velikost strany trojuhleniku b: ");

                            Console.ForegroundColor = ConsoleColor.Blue;

                            double velikostB = Convert.ToDouble(Console.ReadLine());

                            Console.ForegroundColor = ConsoleColor.Yellow;

                            //Vyzve uzivatele, aby zadal dalsi velikost strany trojhuelniku a to si ulozi
                            Console.Write("Zadejte velikost strany trojuhleniku c: ");

                            Console.ForegroundColor = ConsoleColor.Blue;

                            double velikostC = Convert.ToDouble(Console.ReadLine());

                            //Vypise obvod a obsah trojuhelniku
                            Console.WriteLine("Obvod trojuhelniku je {0}cm", ObvodTrojuhelniku(velikostA, velikostB, velikostC));
                            Console.WriteLine("Obsah trojuhelniku je {0}cm²", ObsahTrojuhelniku(velikostA, velikostB, velikostC));

                            Console.ForegroundColor = ConsoleColor.Yellow;

                            Console.Write("Chcete konvertovat obvod a obsah na jinou jednotku? ");

                            Console.ForegroundColor = ConsoleColor.Blue;

                            string konvertovat = Console.ReadLine();

                            if (konvertovat == "ano")
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;

                                Console.WriteLine("Vyberte moznost:");
                                Console.WriteLine("1. m");
                                Console.WriteLine("2. mm");

                                Console.ForegroundColor = ConsoleColor.Blue;

                                Console.Write("Vybrana moznost: ");
                                int konvertMoznost = Convert.ToInt32(Console.ReadLine());

                                switch (konvertMoznost)
                                {
                                    case 1:
                                        Console.WriteLine("Obvod trojuhelniku je {0}m", ObvodTrojuhelniku(velikostA / 100, velikostB / 100, velikostC / 100));
                                        Console.WriteLine("Obsah trojuhelniku je {0}m²", ObsahTrojuhelniku(velikostA / 10000, velikostB / 10000, velikostC / 10000));
                                        break;

                                    case 2:
                                        Console.WriteLine("Obvod trojuhelniku je {0}mm", ObvodTrojuhelniku(velikostA * 10, velikostB * 10, velikostC * 10));
                                        Console.WriteLine("Obsah trojuhelniku je {0}mm²", ObsahTrojuhelniku(velikostA * 100, velikostB * 100, velikostC * 100));
                                        break;
                                }
                            }

                            Console.ResetColor();
                        }
                        //Kruh
                        else if (vybranaMoznost == 10)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;

                            //Napise vybranou moznost
                            Console.Write("Vybrali jste moznost {0}\n", vybranaMoznost);

                            Console.ForegroundColor = ConsoleColor.Yellow;

                            //Vyzve uzivatele, aby zadal polomer kruhu a to si ulozi
                            Console.Write("Zadejte polomer kruhu: ");

                            Console.ForegroundColor = ConsoleColor.Blue;

                            double polomer = Convert.ToDouble(Console.ReadLine());

                            //Vypise obvod a obsah kruhu
                            Console.WriteLine("Obvod kruhu je {0}cm", ObvodKruhu(polomer));
                            Console.WriteLine("Obsah kruhu je {0}cm²", ObsahKruhu(polomer));

                            Console.ForegroundColor = ConsoleColor.Yellow;

                            Console.Write("Chcete konvertovat obvod a obsah na jinou jednotku? ");

                            Console.ForegroundColor = ConsoleColor.Blue;

                            string konvertovat = Console.ReadLine();

                            if (konvertovat == "ano")
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;

                                Console.WriteLine("Vyberte moznost:");
                                Console.WriteLine("1. m");
                                Console.WriteLine("2. mm");

                                Console.ForegroundColor = ConsoleColor.Blue;

                                Console.Write("Vybrana moznost: ");
                                int konvertMoznost = Convert.ToInt32(Console.ReadLine());

                                switch (konvertMoznost)
                                {
                                    case 1:
                                        Console.WriteLine("Obvod ctverce je {0}m", ObvodKruhu(polomer / 100));
                                        Console.WriteLine("Obsah ctverce je {0}m²", ObsahKruhu(polomer / 10000));
                                        break;

                                    case 2:
                                        Console.WriteLine("Obvod ctverce je {0}mm", ObvodKruhu(polomer * 10));
                                        Console.WriteLine("Obsah ctverce je {0}mm²", ObsahKruhu(polomer * 100));
                                        break;
                                }
                            }

                            Console.ResetColor();
                        }
                        //Vazeny Prumer
                        else if (vybranaMoznost == 11)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;

                            //Napise vybranou moznost
                            Console.Write("Vybrali jste moznost {0}\n", vybranaMoznost);

                            Console.ForegroundColor = ConsoleColor.Yellow;

                            //Vyzve uzivatele k zadani cisla a to si ulozi
                            Console.Write("Zadejte pocet znamek: ");

                            Console.ForegroundColor = ConsoleColor.Blue;

                            int pocetZnamek = Convert.ToInt32(Console.ReadLine());

                            //Vytvori 2 pole s velikosti, kterou zada uzivatel
                            int[] poleZnamek = new int[pocetZnamek];

                            int[] poleVahyZnamek = new int[pocetZnamek];

                            //Promenne pro vypocet
                            double soucetVah = 0;
                            double prumer = 0;

                            double vazenyPrumer = 0;

                            //for loop pro vypocet vahy a znamek
                            for (int i = 0; i < pocetZnamek; i++)
                            {
                                //Zepta se uzivatele aby zadal znamku a vahu znamky a ulozi hodnoty do pole a pote vypise
                                Console.Write("{0}. znamka = ", i + 1);
                                int znamka = Convert.ToInt32(Console.ReadLine());

                                Console.Write("Vaha {0}. znamky = ", i + 1);
                                int vaha = Convert.ToInt32(Console.ReadLine());

                                poleZnamek[i] = znamka;
                                poleVahyZnamek[i] = vaha;

                                Console.Write("\n{0}. znamka = {1}, vaha = {2} \n\n", i + 1, znamka, vaha);

                                //secte vahy
                                soucetVah += vaha;

                                //Vypocet prumeru
                                prumer = (prumer + (znamka * vaha));
                            }

                            //Konecny vypocet vazneho prumeru
                            vazenyPrumer = prumer / soucetVah;

                            //Vypise vysledek
                            Console.WriteLine("Vazeny prumer je {0}", vazenyPrumer);

                            Console.ResetColor();
                        }
                        //Vypocita 1%
                        else if (vybranaMoznost == 12)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;

                            //Napise vybranou moznost
                            Console.Write("Vybrali jste moznost {0}\n", vybranaMoznost);

                            Console.ForegroundColor = ConsoleColor.Yellow;

                            //Vyzve uzivatele at napise cislo a to si ulozi
                            Console.Write("Zadejte cislo ze ktereho chcete vypocitat 1%: ");

                            Console.ForegroundColor = ConsoleColor.Blue;

                            double cislo = Convert.ToDouble(Console.ReadLine());

                            //Napise vysledek
                            Console.WriteLine("1% ze {0} je {1}", cislo, Procento(cislo, 100));

                            Console.Write("Chcete vypocitat dalsi procento? ");
                            string pokracovat = Console.ReadLine();

                            if (pokracovat == "ano")
                            {
                                Console.Write("Zadejte procento, ktere chcete vypocitat: ");
                                double mulProcento = Convert.ToDouble(Console.ReadLine());

                                Console.WriteLine("Procento {0} = {1}", mulProcento, Procento(cislo, mulProcento));
                            }
                        }
                        //jestli uzivatel nenapise nic z predchozich moznosti
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;

                            Console.WriteLine("Spatne vybrana moznost!");

                            Console.ResetColor();
                        }

                        Console.ForegroundColor = ConsoleColor.Magenta;

                        //Zepta se uzivatele jestli chce provest vypocet, pokud uzivatel napise ano moznost se provede znovu
                        Console.Write("Chcete provest dalsi vypocet? ");
                        provestVypocet = Console.ReadLine();

                        Console.ResetColor();

                        //Konec loopu
                    } while (provestVypocet == "ano");

                    Console.ForegroundColor = ConsoleColor.DarkMagenta;

                    //Zepta se uzivatele jestli se chce vratit do menu
                    Console.Write("Chcete se vratit do menu? ");
                    menu = Console.ReadLine();

                    Console.ResetColor();

                    //Vycisti konzoli
                    Console.Clear();

                    //Konec loopu
                } while (menu == "ano");
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
            }

            Console.ReadKey();
        }

        // ------------Metody pro ruzne operace------------

        //Tabulka Nasobilky
        private static void Nasobilka(double velikost)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            //Vycte na konzoli nasobilku s danou velikosti
            Console.WriteLine("Tabulka nasobilky velikosti {0}\n", velikost);

            Console.ForegroundColor = ConsoleColor.Blue;

            for (double i = 1; i <= velikost; i++)
            {
                for (double j = 1; j <= velikost; j++)
                {
                    Console.Write("{0} ", i * j);
                }
                Console.Write(" X{0}\n", i);
            }

            Console.ResetColor();
        }

        //1% procento
        private static double Procento(double cislo, double mulProcento)
        {
            return cislo / mulProcento;
        }

        //Obvod Kruhu
        private static double ObvodKruhu(double polomer)
        {
            //Vypocita obvod a vrati hodnotu
            return (Math.PI + Math.PI) * polomer;
        }

        //obsah Kruhu
        private static double ObsahKruhu(double polomer)
        {
            //Vypocita obsah a vrati hodnotu
            return Math.PI * (polomer * polomer);
        }

        //Obvod Trojuhelniku
        private static double ObvodTrojuhelniku(double velikostA, double velikostB, double velikostC)
        {
            //Vypocita obvod a vrati hodnotu
            return velikostA + velikostB + velikostC;
        }

        //Obsah Trojuhelniku
        private static double ObsahTrojuhelniku(double velikostA, double velikostB, double velikostC)
        {
            //Deklaruje promennou pro vypocet
            double s = (velikostA + velikostB + velikostC) / 2;

            //Vypocita obsah a vrati hodnotu
            return (s * (s - velikostA) * (s - velikostB) * (s - velikostC));
        }

        //Obvod Obdelniku
        private static double ObvodObdelniku(double velikostA, double velikostB)
        {
            //Jestli se a nerovna b tak proved normalni vypocet
            if (velikostA != velikostB)
            {
                //Vrati obvod obdelniku
                return 2 * velikostA + 2 * velikostB;
            }
            //Jestli se a rovna b tak napise error a vysledek se rovna 0
            Console.WriteLine("Obdelnik nemuze mit stejne strany!");
            //vrati 0, protoze se a rovna b
            return 0;
        }

        //Obsah Obdelniku
        private static double ObsahObdelniku(double velikostA, double velikostB)
        {
            //Jestli se a nerovna b tak proved normalni vypocet
            if (velikostA != velikostB)
            {
                //Vrati obsah obdelniku
                return velikostA * velikostB;
            }
            //Jestli se a rovna b tak napise error a vysledek se rovna 0
            Console.WriteLine("Obdelnik nemuze mit stejne strany!");
            //vrati 0, protoze se a rovna b
            return 0;
        }

        //Obvod Ctverce
        private static double ObvodCtverce(double velikost)
        {
            //Vrati obvod ctverce Priklad: (5*4=20)
            return velikost * 4;
        }

        //Obsah Ctverce
        private static double ObsahCtverce(double velikost)
        {
            //Vrati obsah ctverce Priklad: (5*5=25)
            return velikost * velikost;
        }

        //Mocnina
        private static BigInteger Mocnina(BigInteger cislo, BigInteger mocnina)
        {
            //Deklarace souctu pro ulozeni vypoctu mocnin
            BigInteger soucet = 1;

            //Cykl pro vypocet mocniny
            for (int i = 1; i <= mocnina; i++)
            {
                //Ulozi vypocet mocniny
                soucet *= cislo;
            }

            return soucet;
        }

        //Aritmeticky prumer
        private static double AritPrumer(double[] pole)
        {
            //Deklarace souctu pro ulozeni prumeru
            double soucet = 0;

            //Vyhleda kazdy prvek v poli cisel
            foreach (double cislo in pole)
            {
                //Secte vsechny cisla v poli
                soucet += cislo;
            }
            //Sectena cisla / cisel v poli = prumer
            return soucet / pole.Length;
        }

        //Secte dve cisla
        private static double Secti(double num1, double num2)
        {
            //cislo1 + cislo2
            return num1 + num2;
        }

        //Odecte dve cisla
        private static double Odecti(double num1, double num2)
        {
            //cislo1 - cislo2
            return num1 - num2;
        }

        //Vykrati dve cisla
        private static double Krat(double num1, double num2)
        {
            //cislo1 * cislo2
            return num1 * num2;
        }

        //Vydeli dve cisla
        private static double Vydel(double num1, double num2)
        {
            //cislo1 / cislo2
            return num1 / num2;
        }
    }
}