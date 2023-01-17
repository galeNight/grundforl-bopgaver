using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave_21
{
    class Program
    {
        static void Main(string[] args)
        {
            string svar = "";
            Console.WriteLine("er du medlem af en forening skriv (j) er du ikke medlemv af en forening skriv (n)");
            svar = Console.ReadLine();
            
            if (svar == "j")
            {
                Console.WriteLine("du er medlem af en forening så for du 10% rabat");
            }
            else
            {
                Console.WriteLine("er du ikke medlem af en forening for du ingen % i rabat");
            }
            Console.ReadLine();
        }
    }
}
