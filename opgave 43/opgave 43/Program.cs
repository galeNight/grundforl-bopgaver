using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave_40
{
    class Program
    {
        static void Main(string[] args)
        {
            string tast;
            int antal;
            double pris1 = 1999, pris2 = 1499, pris3 = 1599, pris4 = 1499, pris5 = 1599, total = 0;

            Console.WriteLine("Coctails på Fustage\n");
            Console.WriteLine("tast [1] mojito - 6,5% 18 liter");
            Console.WriteLine("tast [2] Dark’n & Stormy – 6,0% 18 liter");
            Console.WriteLine("tast [3] Vodka Redbull – 6,5% 18 liter");
            Console.WriteLine("tast [4] Sex on the Beach – 6,5% 18 liter");
            Console.WriteLine("tast [5] Long Island Iced Tea 8% 18 liter");
            Console.WriteLine("tryk på tasten 9 for at afslutte program\n");
            tast = Console.ReadLine();

            while (tast != "9")
            { 

                if (tast == "1")
                {
                    Console.WriteLine("mojito - 6,5 alcohold % pris 1999 kr for 18 liter");
                    Console.Write("hvor mange til du købe ");
                    antal = Convert.ToInt16(Console.Read());
                    tast = Console.ReadLine();

                    total = total + pris1 * antal;
                    Console.WriteLine("prisen er {0} kr\n", total);
                }
            else if (tast == "2")
                {
                    Console.WriteLine("Dark’n & Stormy – 6,0% alcohold % pris 1499 kr for 18 liter ");
                    Console.Write("hvor mange til du købe ");
                    antal = Convert.ToInt16(Console.Read());
                    tast = Console.ReadLine();

                    total = total + pris2 * antal;
                    Console.WriteLine("prisen er {0} kr\n", total);
                }
            else if (tast == "3")
                {
                    Console.WriteLine("Vodka Redbull – 6,5% alcohold % pris 1599 kr for 18 liter");
                    Console.Write("hvor mange til du købe ");
                    antal = Convert.ToInt16(Console.Read());
                    tast = Console.ReadLine();

                    total = total + pris3 * antal;
                    Console.WriteLine("prisen er {0} kr\n", total);
                }
            else if (tast == "4")
                {
                    Console.WriteLine("Sex on the Beach – 6,5 alcohold % pris 1499 kr 18 liter");
                    Console.Write("hvor mange til du købe ");
                    antal = Convert.ToInt16(Console.Read());
                    tast = Console.ReadLine();

                    total = total + pris4 * antal;
                    Console.WriteLine("prisen er {0} kr\n", total);
                }
            else if (tast== "5")
                {
                    Console.WriteLine("Long Island Iced Tea 8 alcohold % pris 1599 kr for 18 liter");
                    Console.Write("hvor mange til du købe ");
                    antal = Convert.ToInt16(Console.Read());
                    tast = Console.ReadLine();

                    total = total + pris5 * antal;
                    Console.WriteLine("prisen er {0} kr\n", total);
                }
                else
                {
                    Console.WriteLine("ugyldig tast. tast 1, 2, 3, 4 eller 5 for at fortsætte\n");
                    Console.WriteLine("eller tast 9 for at afslutte");
                    tast = Console.ReadLine();
                }
                Console.ReadKey();
            }
            
        }
    }
}
