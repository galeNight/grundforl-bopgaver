using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave_18
{
    class Program
    {
        static void Main(string[] args)
        {
            string temp;
            double tal;

            Console.WriteLine("skriv et tal mellen 1 - 10");
            temp = Console.ReadLine();
            tal = double.Parse(temp);

            if (tal < 4)
            {
                Console.WriteLine("tallet er mindre en tallet 4");
            }
            else if (tal <= 4)
            {
                Console.WriteLine("tallet er mindre eller ligmed 4");
            }
            else if (tal > 4)
            {
                Console.WriteLine("tallet er støre eller ligmed 4");
            }
            else if (tal == 4)
            {
                Console.WriteLine("tallet er ligmed 4");
            }
            else if (tal != 4)
            {
                Console.WriteLine("taller er ikke ligemed eller forskælligt fra 4");
            }

            Console.ReadKey();

        }
    }
}
