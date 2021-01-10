using System;

namespace Chefs
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Chef chef1 = new Chef();
            ItalianChef italianChef1 = new ItalianChef();
            FrenchChef frenchChef1 = new FrenchChef();
            MasterChef masterChef1 = new MasterChef();
            GordonRamsey gordonRamsey = new GordonRamsey();

            gordonRamsey.MakeLambSauce();
            gordonRamsey.Speciality();

            masterChef1.MakeFishChips();
            masterChef1.MakeHamburger();
            masterChef1.Speciality();

            frenchChef1.MakeFrogSoup();
            frenchChef1.MakeBaghet();
            frenchChef1.Speciality();

            italianChef1.MakeChicken();
            italianChef1.MakeSpaghetti();
            italianChef1.Speciality();

            chef1.MakeChicken();
            chef1.MakeSchnitzel();
            chef1.Speciality();

            Console.ReadKey();
        }
    }
}