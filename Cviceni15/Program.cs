using System;

namespace Cviceni15
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] jmena = { "Pavel", "Tom", "David", "Giorno" };

            Console.WriteLine(ExistujeJmeno(jmena, "david"));
            Console.WriteLine(ExistujeJmeno(jmena, "dav"));
            Console.WriteLine(ExistujeJmeno(jmena, "asdasda"));
            Console.WriteLine(ExistujeJmeno(jmena, "Giorno"));

            Console.ReadKey();
        }

        private static bool ExistujeJmeno(string[] jmena, string hledaneJmeno)
        {
            foreach (string jmeno in jmena)
            {
                if (jmeno.ToLower() == hledaneJmeno.ToLower())
                    return true;
            }
            return false;
        }
    }
}