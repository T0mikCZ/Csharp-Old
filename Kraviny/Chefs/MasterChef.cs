using System;

namespace Chefs
{
    internal class MasterChef : Chef
    {
        public void MakeFishChips()
        {
            Console.WriteLine("Chef made Fish&Chips");
        }

        public void MakeHamburger()
        {
            Console.WriteLine("Chef made Hamburger");
        }

        public override void Speciality()
        {
            Console.WriteLine("Chef made Big Mac");
        }
    }
}