using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave_34
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomobj = new Random();
            int øjne, antalkast = 0;
            do
            {
                antalkast = antalkast + 1;
                øjne = randomobj.Next(1, 7);
                Console.WriteLine("terningen viste {0} ", øjne);
            }

            while (antalkast <= 100);
            Console.ReadKey();
        }
    }
}
