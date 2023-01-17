using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave_40
{
    class Program
    {
        static void Main(string[] args)
        {
            string tast;

            Console.WriteLine("tast 1, 2 eller 3 på tasterturet");
            tast = Console.ReadLine();

            switch (tast)
            {
                case "1":
                    Console.WriteLine("du har trykket på 1 tast return");
                    break;

                case "2":
                    Console.WriteLine("du har trykket på 2 tast return");
                    break;
                case "3":
                    Console.WriteLine("du har trykket på 3 tast return");
                    break;
                default:
                    Console.WriteLine("du har ikke  trykket på 1, 2,eller 3 tast return");
                    break;

            }
            Console.ReadKey();
        }
    }
}
