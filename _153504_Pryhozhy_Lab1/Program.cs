using System;
using _153504_Pryhozhy_Lab1.Collections;
using _153504_Pryhozhy_Lab1.Interfaces;
using _153504_Pryhozhy_Lab1.Entities;
using System.Collections;


//variant #2
namespace Program
{
    public class Program
    {
        static void Main()
        {
            Station station = new();
            //create tariffs
            Tariff[] ticket = new Tariff[6];
            string[] paths = { "Minsk", "Gomel", "Mogilev", "Grodno", "Brest", "Vitebsk", "Volkovysk" };
            for (int i = 0; i < 6; i++)
            {
                ticket[i] = new Tariff(i * 10 + 5, paths[i]);
                station.AddTariff(ticket[i]);
            }
            //create passengers and add them to station
            Passenger[] passenger = new Passenger[6];
            string[] names = { "Kirya", "Ilya", "Andrew", "Denis", "Egor", "Victor" };
            for (int i = 0; i < 6; i++)
            {
                passenger[i] = new Passenger(names[i], (i + 1) * 111);
                passenger[i].AddTicket(ticket[i]);
                station.AddPassenger(passenger[i]);
            }

            //buy one more ticket for passenger
            passenger[2].AddTicket(ticket[5]);
            Console.WriteLine("Total price of purchased tickets:");
            foreach (var now in passenger)
            {
                Console.WriteLine(now.Name + " " + now.Id.ToString() + " : "
                    + station.GetPriceOfPurchasedTickets(now.Name, now.Id));
            }

            Delimeter();

            for (int i = 0; i < 7; i++)
            {
                //last iteration must be false
                var passes = station.GetPassengersByTicketPath(paths[i]);
                if (passes != null)
                {
                    Console.WriteLine("List of people who go to " + paths[i] + ":");
                    passes.Reset();
                    for (int j = 0; j < passes.Count; j++)
                    {
                        Console.WriteLine(passes.Current().Name);
                        passes.Next();
                    }
                }
                else
                {
                    Console.WriteLine("There is no tariff to " + paths[i]);
                }
            }

            Delimeter();

            //check indexator
            var tariffs = station.GetTariffs();
            var lastTariff = tariffs[tariffs.Count - 1];
            Console.WriteLine("Last tariff:" + lastTariff.Path + " " + lastTariff.Price.ToString());


            //remove() tests
            MyCustomCollection<int> list = new MyCustomCollection<int>();
            for (int i = 1; i < 12; i++)
            {
                list.Add(i);
            }
            list.Remove(1);
            list.PrintCollection();
            Console.WriteLine();
            list.Remove(5);
            list.PrintCollection();
        }
        public static void Delimeter()
        {
            for (int i = 0; i < 40; i++) Console.Write("-");
            Console.WriteLine();
        }

        
    }
   
}