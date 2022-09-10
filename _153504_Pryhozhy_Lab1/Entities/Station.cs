using System.Collections;
using _153504_Pryhozhy_Lab1.Collections;

namespace _153504_Pryhozhy_Lab1.Entities
{
    public class Station
    {
        private MyCustomCollection<Passenger> passengers = new();
        private MyCustomCollection<Tariff> tariffs = new();

        public Station() { }

        public void AddPassenger(Passenger passenger)
        {
            passengers.Add(passenger);
        }

        public void AddTariff(Tariff tariff)
        {
            tariffs.Add(tariff);
        }

        public MyCustomCollection<Tariff> GetTariffs()
        {
            return tariffs;
        }

        public MyCustomCollection<Passenger> GetPassengersByTicketPath(string ticketPath)
        {
            MyCustomCollection<Passenger> passengers = new();
            tariffs.Reset();
            for(int i = 0; i < tariffs.Count; i++)
            {
                if(tariffs.Current().Path == ticketPath)
                {
                    return tariffs.Current().GetPasses();
                }
                tariffs.Next();
            }
            return null;
        }

        public double GetPriceOfPurchasedTickets(string name, int id)
        {
            passengers.Reset();
            for(int i = 0; i < passengers.Count; i++)
            {
                var current = passengers.Current();
                if(current.Name == name && current.Id == id)
                {
                    var list = current.TicketList;
                    double totalPrice = 0;
                    list.Reset();
                    //count total price 
                    for (int j = 0; j < list.Count; j++)
                    {
                        totalPrice += list.Current().Price;
                        list.Next();
                    }
                    return totalPrice;
                }
                passengers.Next();
            }
            return 0; 
        }
    }
}
