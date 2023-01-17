using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave_28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("indtas tabel tal du vil udføre");
            int tabel = Convert.ToInt16(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2} ", i, tabel, tabel * i);
            }
            Console.ReadKey();
        }
    }
}
