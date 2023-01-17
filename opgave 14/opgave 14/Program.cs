using System;

namespace opgave_14
{
    class Program
    {
        static void Main(string[] args)
        {

            // opgave 14 a trekats arial
            double højde = 0, grundline = 0, arial = 0;
            string svar = "";

            Console.WriteLine("vil du beringe treakant (t) eller retankel (r) arial ");
            Console.ReadLine();

            Console.Write("indtast højde ");
            højde = Convert.ToInt32(Console.ReadLine());

            Console.Write("indtast grundline ");
            grundline = Convert.ToInt32(Console.ReadLine());

            if (svar == "t")
            {
                arial = højde * grundline / 2;
            }
            else
            {
                arial = højde * grundline;
            }

            Console.WriteLine("arialet figuren er  {0}", arial);
            Console.ReadKey();

        }
    }
}
