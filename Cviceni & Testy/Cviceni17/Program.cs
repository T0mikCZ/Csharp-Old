using System;

namespace Cviceni17
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(ObsahCtverce(10));
            Console.WriteLine(ObsahObdelniku(10, 5));

            Console.ReadKey();
        }

        private static int ObsahCtverce(int velikost)
        {
            return velikost * velikost;
        }

        private static int ObsahObdelniku(int velikostA, int velikostB)
        {
            return velikostA * velikostB;
        }
    }
}