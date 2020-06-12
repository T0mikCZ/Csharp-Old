using System;

namespace Test4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string name1, name2, location1, location2, action1, action2, action3;

            Console.Write("Enter a name: ");
            name1 = Console.ReadLine();
            Console.Write("Enter another name: ");
            name2 = Console.ReadLine();
            Console.Write("Enter a location: ");
            location1 = Console.ReadLine();
            Console.Write("Enter another location: ");
            location2 = Console.ReadLine();
            Console.Write("Enter an action: ");
            action1 = Console.ReadLine();
            Console.Write("Enter another action: ");
            action2 = Console.ReadLine();
            Console.Write("Enter another action: ");
            action3 = Console.ReadLine();

            Console.WriteLine("{0} lives in {1}.", name1, location1);
            Console.WriteLine("{0} loves {1}.", name1, location1);
            Console.WriteLine("{0} lives in {1}.", name2, location2);
            Console.WriteLine("{0} loves {1}.", name2, location2);
            Console.WriteLine("{0} and {1} met.", name1, name2);
            Console.WriteLine("{0} and {1} want to {2}.", name1, name2, action1);
            Console.WriteLine("{0} and {1} want to {2}.", name1, name2, action2);
            Console.WriteLine("{0} and {1} want to {2}.", name1, name2, action3);
            Console.WriteLine("{0} and {1} {2}, {3} and {4}.", name1, name2, action1, action2, action3);

            Console.ReadKey();
        }
    }
}