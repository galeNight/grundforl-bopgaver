using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extra_opgave_B
{
    class Program
    {
        static void Main(string[] args)
        {
            string navn,uddanelste;
            double penge=0,årstal=0;
            int alder;

            Console.WriteLine("indtast navn");
            navn = Console.ReadLine();
            Console.WriteLine("indtats alder i tal");
            alder = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("indtast årstal du gik ud af folkeskolen");
            årstal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("indtast penge antal i tal");
            penge = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("intast uddanelse og vilken skole uddanelsen er på");
            uddanelste = Console.ReadLine();


            Console.WriteLine("mit navn er {0} og jeg er {1} år gammel og gik ud af folkeskole i årstallet {2} og har {3} kr i banken og skal starte på uddanelse som er {4} ", navn,alder, årstal, penge, uddanelste);
            Console.ReadKey();
        }
    }
}
