using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave_48
{
    class Program
    {
        static void Main(string[] args)
        {
            string tekst, tekst1 = "";

            Console.WriteLine("indtast en tekst");
            tekst = Console.ReadLine();

            for(int i = 0; i < tekst.Length; i++)
            {
                if (tekst.Substring(i, 1) != " ") 
                {
                   tekst1 += tekst.Substring(i, 1);
                }
            }
            Console.WriteLine(tekst1);
            Console.ReadKey();
        }
    }
}
