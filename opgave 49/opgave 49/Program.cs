using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave_49
{
    class Program
    {
        static void Main(string[] args)
        {
            string tekst, tekst1 = "";

            Console.WriteLine("indtast en tekst");
            tekst = Console.ReadLine();

            for (int i = tekst.Length-1; i >= 0; i--)
            {
                tekst1 += tekst.Substring(i, 1);
            }
            Console.WriteLine(tekst1);
            Console.ReadKey();
        }
    }
}
