using System;

namespace Cviceni10
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] poleCisel = { 1, 3, 5, 8, 10 };

            for (int i = 0; i < poleCisel.GetLength(0); i++)
            {
                Console.WriteLine(i + 1);
            }
        }
    }
}