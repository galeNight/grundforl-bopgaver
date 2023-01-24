using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extra_opgaver_G
{
    class Program
    {
        static void Main(string[] args)
        {
            double km, fradrag1=154,fradrag2=77;
            Console.WriteLine("indtast antal km til befordringsfradraget for skattebetaling");
            km = Convert.ToDouble(Console.ReadLine());
            if (km <= 24)
            {
                Console.WriteLine("du har køret {0} antal km ", km);
                Console.WriteLine("du kan ikke trække noget fradrag fra");
            }
            else if (km >= 25 && km <= 100)
            { 
                Console.WriteLine("du har køret {0} antal km ", km);
                Console.WriteLine("der bliver trukket {0} kr fra i fradrag",km*fradrag1/100);
            }
            else
            {
                Console.WriteLine("du har køret {0} antal km ", km);
                Console.WriteLine("der bliver trukket {0} kr fra i fradrag",km*fradrag2/100);
            }
            Console.ReadKey();
        }
    }
}
