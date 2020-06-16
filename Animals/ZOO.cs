using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class ZOO
    {
        private List<Zvire> zvirata;
        public ZOO()
        {
            zvirata = new List<Zvire>();
        }

        public void PridatZvire()
        {
            Console.WriteLine("PRIDANI ZVIRETE\n");
            Console.Write("Zadejte jmeno zvirete: ");
            string name = Console.ReadLine();

            Console.Write("Zadejte vek zvirete: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Zadejte vahu zvirete: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            Zvire zvire = new Zvire(name, age, weight);

            zvirata.Add(zvire);
        }

        public void VypisZvirat()
        {
            Console.WriteLine("\nVYPIS ZVIRAT\n");
            foreach (Zvire zvire in zvirata)
            {
                zvire.VypisPopis();
            }
        }

        public void OdstranitZvire()
        {
            Console.WriteLine("VYPIS ZVIRAT PRO SMAZANI");

            for (int i = 0; i < zvirata.Count; i++)
            {
                Console.WriteLine("{0}. zvire: ", i + 1);
                Console.WriteLine("     JMENO: {0}", zvirata[i].Name);
                Console.WriteLine("     VEK:   {0}", zvirata[i].Age);
                Console.WriteLine("     VAHA:  {0}", zvirata[i].Weight);

            }
            Console.Write("NAPISTE CISLO ZVIRETE PRO SMAZANI: ");
            int vybranyIndex = Convert.ToInt32(Console.ReadLine()) - 1;

            zvirata.RemoveAt(vybranyIndex);

            Console.WriteLine("Zvire smazano");
        }

    }
}
