using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave_56
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double[] tempratur = new double[7];

            for(int i = 0; i <= 6; i++)
            {
                Console.WriteLine("indtast tempraturen på dag nr. {0}", i + 1);
                tempratur[i] = Convert.ToDouble(Console.ReadLine());
                sum = sum + tempratur[i];
            }
            for(int i = 0; i <= 6; i++)
            {
                Console.WriteLine("tempraturen på dag nr. {0} er {1}", i + 1, tempratur[i]);
            }
            Console.WriteLine("Gennemsnittet er {0}", sum / 10);
            Console.ReadKey();
        }
    }
}
