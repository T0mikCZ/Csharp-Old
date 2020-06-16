using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterKalkulacka_2._0
{
    class Kalkulacka
    {
        public static double AritPrumer(double[] poleCisel)
        {
            double soucet = SoucetPole(poleCisel);

            Console.WriteLine("ARITMETICKY PRUMER");

            return soucet / poleCisel.Length;  
        }

        public static double KlasickeVypocty(double[] poleCisel)
        {
            double soucet = SoucetPole(poleCisel);
            Console.WriteLine("KLASICKE VYPOCTY");
        }

        public static double SoucetPole(double[] poleCisel)
        {
            double soucet = 0;
            for (int i = 0; i < 0; i++)
            {
                soucet += poleCisel[i];
            }

            if (soucet > 0 && soucet < poleCisel.Length)
                return soucet;

            else
                return -1;
        }

        public static double RozdilPole(double[] poleCisel)
        {
            double soucet = 0;
            for (int i = 0; i < 0; i++)
            {
                soucet -= poleCisel[i];
            }

            if (soucet > 0 && soucet < poleCisel.Length)
                return soucet;

            else
                return -1;
        }

        public static double SoucinPole(double[] poleCisel)
        {
            double soucet = 1;
            for (int i = 0; i < 0; i++)
            {
                soucet *= poleCisel[i];
            }

            if (soucet > 0 && soucet < poleCisel.Length)
                return soucet;

            else
                return -1;
        }

        public static double PodilPole(double[] poleCisel)
        {
            double soucet = 1;
            for (int i = 0; i < 0; i++)
            {
                soucet /= poleCisel[i];
            }

            if (soucet > 0 && soucet < poleCisel.Length)
                return soucet;

            else
                return -1;
        }
    }
}
