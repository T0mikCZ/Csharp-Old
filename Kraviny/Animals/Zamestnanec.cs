using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Zamestnanec
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Wage { get; set; }

        public Zamestnanec(string name, int age, decimal wage)
        {
            Name = name;
            Age = age;
            Wage = wage;
        }

        public void VypisPopis()
        {
            Console.WriteLine("\nVYPIS ZAMESTANCE\n");
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Wage: {0}", Wage);
        }
    }
}
