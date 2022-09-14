using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _153504_Pryhozhy_Lab3.Entities
{
    public class Passenger
    {
        private string idData = "Kirya";
        private List<Tariff> purchasedTickets = new List<Tariff>();

        public Passenger(string idData)
        {
            this.idData = idData;
        }

        public string Id
        {
            get => idData;
        }

        public List<Tariff> PurchasedTickets
        {
            get => purchasedTickets;
        }

        public double GetPriceOfPurchasedTickets()
        {
            return purchasedTickets.Sum(x => x.Price);
        }

        public void BuyTicket(Tariff ticket)
        {
            purchasedTickets.Add(ticket);
        }
    }
}
