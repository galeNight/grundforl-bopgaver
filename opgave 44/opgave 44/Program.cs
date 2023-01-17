using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave_44
{
    class Program
    {
        static void Main(string[] args)
        {
            string svar;
            double længden, bredden, arial,radius;

            Console.WriteLine("vælg beragning arial af rettangel [r]]");
            Console.WriteLine("vælg berining arial af cirkel tast [c]");
            Console.WriteLine("vælg beraning arial af  retvinkelt trekant tryk [t]");
            Console.WriteLine("exit for at afslutte programmet");
            Console.WriteLine("indtats [r], [c] eller [t] exit [e]");
            svar = Console.ReadLine();
            Console.Clear();
            switch (svar)
            {
                case "r": 
                    Console.Write("skriv længden på retangelen ");
                    længden = Convert.ToDouble(Console.ReadLine());
                    Console.Write("skriv bredden på retangelen ");
                    bredden = Convert.ToDouble(Console.ReadLine());
                    arial = længden * bredden;
                    Console.WriteLine("arialet af retangelen {0} ", arial + "cm²");
                 break;

                case "c":
                    Console.Write(" skriv radius på cirklen ");
                    radius = Convert.ToDouble(Console.Read());
                    arial = Math.Round(Math.PI * radius * radius, 2);
                    Console.WriteLine("arialet af cirklen er {0} ", arial + "cm²");
                    break;

                case "t":
                    Console.Write("skiv længden ");
                    længden = Convert.ToDouble(Console.ReadLine());
                    Console.Write("skriv bredden ");
                    bredden = Convert.ToDouble(Console.ReadLine());
                    arial = længden * bredden / 2;
                    Console.WriteLine("arialet af den retvinkel trekkat er {0} ", arial + "cm²");
                    break;

                case "e":
                    Console.WriteLine("tryk enter for at confimere at du vil afslutte programmet");
                    break;
            }
            Console.ReadKey();
        }
        }
    }
