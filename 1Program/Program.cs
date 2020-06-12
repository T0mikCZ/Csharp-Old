using System;

namespace _1Program
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*
            // >Cela cisla<

            //Deklarace celych cisel
            int firstNumber = 5;
            int secondNumber = 10;

            //Soucet celych cisel
            int total = firstNumber + secondNumber;

            //Vypis na konzoli
            Console.WriteLine("Total number = {0}", total);

            // >Desetinna cisla<

            //Deklarace desetinnich cisel
            float firstDecimalNumber = 1.785464f;
            float secondDecimalNumber = 11.255555f;

            //Soucet desetinnich cisel
            float totalDecimal = firstDecimalNumber + secondDecimalNumber;

            //Vypis na konzoli
            Console.WriteLine("Total decimal number = {0}", totalDecimal);

            // >Mix celych a desetinnich cisel<

            //Deklarace cisel
            int fullNumber = 1;
            float decimalNumber = 5.75f;

            //Soucet cisel
            float totalMix = fullNumber + decimalNumber;

            //Vypis na konzoli
            Console.WriteLine("Total mix number = {0}", totalMix);

            // >Stringy<

            //Deklarace retezcu
            string name = "Karel";
            string surname = "Seno";
            string birthDate = "1995.7.5";

            //Vypis na konzoli
            Console.WriteLine("Jmeno: {0}\nPrijmeni: {1}\nDatum Narozeni {2}", name, surname, birthDate);
            Console.WriteLine("{0}\t{1}\t{2}", name, surname, birthDate);
            */

            // STAR WARS PALPATINE//

            //TODO predelat az budu mit vice zkusenosti
            Console.Title = "Hello There";

            void MainMenu()
            {
                Console.WriteLine("Hlavni Menu");
                Console.WriteLine("1. Be Senate");
                Console.WriteLine("2. Who is Senate");
                Console.WriteLine("3. Exit the Senate");
                Console.Write("Type the number of your option and press enter: ");
            }
            MainMenu();
            int moznost = int.Parse(Console.ReadLine());

            if (moznost == 1)
            {
                Console.WriteLine("Did you heard about tragedy of Darth Plageues The Wise?");
                Console.WriteLine("Yes or No?");
                string knows = Console.ReadLine();

                if (knows == "Yes" || knows == "yes")
                {
                    Console.WriteLine("It's Treason then....... (Sheev Jumps and Kill You)");
                }
                else if (knows == "No" || knows == "no")
                {
                    Console.WriteLine("Sheev tells you:");
                    Console.WriteLine("I thought not. It's not a story the Jedi would tell you. It's a Sith legend.");
                    Console.WriteLine("It's a Sith legend. Darth Plagueis was a Dark Lord of the Sith,");
                    Console.WriteLine("so powerful and so wise he could use the Force to influence the midichlorians to create life");
                    Console.WriteLine("He had such a knowledge of the dark side that he could even keep the ones he cared about from dying. The dark side of the Force is a pathway to many abilities some consider to be unnatural.");
                    Console.WriteLine("He became so powerfulů the only thing he was afraid of was losing his power, which eventually, of course, he did. Unfortunately, he taught his apprentice everything he knew, then his apprentice killed him in his sleep. Ironic. He could save others from death, but not himself.");
                    Console.ReadLine();
                    Console.WriteLine("Sheev then jumps and kills you");
                }
            }
            else if (moznost == 2)
            {
                Console.WriteLine("Hello There! [Senate is Me and Palpatine]");
                Console.ReadLine();

                //TODO Pridat kod ktery te pri odpovezeni vezme do menu
            }
            else if (moznost == 3)
            {
                Console.WriteLine("Leave Senate");
                Console.ReadLine();
                Console.WriteLine("You Left");
            }

            Console.ReadKey();
            //TODO Pridat lucianuv secret
            //TODO pridat vice moznosti
        }
    }
}