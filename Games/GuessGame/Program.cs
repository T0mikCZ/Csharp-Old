using System;
using System.Linq;

namespace GuessGame
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Nahodne jmena
            string[] secretWord = { "Lucian", "Tomas", "Peta", "David", "Ondra", "Sheldon" };
            string guessWord = "";

            //Deklarace prommenych aby vybraL Nahodne jmeno
            Random random = new Random();
            int index = random.Next(secretWord.Length);

            int guessCount = 0;
            int guessLimit = 3;
            int guessShow = 3;

            int choice = 0;

            while (guessWord != secretWord[index] && guessCount < guessLimit)
            {
                Console.WriteLine("Choose the option below");
                Console.WriteLine("1. Will tell the first letter of the word");
                Console.WriteLine("2. will tell the total number of letters in the word");
                Console.WriteLine("3. Will tell the last letter of the word");
                Console.WriteLine("4. Go guess the word");
                Console.Write("Choose your option: ");

                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("First letter is " + secretWord[index][0]);
                        break;

                    case 2:
                        Console.WriteLine("Total lenght of the word is {0}", secretWord[index].Length);
                        break;

                    case 3:
                        Console.WriteLine("Last letter is {0}", secretWord[index].Last());
                        break;

                    case 4:
                        while (guessWord != secretWord[index] && guessCount < guessLimit)
                        {
                            Console.Write("Guess the word: ");
                            guessWord = Console.ReadLine();
                            if (guessWord == "back")
                            {
                                break;
                            }
                            guessCount++;
                            Console.WriteLine("You have {0} guesses left", --guessShow);
                        }

                        if (guessWord == secretWord[index])
                        {
                            Console.WriteLine("You win!");
                        }
                        else if (guessWord == "back")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("You lost!");
                        }
                        break;
                }
                Console.WriteLine("Press enter");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}