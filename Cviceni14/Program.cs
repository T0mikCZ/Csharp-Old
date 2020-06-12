using System;

namespace Cviceni14
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double[] poleMzdech = { 32000, 25000, 50000, 35000, 27000 };

            Console.WriteLine("Prumerna mzda: " + PrumernaMzda(poleMzdech));
            Console.WriteLine("Nejvetsi mzda: " + MaxMzda(poleMzdech));
            Console.WriteLine("Nejmensi mzda: " + MinMzda(poleMzdech));

            Console.ReadKey();
        }

        private static double PrumernaMzda(double[] mzdy)
        {
            if (mzdy.Length > 0)
            {
                double soucet = 0;
                foreach (double mzda in mzdy)
                {
                    soucet += mzda;
                }
                return soucet / mzdy.Length;
            }
            else
                return 0;
        }

        private static double MinMzda(double[] mzdy)
        {
            if (mzdy.Length > 0)
            {
                double min = mzdy[0];
                foreach (double mzda in mzdy)
                {
                    if (mzda < min)
                    {
                        min = mzda;
                    }
                }
                return min;
            }
            else
                return 0;
        }

        private static double MaxMzda(double[] mzdy)
        {
            if (mzdy.Length > 0)
            {
                double max = mzdy[0];
                foreach (double mzda in mzdy)
                {
                    if (mzda > max)
                    {
                        max = mzda;
                    }
                }
                return max;
            }
            else
                return 0;
        }
    }
}