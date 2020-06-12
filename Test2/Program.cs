using System;
using System.IO;

namespace Test2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ulong cislo1 = 100000000000000;
            string path = @"C:\Users\Tomyk\source\repos\1Program\Test2\bin\Debug\netcoreapp3.1\Test2.txt";

            using (StreamWriter sw = File.CreateText(path))
            {
                for (ulong i = 0; i < cislo1; i++)
                {
                    Console.WriteLine("Fortnite");
                }
            }
        }
    }
}