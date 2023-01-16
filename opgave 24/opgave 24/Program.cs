using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave_24
{
    class Program
    {
        static void Main(string[] args)
        {
            string værelsetype;
            int overnatninger, antalværelser;
            double totalpris, euro;

            Console.WriteLine("velkommen til hotel");
            Console.WriteLine("vi tilbyder enkeltværelse som koster 765 kr dkk eller 102,87 Euro ");
            Console.WriteLine("vi tilbyder dobbeltværelse som koster 980 kr dkk eller 131,78 Euro ");
            Console.WriteLine("vi tilbyder familieværelser som koster 1250 kr dkk eller 168,09 Euro ");

            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.WriteLine("for at vælge hvilken værelse du vil bestille skrive enkeltværelse, doubbleværelse, familieværelse");
            Console.Write("vælg hvilken hvilken type værelse du vil bestile ");
            værelsetype = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            if (værelsetype == "enkeltværelse" || værelsetype == "Enkeltværelse")
            {
                Console.Write("hvor mange antal værelser vil du bestille ");
                antalværelser = Convert.ToInt16(Console.ReadLine());
                Console.Write("hvor mange antal overnatninger vil du bestille ");
                overnatninger = Convert.ToInt16(Console.ReadLine());
                totalpris = antalværelser * overnatninger * 765;
                euro = antalværelser * overnatninger * 765 / 7.43;
                Console.WriteLine("totalprisen for værelserne og overnatninger er {0} kr totalprisen i euro er {1} euro", totalpris, euro);
            }
            else if (værelsetype == "dobbeltværelse" || værelsetype == "Dobbeltværelse")
            {
                Console.Write("hvor mange antal væreser vil du bestille ");
                antalværelser = Convert.ToInt16(Console.ReadLine());
                Console.Write("hvor mange overnatninger vil du bestille ");
                overnatninger = Convert.ToInt16(Console.ReadLine());
                totalpris = antalværelser * overnatninger * 980;
                euro = antalværelser * overnatninger * 980 / 7.43;
                Console.WriteLine("totalprisen for værelserne og overnatninger er {0} kr totalprisen i euro er {1} euro", totalpris, euro);
            }
            else if (værelsetype == "familieværelser" || værelsetype == "Familieværelser")
            {
                Console.Write("hvor mange antal værelser vil du bestille ");
                antalværelser = Convert.ToInt16(Console.ReadLine());
                Console.Write("hvor mange antal overnatninger vil du bestille ");
                overnatninger = Convert.ToInt16(Console.ReadLine());
                totalpris = antalværelser * overnatninger * 1250;
                euro = antalværelser * overnatninger * 1250 / 7.43;
                Console.WriteLine("totalprisen for værelserne og overnatninger er {0} kr totalprisen i euro er {1} euro", totalpris, euro);
            }
            else
            {
                Console.WriteLine("det du har indtasted må have været en fejl vi kan desvære ikke hjælpe med det prøv igen");
            }
             Console.WriteLine("totalprisen for værelserne og overnatninger er {0} kr totalprisen i euro er {1} euro", totalpris, euro);

            Console.ReadKey();
        }
    }
}
