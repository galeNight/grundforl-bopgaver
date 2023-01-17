using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("indtast højde");
            double  højde = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("indtast grundline");
            double  grundline = Convert.ToDouble(Console.ReadLine());

            double semiperimeter = (højde * højde + grundline * grundline);
            double c = Math.Sqrt((semiperimeter));

            Console.WriteLine("side c er " + c);

            double semi = (højde + grundline + c);
            double omkreds = semi;

            Console.WriteLine("omkresen er " + semi);

            Console.ReadKey();
        }
    }
}
