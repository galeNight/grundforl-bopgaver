using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extra_opgave_F
{
    class Program
    {
        static void Main(string[] args)
        {
            int karakter;
            Console.WriteLine("indtast hvilken karakter du har fået");
            karakter = Convert.ToInt32(Console.ReadLine());
            if (karakter >= 02 && karakter <= 12)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("tillykke då har bestået");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("øv,prøv igen");
            }
            Console.ReadKey();
        }
    }
}
