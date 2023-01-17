using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave_47
{
    class Program
    {
        static void Main(string[] args)
        {
            // > støre end
            // < mindre end
            string t1,t2;

            Console.Write("indtast tekst nr 1 \n");
            t1 = Console.ReadLine();
            Console.Write("indtast tekst nr 2 \n");
            t2 = Console.ReadLine();

            int t1a = t1.Length, t2a = t2.Length;

            if (t1a > t2a)
            {
                Console.WriteLine("tekst nr 1 er støre med {0} bogstaver end tekst nr 2 som er med {1} bogstaver",t1a,t2a);
            }
            else if(t1a < t2a)
            {
                Console.WriteLine("tekst nr 2 er støre med {0} bogstaver end tekst nr 1 som er med {1} bogstaver",t2a,t1a);
            }
            else
            {
                Console.WriteLine("tekst 1 har {0} bogstaver lige som tekst 2 {1}",t1a,t2a);
            }
            Console.ReadKey();
        }
    }
}
