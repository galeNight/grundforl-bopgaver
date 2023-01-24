using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extra_opgave_H
{
    class Program
    {
        static void Main(string[] args)
        {
                string indput;
                Console.WriteLine("billetpriser på museet");
                Console.WriteLine("indtast s for studerende");
                Console.WriteLine("indtats v for voksen");
                Console.WriteLine("indtast p for pensionist");
                indput = Console.ReadLine();
                Console.Clear();
            switch (indput)
            {
                case "s":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("billet for studerende 30 kr");
                    Console.ResetColor();
                    break;
                case "v":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("billet for voksen 85 kr");
                    Console.ResetColor();
                    break;
                case "p":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("billet for pensionist 25 kr");
                    Console.ResetColor();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("forkert indtastning prøv igen");
                    Console.ResetColor();
                    return;
            }
            Console.ReadKey();
        }
    }
}
