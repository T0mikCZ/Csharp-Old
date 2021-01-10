using System;

namespace SheevPalpatine
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 0;

            do
            {

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Title = "Hello There";
                Console.WriteLine("1.Be senate");
                Console.WriteLine("2.Who is Senate");
                Console.WriteLine("3.Leave Senate");
                Console.Write("Type the number of your option and press enter: ");
                option = int.Parse(Console.ReadLine());


                if (option == 1)
                {
                    Console.Write("Did you heard tragedy of Darth Plageues The Wise? ");
                    string heard = Console.ReadLine();

                    if (heard == "yes" || heard == "Yes")
                    {
                        Console.WriteLine("It's Treason then....... (Sheev Jumps and Kill You)");
                    }
                    else
                    {
                        Console.WriteLine("I thought not. It's not a story the Jedi would tell you. It's a Sith legend. Darth Plagueis was a Dark Lord of the Sith, so powerful and so wise he could use the Force to influence the midichlorians to create lifeů He had such a knowledge of the dark side that he could even keep the ones he cared about from dying. The dark side of the Force is a pathway to m");
                        Console.WriteLine("any abilities some consider to be unnatural. He became so powerfulů the only thing he was afraid of was losing his power, which eventually, of course, he did. Unfortunately, he taught his apprentice everything he knew, then his apprentice k");
                        Console.WriteLine("illed him in his sleep. Ironic. He could save others from death, but not himself.");
                    }
                }
                else if (option == 2)
                {
                    Console.WriteLine("Hello there Senate is me and Palpatine");
                    Console.ReadKey();
                }
                else if (option == 3)
                {
                    Console.WriteLine("You left");
                }
                else
                {
                    Console.WriteLine("Leave!");

                }
            } while (option < 1 || option > 3);
        }
    }
}
