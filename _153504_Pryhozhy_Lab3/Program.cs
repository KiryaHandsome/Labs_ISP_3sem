using _153504_Pryhozhy_Lab3.Entities;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
            Station station = new Station();
            Journal journal = new Journal();
            //link handlers
            station.Purchased += (string message) => Console.WriteLine(message);
            station.Modified += journal.SaveEventInfo;

            station.AddTariff(10, "Minsk");
            station.AddTariff(20, "Gomel");
            station.AddTariff(5, "Volkovysk");

            station.AddPassenger("Kirya");
            station.AddPassenger("Igor");

            station.BuyTicketToPassenger("Kirya", "Minsk");
            station.BuyTicketToPassenger("Kirya", "Gomel");
            station.BuyTicketToPassenger("Kirya", "Gomel");
            station.BuyTicketToPassenger("Kirya", "Gomel");
            station.BuyTicketToPassenger("Igor", "Gomel");
            var count = 5;
            //aggregate
            Console.WriteLine($"Amount of passengers who paid more than {count}:" +
                $" {station.GetAmountOfPassesWhoPaidMoreThan(5)}");

            //group by
            var list = station.GetSumListForEachPath("Kirya");
            Console.WriteLine("Kirya bought next tickets:");
            foreach(var item in list)
            {
                Console.WriteLine($"{item.Direction} ---> {item.Price}");
                
                Console.WriteLine();
            }
            //max by
            Console.WriteLine($"Id of passenger who paid max sum : {station.GetIdOfPassWhoPaidMaxSum()}");
            //order by
            Console.WriteLine("Tariffs in order by price:");
            station.GetAllTariffsSortedByPrice().ForEach(m => Console.WriteLine(m));
            //sum
            Console.WriteLine($"Price of all purchased tickets: {station.PriceOfAllPurchasedTickets()}");
            journal.PrintEventsInfo();
        }
    }
}