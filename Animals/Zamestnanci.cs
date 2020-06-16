using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Zamestnanci
    {
        private List<Zamestnanec> zamestnanci;
        public Zamestnanci()
        {
            zamestnanci = new List<Zamestnanec>();
        }

        public void PridatZvire()
        {
            Console.WriteLine("PRIDANI ZVIRETE\n");
            Console.Write("Zadejte jmeno zvirete: ");
            string name = Console.ReadLine();

            Console.Write("Zadejte vek zvirete: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Zadejte vahu zvirete: ");
            decimal wage = Convert.ToDecimal(Console.ReadLine());

            Zamestnanec zamestnanec = new Zamestnanec(name, age, wage);

            zamestnanci.Add(zamestnanec);
        }

        public void VypisZvirat()
        {
            Console.WriteLine("\nVYPIS ZVIRAT\n");
            foreach (Zamestnanec zamestnanec in zamestnanci)
            {
                zamestnanec.VypisPopis();
            }
        }

        public void OdstranitZvire()
        {
            int smazatIndex = VybratIndexZvirete();
            zamestnanci.RemoveAt(smazatIndex);

            Console.WriteLine("Zvire smazano");
        }

        public void UpravitZvire()
        {
            int upravitIndex = VybratIndexZvirete();
            string moznost = "";
            do
            {

                Console.WriteLine("Co chcete upravit?");
                Console.WriteLine("1. JMENO");
                Console.WriteLine("2. VEK");
                Console.WriteLine("3. VAHU");
                Console.WriteLine("4. UKONCIT UPRAVY");

                Console.Write("\nVyberte moznost: ");
                moznost = Console.ReadLine();

                switch (moznost)
                {
                    case "1":
                        Console.Write("Upravit Jmeno: ");
                        zamestnanci[upravitIndex].Name = Console.ReadLine();
                        break;
                    case "2":
                        Console.Write("Upravit Vek: ");
                        zamestnanci[upravitIndex].Age = Convert.ToInt32(Console.ReadLine());
                        break;
                    case "3":
                        Console.Write("Upravit Mzdu: ");
                        zamestnanci[upravitIndex].Wage = Convert.ToDecimal(Console.ReadLine());
                        break;
                }
                Console.WriteLine("Zvire upraveno");

            } while (moznost != "4");

        }

        private int VybratIndexZvirete()
        {
            Console.WriteLine("VYPIS ZVIRAT");

            for (int i = 0; i < zamestnanci.Count; i++)
            {
                Console.WriteLine("{0}. zvire: ", i + 1);
                Console.WriteLine("     JMENO: {0}", zamestnanci[i].Name);
                Console.WriteLine("     VEK:   {0}", zamestnanci[i].Age);

            }
            Console.Write("NAPISTE CISLO ZVIRETE ");
            int vybranyIndex = Convert.ToInt32(Console.ReadLine()) - 1;

            if (vybranyIndex >= 0 && vybranyIndex < zamestnanci.Count)
                return vybranyIndex;
            else
            {
                Console.WriteLine("Spatne Cislo");
                return -1;
            }
        }
    }
}
