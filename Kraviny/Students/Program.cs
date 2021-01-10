using System;

namespace Students
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Student student1 = new Student("David", "Programmer", 3.2);
            Student student2 = new Student("Filip", "Troska", 0.0001);

            Console.ReadKey();
        }
    }
}