using System;

namespace Cviceni3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //TODO Pozdeji predelat. Je to na nic DONE
            //TODO Pridat if kdyz zada mezeru jako prihlasovaci jmeno nebo heslo DONE

            const string adminLogin = "admin";
            const string adminPass = "csharp";

            Console.Write("Zadejte sve prihlasovaci jmeno: ");
            string login = Console.ReadLine();
            Console.Write("Zadejte sve prihlasovaci heslo: ");
            string pass = Console.ReadLine();

            if (login == adminLogin && pass == adminPass)
            {
                Console.WriteLine("Jste prihlasen jako admin");
            }
            else if (login == adminLogin && pass != adminPass)
            {
                Console.WriteLine("Spatne zadane admin heslo!");
            }
            else if (login != adminLogin && pass == adminPass)
            {
                Console.WriteLine("Spatne zadane admin jmeno!");
            }
            else if (login == " " || pass == " ")
            {
                Console.WriteLine("Heslo a jmeno nemuze pouze obsahovat mezery");
            }
            else if (login == "" || pass == " ")
            {
                Console.WriteLine("Heslo a jmeno nemuze pouze obsahovat mezery");
            }
            else if (login == " " || pass == "")
            {
                Console.WriteLine("Heslo a jmeno nemuze pouze obsahovat mezery");
            }
            else
            {
                Console.WriteLine("Jste prihlasen");
            }
        }
    }
}