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
            // hundrede antal terning kast 

            Random randomobj = new Random();
            int øjne, antalkast = 0, en = 0, to = 0, tre = 0, fire = 0, fem = 0, seks = 0;

            do
            {
                antalkast = antalkast + 1;
                øjne = randomobj.Next(1, 7);
                Console.WriteLine("terningen viste {0} ", øjne);

                if (øjne == 1)
                {
                    en++;
                }
                else if (øjne == 2)
                {
                    to++;
                }
                else if (øjne == 3)
                {
                    tre++;
                }
                else if (øjne == 4)
                {
                    fire++;
                }
                else if (øjne == 5)
                {
                    fem++;
                }
                else if (øjne == 6)
                {
                    seks++;
                }
            }
 

            while (antalkast <= 1000);

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("terningen lanede på 1 " + en);
            Console.WriteLine("terningen lanede på 2 " + to);
            Console.WriteLine("terningen lanede på 3 " + tre);
            Console.WriteLine("terningen lanede på 4 " + fire);
            Console.WriteLine("terningen lanede på 5 " + fem);
            Console.WriteLine("terningen lanede på 6 " + seks);


            Console.ReadKey();
        }
    }
}
