using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("beringing af arial (a) eller omkreds af cirkel (o)");
            string svar = Console.ReadLine();

            if (svar == "a")
            {
                Console.WriteLine("indtast radius");
                double radius = Convert.ToDouble(Console.ReadLine());
                double arial = Math.PI * radius * radius;
                Console.WriteLine("arial af cirklen er " + arial);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("indtast radius");
                double radius = Convert.ToDouble(Console.ReadLine());
                double omkreds = 2 * radius * Math.PI;
                Console.WriteLine("omresen af cirklen er " + omkreds);
                Console.ReadKey();
            }
        }
    }
}
