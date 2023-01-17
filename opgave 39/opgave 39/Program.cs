using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave26
{
    class Program
    {
        static void Main(string[] args)
        {
            string brugernavn, password;
            do
            {
                Console.WriteLine("indtast brugernavn");
                brugernavn = Console.ReadLine();
            }
            while ();

            if (brugernavn == "tec123" || brugernavn == "Tec123")
            {
                Console.WriteLine("indtast password");
                password = Console.ReadLine();

                if (password == "tec321" || password == "Tec321")
                {
                    Console.WriteLine("velkommen til systemet");
                }
            }
            else
            {
                Console.WriteLine("der blev tastet forkert. Du har ikke adgang til systemet");
            }
            Console.ReadKey();
        }
    }
}
