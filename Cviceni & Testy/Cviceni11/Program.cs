using System;
using System.Linq;

namespace Cviceni11
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] poleCisel = { 1, 3, 5, 8, 10 };

            for (int i = 0; i < poleCisel.Length; i++)
            {
                Console.WriteLine(poleCisel[i]);
            }

            poleCisel.Reverse();

            for (int j = 0; j < poleCisel.Length; j++)
            {
                Console.WriteLine(poleCisel[j]);
            }
            Console.ReadKey();
        }
    }
}