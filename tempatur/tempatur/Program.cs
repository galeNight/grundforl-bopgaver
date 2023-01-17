using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tempatur
{
    class Program
    {
        static void Main(string[] args)
        {
            string omrenger;
            double temp, result = 0;
            bool erberegnet = false;
            Console.WriteLine("tast c for at omringe celsius til fahrenheit");
            Console.WriteLine("tast f for at omringe fahrenhit til celsiust");

            omrenger = Console.ReadLine();

            Console.WriteLine("indtast temperatur");
            temp = Convert.ToDouble(Console.ReadLine());

            if(omrenger == "f" || omrenger == "F" )
            {
                result = (temp - 32) / 1.8;
                erberegnet = true;
            }
            else if(omrenger == "c" || omrenger == "C" )
            {
                result = (temp * 1.8) + 32;
                erberegnet = true;
            }
            else
            {
                Console.WriteLine("umuligt...");
            }
            if (erberegnet)
            {
                Console.WriteLine("tempraraturen " + temp + " " + omrenger + " svare til " + result);
            }
            Console.ReadKey();
        }
    }
}
