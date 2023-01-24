using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extra_opgave_E
{
    class Program
    {
        static void Main(string[] args)
        {
            string temp;
            double celcius, fahrenheit;
            Console.WriteLine("indtast celcius med + eller - før tallet");
            temp=Console.ReadLine();
            celcius = double.Parse(temp);
            fahrenheit = (celcius * 1.8) + 32;
            if (celcius > 35)
            {
                Console.WriteLine("er det for varmt");
            }
            else if (celcius <= 35 && celcius >= 25)
            {
                Console.WriteLine("det er okay");
            }
            else
            {
                Console.WriteLine("er det or koldt");
            }
            Console.ReadKey();
        }
    }
}
