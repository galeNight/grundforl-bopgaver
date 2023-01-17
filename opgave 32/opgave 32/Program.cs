using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave_32
{
    class Program
    {
        static void Main(string[] args)
        {
            string tal;

            do
            {
                Console.WriteLine("indtast et tal");
                tal = Console.ReadLine();
            }

                while (tal != "50") ;

            Console.ReadKey();


        }
    }
}
