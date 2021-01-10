using System;

namespace Cviceni6
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //TODO rozvinout moznosti DONE
            //TODO pridat secrety
            Console.Title = "Pribeh";
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Mate penize? ");
            string menu = "";
            string penize = Console.ReadLine();

            //Secret Palpatine

            if (penize == "sheev palpatine" || penize == "Sheev Palpatine" || penize == "sheev Palpatine" || penize == "Sheev palpatine" || penize == "SHEEV PALPATINE")
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Title = "HELLO THERE, SECRET";
                Console.WriteLine("Main Menu");
                Console.WriteLine("1.Be Senate");
                Console.WriteLine("2.Who is Senate");
                Console.WriteLine("3.Leave Senate");
                Console.Write("Choose number: ");
                int secretChoice = int.Parse(Console.ReadLine());

                switch (secretChoice)
                {
                    case 1:
                        Console.Write("Did you heard about tragedy of Darth Plageues The Wise? ");
                        string heard = Console.ReadLine();

                        if (heard == "yes" || heard == "Yes")
                        {
                            Console.WriteLine("It's Treason then....... (Sheev Jumps and Kill You)");
                        }
                        else
                        {
                            Console.WriteLine("I thought not. It's not a story the Jedi would tell you. It's a Sith legend. Darth Plagueis was a Dark Lord of the Sith, so powerful and so wise he could use the Force to influence the midichlorians to create life He had such a knowledge of the dark side that he could even keep the ones he cared about from dying");
                            Console.WriteLine(". The dark side of the Force is a pathway to many abilities some consider to be unnatural. He became so powerfulů the only thing he was afraid of was losing his power, which eventually, of course, he did. Unfortunately, he taught his apprentice everything he knew, then his apprentice killed him in his sleep. Iron");
                            Console.WriteLine("ic. He could save others from death, but not himself.");
                            Console.ReadKey();

                            Console.WriteLine("Sheev then jumps and kills you");
                        }
                        break;

                    case 2:
                        Console.WriteLine("Hello There! (Senate is Me and Palpatine)");
                        menu = Console.ReadLine();
                        break;

                    case 3:
                        Console.WriteLine("You left");
                        break;

                    default:
                        Console.WriteLine("Leave!");
                        break;
                }
            }

            //Secret Palpatine

            if (penize == "ano" || penize == "Ano")
            {
                Console.Write("Je kino otevrene? ");
                string kino = Console.ReadLine();

                if (kino == "ano" || kino == "Ano")
                {
                    Console.Write("A davaji v nem zajimavy film? ");
                    string filmKino = Console.ReadLine();

                    if (filmKino == "ano" || filmKino == "Ano")
                    {
                        Console.WriteLine("Doporucuji zajit do kina na film");
                    }
                    else
                    {
                        Console.WriteLine("Doporucuji si zajit na nejaky nahodny film");
                        Console.Write("Chcete si zajit na nahodny film? ");
                        string nahodnyFilm = Console.ReadLine();

                        if (nahodnyFilm == "ano" || nahodnyFilm == "Ano")
                        {
                            Console.WriteLine("Tak uz bezte");
                        }
                        else
                        {
                            Console.WriteLine("Tak zavolejte svemu kamaradovy");
                            Console.ReadLine();
                            Console.WriteLine("Pokud zadny kamarad neni k dispozici doporucuji si precist knihu nebo si neco zahrat");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Doporucuji zajit s kamarady do mesta nebo do obchodu");
                    Console.ReadLine();
                    Console.WriteLine("Pokud je uz vecer nebo se vam nechce, muzete zustat doma a neco si precist, nebo muzete pozadat me a ja vam nejakou prectu (ano/ne)");
                    string precistKnihu = Console.ReadLine();

                    if (precistKnihu == "ano" || precistKnihu == "Ano")
                    {
                        Console.Title = "HLEDEJ SECRET";
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        string precistDalsi;
                        do
                        {
                            Console.WriteLine("                                          ");
                            Console.WriteLine("Dobra tedy. Vyberte si knihu k zobrazeni: ");
                            Console.WriteLine("1.Lord Of The rings ");
                            Console.WriteLine("2.The hobbit ");
                            Console.WriteLine("3.Harry potter ");
                            Console.WriteLine("4.Mein kampf ");
                            Console.WriteLine("5.Bible ");
                            Console.WriteLine("6.JoJo's Bizzare Adventure ");
                            Console.WriteLine("Vyberte si cislo pozadovane knihy (1.2.3.4.5.6)");
                            Console.Write("Vybrane cislo: ");
                            int kategorie = int.Parse(Console.ReadLine());

                            switch (kategorie)
                            {
                                case 1:
                                    Console.WriteLine("Tři prsteny pro krále elfů pod nebem,");
                                    Console.WriteLine("Sedm vládcům trpaslíků v síních z kamene,");
                                    Console.WriteLine("Devět mužům: každý je k smrti odsouzen,");
                                    Console.WriteLine("Jeden pro Temného pána, jenž dli na trůně");
                                    Console.WriteLine("v zemi Mordor, kde se snoubí šero se šerem.");
                                    Console.WriteLine("jeden prsten vládne všem. Jeden jim všem káže,");
                                    Console.WriteLine("Jeden všechny přivede, do temnoty sváže");
                                    Console.WriteLine("v zemi Mordor, kde se snoubí šero se šerem.");
                                    Console.WriteLine("Kvuli optimalizaci programu sem nebudu davat celou knihu");
                                    Console.WriteLine("Pro vice informaci: https://cteni-online.webnode.cz/pan-prstenu-spolecenstvo-prstenu/ ");
                                    break;

                                case 2:

                                    Console.WriteLine("Pro vice informaci: http://www.schacco.savana-hosting.cz/vlastni_web/admin_knih75/stahnout_ebook.php?id=254  SHEEV");
                                    break;

                                case 3:
                                    Console.WriteLine("Harry Potter si myslí, že je obyčejný kluk. Když byl ještě malý,");
                                    Console.WriteLine("zemřeli mu rodiče a on zná jen těžký život u strýce, tety a jejich tlustého a rozmazleného synka Dudleyho");
                                    Console.WriteLine("Vše se ale změní ve chvíli, lucian kdy mu poštovní sova přinese záhadný dopis");
                                    Console.WriteLine("pozvánku ke studiu na Škole čar a kouzel v Bradavicíc");
                                    Console.WriteLine(", a obr Hagrid mu prozradí, že je kouzelník! Harry neváhá ani vteřinu a odjíždí do Bradavic");
                                    Console.WriteLine("kde potká své nejlepší kamarády - Rona Weasleyho a Hermionu Grangerovou,");
                                    Console.WriteLine("naučí se ovládat své kouzelnické schopnosti, stane se členem školního týmu Famfrpálu");
                                    Console.WriteLine("populárního kouzelnického sportu na košťatech, a především svede bitvu s Voldemortem, Pánem zla.");
                                    Console.WriteLine("Kvuli optimalizaci programu sem nebudu davat celou knihu");
                                    Console.WriteLine("Pro vice informaci: https://cteni-online.webnode.cz/pan-prstenu-spolecenstvo-prstenu/ ");
                                    break;

                                case 4:
                                    Console.WriteLine("To, že mi osud určil jako rodiště Braunau an Inn, považuji dnes za předurčení šťastné");
                                    Console.WriteLine("Pro vice informaci: http://www.vzdelavaci-institut.info/?q=system/files/Mein_Kampf-Adolf_Hitler.pdf ");
                                    break;

                                case 5:
                                    Console.WriteLine("Na počátku Bůh stvořil nebe a zemi. 2Země pak byla pustá a prázdná, nad propastí byla tma a");
                                    Console.WriteLine("nad vodami se vznášel Boží Duch.");
                                    Console.WriteLine("Bůh řekl: „Ať je světlo!“ – a bylo světlo. 4Bůh viděl, že světlo je dobré, a Bůh oddělil světlo od tmy.");
                                    Console.WriteLine("Bůh nazval světlo „den“ a tmu nazval „noc“. Byl večer a bylo ráno, den první.");
                                    Console.WriteLine("Bůh řekl: „Ať je uprostřed vod obloha, aby oddělovala vody od vod!“ 7Bůh učinil oblohu a oddělil vody pod oblohou od vod nad oblohou – a stalo se.");
                                    Console.WriteLine("Bůh nazval oblohu „nebe“ a byl večer a bylo ráno, den druhý.");
                                    Console.WriteLine("Bůh řekl: „Ať se vody pod nebem shromáždí na palpatine jedno místo a ať se ukáže souš!“ – a stalo se. 10Bůh nazval souš „země“ a shromáždění vod nazval „moře“. A Bůh viděl, že je to dobré.");
                                    Console.WriteLine("ehdy Bůh řekl: „Ať země zplodí zeleň: byliny nesoucí semeno a různé druhy plodných stromů nesoucích ovoce, v němž je jejich semeno na zemi!“ – a stalo se. 12Země vydala zeleň: různé druhy bylin nesoucích semeno a různé druhy stromů nesoucích ovoce, v němž je jejich semeno. A Bůh viděl, že je to dobré. 13Byl večer a bylo ráno, den třetí.");
                                    Console.WriteLine("Bůh řekl: „Ať jsou na nebeské obloze svítilny, aby oddělovaly den od noci; budou znameními k určování období, dnů a let; 15budou na nebeské obloze svítilnami k osvětlování země!“ – a stalo se.");
                                    Console.WriteLine("Pro vice informaci: https://www.bible21.cz/online#genesis/1 ");
                                    break;

                                case 6:
                                    Console.WriteLine("Pro vice informaci: https://en.wikipedia.org/wiki/JoJo%27s_Bizarre_Adventure ");
                                    break;

                                default:
                                    Console.WriteLine("Spatne zadana volba");
                                    break;
                            }
                            Console.Write("Chcete si precist dalsi? ");
                            precistDalsi = Console.ReadLine();
                        } while (precistDalsi == "ano" || precistDalsi == "Ano");
                    }
                    else
                    {
                        Console.WriteLine("Tak si bezte neco zahrat");
                    }
                }
            }
            else
            {
                Console.Write("Je venku hezky? ");
                string venku = Console.ReadLine();

                if (venku == "ano" || venku == "Ano")
                {
                    Console.WriteLine("Doporucuji zajit ven");
                    Console.ReadKey();
                    Console.WriteLine("Pokud se vam ven nechce. Doporucuji si neco zahrat");
                }
                else
                {
                    Console.WriteLine("Doporucuji si precist knihu");
                    Console.ReadKey();
                    Console.WriteLine("Pokud se vam ven nechce. Doporucuji si neco zahrat");
                }
            }
        }
    }
}