using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni20
{
    class Zvire
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
