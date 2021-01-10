using System;

namespace Cracker
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int password = 15646;
            int guess = 0;

            for (guess = 0; guess <= password; guess++)
            {
                Console.WriteLine(guess);
            }

            Console.WriteLine();

            if (guess == password)
                Console.WriteLine("Password found: {0}", guess);
            else
                Console.WriteLine("Password not found");

            Console.ReadKey();
        }
    }
}