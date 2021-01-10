using System;

namespace Cviceni7
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] pole = new int[3];
            pole[0] = 5;
            pole[1] = 2;
            pole[2] = 4;

            Console.WriteLine("Cisel v poli:", pole.GetLength(0));

            for (int i = 0; i < pole.GetLength(0); i++)
            {
                Console.WriteLine(pole[i]);
            }
        }
    }
}