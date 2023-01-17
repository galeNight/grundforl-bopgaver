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

            Console.WriteLine("tryk på tasten 1 for at vise billeder af hunde");
            Console.WriteLine("tryk på tasten 2 for at vise billeder af katte");
            Console.WriteLine("tryk på tasten 3 fo at vise billeder af fiskk");
            tast = Console.ReadLine();

            switch (tast)
            {
                case "1":
                    Console.WriteLine("her er dine billeder af hunde");
                    break;

                case "2":
                    Console.WriteLine("her er dine billeder af katte");
                    break;
                case "3":
                    Console.WriteLine("her er dine billeder af fisk");
                    break;
                default:
                    Console.WriteLine("du har ikke  trykket på 1, 2, eller 3 ingen billeder til dig ");
                    break;

            }
            Console.ReadKey();
        }
    }
}
