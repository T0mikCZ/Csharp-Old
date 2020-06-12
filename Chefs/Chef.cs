using System;

namespace Chefs
{
    internal class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("Chef made a chicken");
        }

        public void MakeSchnitzel()
        {
            Console.WriteLine("Chef made Schnitzel with cream");
        }

        public virtual void Speciality()
        {
            Console.WriteLine("Chef made Tomato Soup");
        }
    }
}