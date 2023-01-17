using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave_15
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahienheit, celcius =0, temp;

            Console.WriteLine("indtast faienhiet med + eller - skal være forand tallet du har indtastet");
            temp = Convert.ToDouble(Console.ReadLine());
            
            fahienheit = (celcius - 32) * 1.8 ;

            Console.WriteLine(" celcius er  {0}", fahienheit);
            Console.ReadKey();
        }
    }
}
