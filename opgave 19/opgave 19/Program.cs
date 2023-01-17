using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave_19
{
    class Program
    {
        static void Main(string[] args)
        {
            string temp;
            double tal;

            Console.WriteLine("indtast din alder");
            temp = Console.ReadLine();
            tal = double.Parse(temp);

            if (tal < 18)
            {
                Console.WriteLine("du er ikke godkendt til en kreditaftale");
            }
            else
            {
                Console.WriteLine("du er godkendt til en kreditaftale ");
            }
            Console.ReadKey();

        }
    }
}
