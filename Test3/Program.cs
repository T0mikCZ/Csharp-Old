using System;

namespace Test3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Console.WriteLine("Peta je kokot\nDavid je kokot\n\"Tomas je borec\"");

            string value = Console.ReadLine();

            string message = (value == "peta") ? "peta je kokot" : "nevim";

            Console.WriteLine(message);
        }
    }
}