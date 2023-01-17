using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave_23
{
    class Program
    {
        static void Main(string[] args)
        {
            string størrelse;
            double pris = 0, totalpris = 0, antal = 0, rabat = 0;

            Console.WriteLine("vælg hvilken størlse s for small, m for medium, l for large");
            størrelse = Console.ReadLine().ToUpper();

            Console.WriteLine("indtast hvor mange du vil købe");
            antal = Convert.ToInt16(Console.ReadLine());

            if (størrelse == "S")
            {
                pris = antal * 120;
                rabat = pris * 0.05 / 100;
                if (antal <= 10)
                {
                    totalpris = pris - rabat;
                }
                else
                {
                    totalpris = pris;
                }
            }

            if (størrelse == "M")
            {
                pris = antal * 160;
                rabat = antal * 0.05 / 100;
                if(antal <= 10)
                {
                    totalpris = pris - rabat;
                }
                else
                {
                    totalpris = pris;
                }
            }
            
            if (størrelse == "L")
            {
                pris = antal * 185;
                rabat = pris * 0.05 / 100;
                if(antal <= 10)
                {
                    totalpris = pris - rabat;
                }
                else
                {
                    totalpris = pris;
                }
            }

            Console.WriteLine("størrelse " + størrelse);
            Console.WriteLine("antal " + antal);
            Console.WriteLine("totalpris " + pris + "kr");
            if (antal >= 10)
            {
              Console.WriteLine("rabatten er 5% " + rabat);
            }
            Console.WriteLine("totalprisen er " + totalpris);
            Console.ReadKey();

        }
    }
}
