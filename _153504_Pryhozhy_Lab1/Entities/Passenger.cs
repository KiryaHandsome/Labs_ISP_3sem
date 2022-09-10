using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _153504_Pryhozhy_Lab1.Collections;

namespace _153504_Pryhozhy_Lab1.Entities
{
    public class Passenger
    {
        private string name = "Person";
        private int id = 0;
        private MyCustomCollection<Tariff> ticketList = new();

        public int Id 
        { 
            get => id;
            set => id = value;
        }

        public string Name 
        {
            get => name;
            set => name = value;
        }

        public Passenger() { }

        public Passenger(string name, int id)
        {
            this.name = name;
            this.id = id;
        }

        public MyCustomCollection<Tariff> TicketList
        {
            get => ticketList;
        }

        public void AddTicket(Tariff ticket)
        {
            ticketList.Add(ticket);
            ticket.AddPassenger(this);
        }

        public override int GetHashCode()
        {
            return name.GetHashCode() + id.GetHashCode();
        }
    }
}
