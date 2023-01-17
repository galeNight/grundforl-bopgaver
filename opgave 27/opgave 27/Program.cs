using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave_27
{
    class Program
    {
        static void Main(string[] args)
        {
            string temp;
            double antalvare, pris = 0;
            Console.Write("indtast antal købte vare ");
            temp = Console.ReadLine();
            antalvare = double.Parse(temp);

            if (temp == "4")
            {
                if (antalvare >= 4)
                {
                    pris = (antalvare * 250 * 0.05);
                    Console.WriteLine("for du 5% rabat");
                }
            }
            else
            {
                pris = (antalvare * 250);
                Console.WriteLine("du for ingen rabat");
            }
            Console.WriteLine("totalprisen er {0:N3}", pris);
            Console.ReadKey();
        }
    }
}
