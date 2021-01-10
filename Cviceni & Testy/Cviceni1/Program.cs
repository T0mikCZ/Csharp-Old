using System;

namespace Cviceni1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Zadejte vase jmeno: ");
            string jmeno = Console.ReadLine();
            Console.Write("Zadejte vas vek: ");
            int vek = int.Parse(Console.ReadLine());

            Console.Write("Zadejte jmeno vaseho kamarada: ");
            string jmenoKamarad = Console.ReadLine();
            Console.Write("Zadejte vek vaseho kamarada: ");
            int vekKamarad = int.Parse(Console.ReadLine());

            int vekRozdil = vek - vekKamarad;

            //alternativni vypocet
            string zpravaRozdil = jmeno + " a " + jmenoKamarad + " ma vekovy rozdil " + vekRozdil + " let.";

            Console.WriteLine("{0} a {1} ma vekovy rozdil {2} let.", jmeno, jmenoKamarad, vekRozdil);

            //alternativni vypocet
            Console.WriteLine(zpravaRozdil);
        }
    }
}