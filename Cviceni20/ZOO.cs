using System;
using System.Collections.Generic;
using System.Linq;

namespace Cviceni20
{
    internal class ZOO
    {
        private List<Zvire> zvirata;

        public ZOO()
        {
            zvirata = new List<Zvire>();
        }

        public void PridatZvire()
        {
            Console.WriteLine("ZADANI NOVEHO ZVIRETE");
            Console.Write("Nazev: ");
            string nazev = Console.ReadLine();
            Console.Write("Vek: ");
            int vek = Convert.ToInt32(Console.ReadLine());
            Console.Write("Vaha: ");
            double vaha = Convert.ToDouble(Console.ReadLine());

            Zvire zvire = new Zvire(nazev, vek, vaha);

            zvirata.Add(zvire);
        }

        public void VypisZvirat()
        {
            Console.WriteLine("\nVYPIS ZVIRAT \n");
            Console.WriteLine("POCET ZVIRAT: {0}\n", zvirata.Count());
            int i = 1;
            foreach (Zvire zvire in zvirata)
            {
                Console.WriteLine("{0}. Zvire", i);
                zvire.VypisPopis();
                i++;
            }
        }
    }
}