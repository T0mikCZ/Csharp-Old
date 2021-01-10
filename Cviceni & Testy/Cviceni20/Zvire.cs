using System;

namespace Cviceni20
{
    internal class Zvire
    {
        public string Nazev { get; set; }
        public int Vek { get; set; }
        public double Vaha { get; set; }

        public Zvire(string nazev, int vek, double vaha)
        {
            Nazev = nazev;
            Vek = vek;
            Vaha = vaha;
        }

        public void VypisPopis()
        {
            Console.WriteLine("Jmeno zvirete: {0}", Nazev);
            Console.WriteLine("Vek zvirete: {0}", Vek);
            Console.WriteLine("Vaha zvirete: {0}", Vaha);
        }
    }
}