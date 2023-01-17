using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave_37
{
    class Program
    {
        static void Main(string[] args)
        {
            string by = "Kerteminde", gæt;
            int antalgæt=5;

            do
            {

                Console.WriteLine("get navnet på en by på fyn\n");
                Console.WriteLine("indtast navn på en by");
                gæt = Console.ReadLine();
                Console.Clear();

                antalgæt--;

            }
            while (gæt != by && antalgæt > 0);
            Console.WriteLine("du gættede rigthig tillykke du har vundet vores stolthed");
            Console.ReadKey();
        }
    }
}
