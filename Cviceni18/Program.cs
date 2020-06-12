using System;

namespace Cviceni18
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double[] znamky2 = { 3, 2, 2, 3, 4, 1, 5, 1, };
            double[] znamky3 = { 2, 5, 4, 3, 4, 3, 2, 2, };
            double[] znamky4 = { 3, 5, 2, 5, 4, 2, 5, 1, };
            double[] znamky1 = { 1, 5, 2, 3, 4, 1, 1, 2, };

            PorovnaniZnamek("Tomas", znamky1, "David", znamky2);
            PorovnaniZnamek("Filip", znamky3, "Matous", znamky4);

            Console.ReadKey();
        }

        private static void PorovnaniZnamek(string jmeno1, double[] znamky1, string jmeno2, double[] znamky2)
        {
            double soucet1 = 0;

            double soucet2 = 0;

            for (int i = 0; i < znamky1.GetLength(0); i++)
            {
                soucet1 += znamky1[i];
            }

            for (int i = 0; i < znamky2.GetLength(0); i++)
            {
                soucet2 += znamky2[i];
            }

            Console.WriteLine("Zak {0}, Prumer: {1}", jmeno1, soucet1 / znamky1.Length);
            Console.WriteLine("Zak {0}, Prumer: {1}", jmeno2, soucet2 / znamky2.Length);
        }
    }
}