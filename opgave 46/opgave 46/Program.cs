using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave_46
{
    class Program
    {
        static void Main(string[] args)
        {
            string tast = "";
            double billeter=0,total=0, antal=0;
            //enkeltbillet priser
            double voksenpris = 42, pensionpris = 23,efterlønpris=23,arbejdspris=23,ledihedpris=23,dagpengepris=23,studerenepris=23,børnU7pris=0,børnO7pris=15,skoleferiebørnpris=10;
            //10 turskort priser
            double turvoksen = 330, turpensionpris = 175, turefterlønspris=175, turarbejdspris=175, turledighedspris=175, turdagpengepris=175, turstudernepris=175, turbørn07pris=135;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("velkommen til ballerup svømmehal priser");
            Console.WriteLine("Enkeltbillet Voksne koster 42 kr\n");
            Console.WriteLine("Enkeltbillet Pensionister, efterlønsmodtagere, arbejdsledige, borgere på ledighedsydelse");
            Console.WriteLine("dagpengemodtagere og studerend koster 23 kr hvis du har dokumentation med\n");
            Console.WriteLine("Enkeltbillet børn uder 7 år grais ved følgeskab af voksne\n");
            Console.WriteLine("enkelbillet Børn 7 - 15 år koster 15 kr\n");
            Console.WriteLine("Enkeltbillet skoleferiebillit børn 7 - 15 år sommer/efterår/vintert koster 10 kr\n");

            Console.WriteLine("10 Turskort voksen koster 330 kr\n");
            Console.WriteLine("10 Turskort Pensionister, efterlønsmodtagere, arbejdsledige, borgere på ledighedsydelse");
            Console.WriteLine("dagpengemodtagere og studerend koster 175 kr hvis du har dokumentation med\n");
            Console.WriteLine("10 Turskort Børn 7 - 15 år koster 135 kr\n");
            Console.WriteLine("indtast enkeltbillet eller [e] for at komme til engeltbillet valg");
            Console.WriteLine("indtast turkort eller [t] for at komme til 10 turskort valg");
            tast = Console.ReadLine();
            Console.Clear();

            if(tast == "enkeltbillet" || tast == "e")
            {
                Console.WriteLine("vælg hvilken enkeltbillet du vil have\n");
                Console.WriteLine("enkeltbillet voksen                                     pris:42 kr                    [1]");
                Console.WriteLine("pensionister                                            pris:23 kr                    [2]");
                Console.WriteLine("efterlønsmodtagere                                      pris:23 kr                    [3]");
                Console.WriteLine("arbejdsledige                                           pris:23 kr                    [4]");
                Console.WriteLine("borger på ledighedsydelse                               pris:23 kr                    [5]");
                Console.WriteLine("dagpengemodtager                                        pris:23 kr                    [6]");
                Console.WriteLine("studerne                                                pris:23kr                     [7]");
                Console.WriteLine("børn under 7 år                                         pris:gratis                   [8]");
                Console.WriteLine("børn 7 -15 år                                           pris:15 kr                    [9]");
                Console.WriteLine("skoleferiebillet børn 7 - 15 år sommer/eftår/vinter     pris:10 kr                   [10]\n");
                Console.WriteLine("indtast valg her eller exit for at afslutte program");
                tast = Console.ReadLine();
                Console.Clear();

                while (tast != "exit")
                {
                    switch (tast)
                    {
                        case "1":
                            Console.WriteLine("du har valgt enkelbillet voksen indtst hvor mange du vil have");
                            antal = Convert.ToDouble(Console.ReadLine());

                            billeter = billeter + antal;
                            total = total + voksenpris * antal;
                            Console.WriteLine("prisen i i alt er {0} kr\n", total);
                            Console.WriteLine("");
                            Console.WriteLine("indtats exit for at afslute programmet");
                            tast = Console.ReadLine();
                            Console.Clear();
                            break;

                        case "2":
                            Console.WriteLine("du har valgt enkelbillet pensionist indtst hvor mange du vil have");
                            antal = Convert.ToDouble(Console.ReadLine());

                            billeter = billeter + antal;
                            total = total + pensionpris * antal;
                            Console.WriteLine("prisen i alt er {0} kr\n", total);
                            Console.WriteLine("");
                            Console.WriteLine("indtats exit for at afslute programmet");
                            tast = Console.ReadLine();
                            Console.Clear();
                            break;

                        case "3":
                            Console.WriteLine("du har valgt enkeltbillet efterlønsmodtagere indtast hvor mange du vil have");
                            antal = Convert.ToDouble(Console.ReadLine());

                            billeter = billeter + antal;
                            total = total + efterlønpris * antal;
                            Console.WriteLine("prisen i alt er {0} kr\n", total);
                            Console.WriteLine("");
                            Console.WriteLine("indtats exit for at afslute programmet");
                            tast = Console.ReadLine();
                            Console.Clear();
                            break;

                        case "4":
                            Console.WriteLine("du har valgt enkelbillet arbejdsledige indtast hvor mange du vil have");
                            antal = Convert.ToDouble(Console.ReadLine());

                            billeter = billeter + antal;
                            total = total + arbejdspris * antal;
                            Console.WriteLine("prisne i alt er {0} kr\n", total);
                            Console.WriteLine("");
                            Console.WriteLine("indtast exit for at afslutte programmet");
                            tast = Console.ReadLine();
                            Console.Clear();
                            break;

                        case "5":
                            Console.WriteLine("du har valg enkelbillet borger på ledighedsydelse indtast hvor mange du vil have");
                            antal = Convert.ToDouble(Console.ReadLine());

                            billeter = billeter + antal;
                            total = total + ledihedpris * antal;
                            Console.WriteLine("prisen i alt er {0} kr\n", total);
                            Console.WriteLine("");
                            Console.WriteLine("indtast exit for at afslutte programmet");
                            tast = Console.ReadLine();
                            Console.Clear();
                            break;

                        case "6":
                            Console.WriteLine("du har valg enkeltbillet dagpengemodtager indtst hvormange du vil have");
                            antal = Convert.ToDouble(Console.ReadLine());

                            billeter = billeter + antal;
                            total = total + dagpengepris * antal;
                            Console.WriteLine("prisen i alt er {0} kr\n", total);
                            Console.WriteLine("");
                            Console.WriteLine("indtast exit for at afslutte programmet");
                            tast = Console.ReadLine();
                            Console.Clear();
                            break;

                        case "7":
                            Console.WriteLine("du har valg enkeltillet studerne indtast hvor mange du vil have");
                            antal = Convert.ToDouble(Console.ReadLine());

                            billeter = billeter + antal;
                            total = total + studerenepris * antal;
                            Console.WriteLine("prisen i alt er {0} kr\n", total);
                            Console.WriteLine("");
                            Console.WriteLine("indtast exit for at afslutte programmet");
                            tast = Console.ReadLine();
                            Console.Clear();
                            break;

                        case "8":
                            Console.WriteLine("du har valgt enkeltbillet børn under 7 år indtast hvor mange du vil have");
                            antal = Convert.ToDouble(Console.ReadLine());

                            billeter = billeter + antal;
                            total = total + børnU7pris * antal;
                            Console.WriteLine("prisen i alt er {0} kr\n", total);
                            Console.WriteLine("");
                            Console.WriteLine("indtast exit for at afslutte programmet");
                            tast = Console.ReadLine();
                            Console.Clear();
                            break;

                        case "9":
                            Console.WriteLine("du haar valgt enkeltbillet børn 7 - 15 år indtast hvormange du vil have");
                            antal = Convert.ToDouble(Console.ReadLine());

                            billeter = billeter + antal;
                            total = total + børnO7pris * antal;
                            Console.WriteLine("prisen i alt er {0} kr\n", total);
                            Console.WriteLine("");
                            Console.WriteLine("indtast exit for at afslutte programmet");
                            tast = Console.ReadLine();
                            Console.Clear();
                            break;

                        case "10":
                            Console.WriteLine("du har valgt enkeltbillet skoleferie børn7-15år/sommer/efterår/winter idntast hvor mange du vil have");
                            antal = Convert.ToDouble(Console.ReadLine());

                            billeter = billeter + antal;
                            total = total + skoleferiebørnpris * antal;
                            Console.WriteLine("prisen i alt er {0} kr\n", total);
                            Console.WriteLine("");
                            Console.WriteLine("indtast exit for at afslutte programmet");
                            tast = Console.ReadLine();
                            Console.Clear();
                            break;

                        default:
                            Console.WriteLine("ugyldig indtastning ");
                            Console.WriteLine("indtast exit for at afslutte programmet");
                            tast = Console.ReadLine();
                            break;
                    }
                }
                
            }
            else if (tast == "turkort" || tast == "t")
            {
                Console.WriteLine("vælg hvilken 10 turkort du vil have\n");
                Console.WriteLine("10 turskort voksen                                       pris:330 kr                  [1]");
                Console.WriteLine("pensionister                                             pris:175 kr                  [2]");
                Console.WriteLine("efterlønsmodtagere                                       pris:175 kr                  [3]");
                Console.WriteLine("arbejdsledige                                            pris:175 kr                  [4]");
                Console.WriteLine("borger på ledighedsydelse                                pris:175 kr                  [5]");
                Console.WriteLine("dagpengemodtager                                         pris:175 kr                  [6]");
                Console.WriteLine("studerne                                                 pris:175 kr                  [7]");
                Console.WriteLine("børn 7 -15 år                                            pris:135 kr                  [8]\n");
                Console.WriteLine("indtast valg her eller exit for at afslutte program");
                tast = Console.ReadLine();
                Console.Clear();

                while (tast != "exit")
                {
                    switch (tast)
                    {
                        case "1":
                            Console.WriteLine("du har valgt 10 turskort voksen indtast hvormange du vil have");
                            antal = Convert.ToDouble(Console.ReadLine());

                            billeter = billeter + antal;
                            total = total + turvoksen * antal;
                            Console.WriteLine("prisen i alt er {0} kr\n", total);
                            Console.WriteLine("");
                            Console.WriteLine("indtast exit for at afslutte programmet");
                            tast = Console.ReadLine();
                            Console.Clear();
                            break;

                        case "2":
                            Console.WriteLine("du har valgt 10 turskort pensionster indtast hvormange dul vil have");
                            antal = Convert.ToDouble(Console.ReadLine());

                            billeter = billeter + antal;
                            total = total + turpensionpris * antal;
                            Console.WriteLine("prisen i alt er {0} kr\n", total);
                            Console.WriteLine("");
                            Console.WriteLine("indtast exit for at afslutte programmet");
                            tast = Console.ReadLine();
                            Console.Clear();
                            break;

                        case "3":
                            Console.WriteLine("du har valgt 10 turskort efterlønsmodtager indtats hvor mange du vil have");
                            antal = Convert.ToDouble(Console.ReadLine());

                            billeter = billeter + antal;
                            total = total + turefterlønspris * antal;
                            Console.WriteLine("prisen i alt er {0} kr\n", total);
                            Console.WriteLine("");
                            Console.WriteLine("indtast exit for at afslutte programmet");
                            tast = Console.ReadLine();
                            Console.Clear();
                            break;

                        case "4":
                            Console.WriteLine("du har valgt 10 turskort arbejdsledige indtast hvor mange du vil have ");
                            antal = Convert.ToDouble(Console.ReadLine());

                            billeter = billeter + antal;
                            total = total + turarbejdspris * antal;
                            Console.WriteLine("prisen i alt er {0} kr\n", total);
                            Console.WriteLine("");
                            Console.WriteLine("indtast exit for at afslutte programmet");
                            tast = Console.ReadLine();
                            Console.Clear();
                            break;

                        case "5":
                            Console.WriteLine("du har valgt 10 turskort boger på ledighesydelse ind tast hvormange du vil have ");
                            antal = Convert.ToDouble(Console.ReadLine());

                            billeter = billeter + antal;
                            total = total + turledighedspris * antal;
                            Console.WriteLine("prisen i alt er {0} kr\n", total);
                            Console.WriteLine("");
                            Console.WriteLine("indtast exit for at afslutte programmet");
                            tast = Console.ReadLine();
                            Console.Clear();
                            break;

                        case "6":
                            Console.WriteLine("du har valgt 10 turskort dagpengemodtager indtast hvormange du vil have ");
                            antal = Convert.ToDouble(Console.ReadLine());

                            billeter = billeter + antal;
                            total = total + turdagpengepris * antal;
                            Console.WriteLine("prisen i alt er {0} kr\n", total);
                            Console.WriteLine("");
                            Console.WriteLine("indtast exit for at afslutte programmet");
                            tast = Console.ReadLine();
                            Console.Clear();
                            break;

                        case "7":
                            Console.WriteLine("du har valgt 10 turskort studerne indtast hvor mange du vil have");
                            antal = Convert.ToDouble(Console.ReadLine());

                            billeter = billeter + antal;
                            total = total + turstudernepris * antal;
                            Console.WriteLine("prisen i alt er {0} kr\n", total);
                            Console.WriteLine("");
                            Console.WriteLine("indtast exit for at afslutte programmet");
                            tast = Console.ReadLine();
                            Console.Clear();
                            break;

                        case "8":
                            Console.WriteLine("du har valgt 10 turskort børn 7-15år indtast hvor mange du vil have");
                            antal = Convert.ToDouble(Console.ReadLine());

                            billeter = billeter + antal;
                            total = total + turbørn07pris * antal;
                            Console.WriteLine("prisen i alt er {0} kr\n", total);
                            Console.WriteLine("");
                            Console.WriteLine("indtast exit for at afslutte programmet");
                            tast = Console.ReadLine();
                            Console.Clear();
                            break;

                        default:
                            Console.WriteLine("ugyldig indtastning ");
                            Console.WriteLine("indtast exit for at afslutte programmet");
                            tast = Console.ReadLine();
                            break;
                    }
                }
                
            }
            Console.WriteLine("prisen for antal billeter er i alt {0} kr ",billeter);
            Console.WriteLine("antal bestilte billeter {0}\n", total);
            Console.WriteLine("programmet er nu afsluttet");
            Console.ReadKey();


        }
    }
}
