using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extra_opgave_D
{
    class Program
    {
        static void Main(string[] args)
        {
            int tall1, tall2, tall3;
            double resultat;
            Console.WriteLine("indtast tal");
            tall1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("indtast tal");
            tall2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("indtast tal");
            tall3 = Convert.ToInt32(Console.ReadLine());

            resultat = (tall1 + tall2 + tall3) / 3;
            Console.WriteLine("resultaten bliver {0}", resultat);
            Console.ReadKey();
        }
    }
}
