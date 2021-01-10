using System;

namespace Chefs
{
    internal class ItalianChef : Chef
    {
        public void MakePasta()
        {
            Console.WriteLine("Chef made Pasta");
        }

        public void MakeSpaghetti()
        {
            Console.WriteLine("Chef made Spaghetti");
        }

        public override void Speciality()
        {
            Console.WriteLine("Chef made Spaghetti with meat balls and cream");
        }
    }
}