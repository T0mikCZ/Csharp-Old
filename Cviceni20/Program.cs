using System;

namespace Cviceni20
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ZOO zoo = new ZOO();

            zoo.PridatZvire();
            zoo.PridatZvire();

            zoo.VypisZvirat();
            Console.ReadKey();
        }
    }
}