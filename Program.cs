using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaDomowa3
{
    class Program
    {
        static void Main(string[] args)
        {
            // kalkulator
            string cos = " ";
            do
            {

                Console.WriteLine("Wpisz Liczbe pierwsza");
                int liczba1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Wpisz liczbę drugą");
                int liczba2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Co z nimi zrobic?");
                Console.WriteLine("1 - dodać \n2 - odjąć \n3 - pomnożyć \n4 - podzielić");

                int znak = Convert.ToInt32(Console.ReadLine());
                switch (znak)
                {
                    case 1:
                        Console.WriteLine($"{liczba1 + liczba2}");
                        break;

                    case 2:
                        Console.WriteLine($"{liczba1 - liczba2}");
                        break;

                    case 3:
                        Console.WriteLine($"{liczba1 * liczba2}");
                        break;

                    case 4:
                        Console.WriteLine(liczba1 / liczba2);
                        break;

                    default:
                        Console.WriteLine("\nNie ma takiej opcji");
                        break;
                }

                Console.WriteLine("\nChcesz kontynuowac?");
                cos = Console.ReadLine();
                if (cos == "NIE" || cos == "NIE")
                {

                    cos = "nie";
                }


            } while (cos == "tak" || cos == "TAK");

            //*************************************************************

            ////zadanie z logowaniem
            //int x = 0;
            //int suma = 0;
            //Dictionary<string, string> daneUzytkownikow = new Dictionary<string, string>()
            //{
            //    ["Jan"] = "Kowalski",
            //    ["Szymon"] = "Nowak",
            //    ["Mateusz"] = "Krzak"
            //};
            //Console.WriteLine("Podaj login:");
            //string login = Console.ReadLine();
            //Console.WriteLine("Podaj haslo:");
            //string haslo = Console.ReadLine();

            //if (daneUzytkownikow[login] == haslo)
            //{
            //    Console.WriteLine("\nZalogowałeś się");
            //    Console.WriteLine("\nŁączymy słowa czy Liczymy średnią? Wpisz połącz lub policz");
            //    string wybor = Console.ReadLine();
            //    if (wybor == "połącz" || wybor == "polacz")
            //    {
            //        x = 1;
            //    }
            //    else if (wybor == "policz")
            //    {
            //        x = 2;
            //    }
            //    else
            //    {
            //        x = 0;
            //    }

            //    switch (x)
            //    {
            //        case 1:
            //            List<string> ListaSlow = new List<string>()
            //            { };
            //            for (int i = 0; i < 5; i++)
            //            {
            //                Console.WriteLine("Podaj  słowo:");
            //                ListaSlow.Add(Console.ReadLine());
            //            } 
                
            //            string ListaSlowCalosc = "";
            //            for (int i = 0; i < ListaSlow.Count; i++)
            //            {
            //                ListaSlowCalosc += ListaSlow[i];
            //            }
            //            Console.WriteLine(ListaSlowCalosc);
            //            break;

            //        case 2:
            //            int[] tablicaLiczb = new int[5];
            //            for (int i = 0; i < 5; i++)
            //            {
            //                Console.WriteLine("Podaj liczbe");
            //                tablicaLiczb[i] = Convert.ToInt32(Console.ReadLine());
            //            }
            //            for (int i = 0; i < 5; i++)
            //            {
            //                suma += tablicaLiczb[i];
            //            }
                      
            //            Console.WriteLine($"Średnia arytmetyczna tablicy jest równa {suma / 5}");
            //            break;

            //        default:
            //            Console.WriteLine("Wybrałeś błędną opcje!");
            //            break;
            //    }

                  
            //}
            
            //else
            //{
            //    Console.WriteLine("\nPodałeś błędne hasło");
            //}


            Console.ReadLine();

        }
    }
}
