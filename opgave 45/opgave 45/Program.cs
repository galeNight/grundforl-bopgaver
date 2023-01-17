using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave_45
{
    class Program
    {
        static void Main(string[] args)
        {
            string tast="";
            int antal, pris1 = 190, pris2 = 250, pris3 = 280, pris4 = 320, total=0;

            while( tast != "slut")
            {
                Console.WriteLine("vælg hvilken zone du vil side");
                Console.WriteLine("blå\nrød\ngul\npink\n");
                tast = Console.ReadLine();
                Console.Clear();

                switch (tast)
                {
                    case "blå":
                        Console.WriteLine("du har valg blå zone billet som koster 190 kr\nhvor mange billeter vil du købe");
                        antal = Convert.ToInt16(Console.ReadLine());

                        total = total + pris1 * antal;
                        Console.WriteLine("prisen i alt er {0} kr\n",total);
                        break;
                    case "rød":
                        Console.WriteLine("du har valg rød zone billet som koster 250 kr\nhvor mange billeter vil du købe");
                        antal = Convert.ToInt16(Console.ReadLine());

                        total = total + pris2 * antal;
                        Console.WriteLine("prisen i alt er {0} kr\n", total);
                        break;
                    case "gul":
                        Console.WriteLine("du har valg gul zone billet som koster 280 kr\nhvor mange billeter vil du købe");
                        antal = Convert.ToInt16(Console.ReadLine());

                        total = total + pris3 * antal;
                        Console.WriteLine("prisen i alt er {0} kr\n", total);
                        break;
                    case "pink":
                        Console.WriteLine("du har valg pink zone billet som koster 320 kr\nhvor mange billeter vil du købe");
                        antal = Convert.ToInt16(Console.ReadLine());

                        total = total + pris4 * antal;
                        Console.WriteLine("prisen i alt er {0} kr\n", total);
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
