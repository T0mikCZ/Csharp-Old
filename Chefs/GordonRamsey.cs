using System;

namespace Chefs
{
    internal class GordonRamsey : Chef
    {
        public void MakeLambSauce()
        {
            Console.WriteLine("Gordon made Lamb Sauce");
        }

        public GordonRamsey()
        {
            Console.WriteLine("Where is the Lamb Sauce!!!");
            Console.WriteLine("What is this bullshit");
        }

        public override void Speciality()
        {
            Console.WriteLine("Gordon made Wellington's beef");
        }
    }
}