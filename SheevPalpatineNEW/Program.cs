using System;
using System.Media;

namespace SheevPalpatineNEW
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Title = "Hello There";

            SoundPlayer player = new SoundPlayer();

            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "palp.wav";
            player.Play();

            Console.WriteLine("Main Menu");
            Console.WriteLine("1. Be Senate");
            Console.WriteLine("2. Who is Senate?");
            Console.WriteLine("3. Leave Senate ");
            Console.Write("Type the number of your option and press enter: ");

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Did you heard about the tragedy of Darth Plageues The Wise?");
                    string heard = Console.ReadLine();

                    if (heard.ToLower() == "ano")
                    {
                        Console.WriteLine("It's Treason then....... (Sheev Jumps and Kill You)");
                    }
                    else if (heard.ToLower() == "no")
                    {
                        Console.WriteLine("I thought not. It's not a story the Jedi would tell you. It's a Sith legend. Darth Plagueis was a Dark Lord of the Sith, so powerful and so wise he could use the Force to influence the midichlorians to create lifeů He had such a knowledge of" +
                            "the dark side that he could even keep the ones he cared about from dying. The dark side of the Force is a pathway to many abilities some consider to be unnatural. He became so powerfulů the only thing he was afraid of was losing his power," +
                            "which eventually, of course, he did. Unfortunately, he taught his apprentice everything he knew, then his apprentice killed him in his sleep. Ironic. He could save others from death, but not himself." +
                            "");
                    }
                    else if (heard.ToLower() == "its treason then" || heard.ToLower() == "it's treason then")
                    {
                        float playerHealth = 100;
                        float enemyHealth = 100;
                        Console.WriteLine("You challenge Palpatine to a duel. He accepts");
                        Console.WriteLine("Battle started");

                        do
                        {
                            Console.WriteLine("Players HP: {0}                       Enemy's HP: {1})", playerHealth, enemyHealth);
                            Console.WriteLine("Write (attack) to attack Palpatine!");
                            string attack = Console.ReadLine();
                            if (attack.ToLower() == "attack")
                            {
                                Console.WriteLine("You striked him for {0} damage", 20);
                                enemyHealth -= 20;
                                playerHealth -= 10;
                            }
                            else
                            {
                                Console.WriteLine("You have been hit for {0} damage", 30);
                                playerHealth -= 30;
                            }
                        } while (playerHealth > 0 || enemyHealth > 0);
                    }
                    else
                    {
                        Console.WriteLine("It's Treason then....... (Sheev Jumps and Kill You)");
                    }
                    break;

                case 2:
                    Console.WriteLine("Hello there (Senate is me and Palpatine)");
                    break;

                case 3:
                    Console.WriteLine("You left");
                    break;

                default:
                    Console.WriteLine("leave!");
                    break;
            }
            Console.ReadKey();
        }
    }
}