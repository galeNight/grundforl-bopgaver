using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extra_opgave_A
{
    class Program
    {
        static void Main(string[] args)
        {
            string fornavn,efternavn;
            int alder;
            Console.WriteLine("indtast dit fornavn");
            fornavn = Console.ReadLine();
            Console.WriteLine("indtast dit efternavn");
            efternavn = Console.ReadLine();

            Console.WriteLine("indtast din alder i tal");
            alder = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("dit fornavn er {0} efternavnet er {1} og du har levet i {2} år", fornavn,efternavn, alder);
            Console.ReadKey();
        }
    }
}
