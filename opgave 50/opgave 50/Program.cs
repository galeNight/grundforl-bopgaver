using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave_50
{
    class Program
    {
        static void Main(string[] args)
        {
            string tekst = "";

            Console.WriteLine("indtast tekst");
            tekst = Console.ReadLine();

            if (tekst.Contains("hej"))
            {
                Console.WriteLine("teksten indholder ordet (hej)");
            }
            else
            {
                Console.WriteLine("teksten indholder ikke ordet (hej)");
            }
            Console.ReadKey();
        }
    }
}
