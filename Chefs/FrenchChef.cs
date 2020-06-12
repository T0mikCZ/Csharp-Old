using System;

namespace Chefs
{
    internal class FrenchChef : Chef
    {
        public void MakeFrogSoup()
        {
            Console.WriteLine("Chef made Frog Soup");
        }

        public void MakeBaghet()
        {
            Console.WriteLine("Chef Made Baghet");
        }

        public override void Speciality()
        {
            Console.WriteLine("Chef made Baghet with Frogs");
        }
    }
}