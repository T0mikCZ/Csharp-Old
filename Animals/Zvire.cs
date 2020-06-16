using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Zvire
    {
        public string Name { get; set; }
        public int Age{ get; set; }
        public double Weight { get; set; }

        public Zvire(string name, int age, double weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }

        public void VypisPopis()
        {
            Console.WriteLine("VYPIS ZVIRETE");
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Weight: {0}", Weight);
        }

    }
}
