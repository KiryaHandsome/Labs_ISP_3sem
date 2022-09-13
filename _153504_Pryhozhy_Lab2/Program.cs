using System;
using _153504_Pryhozhy_Lab2.Collections;
using _153504_Pryhozhy_Lab2.Interfaces;
using _153504_Pryhozhy_Lab2.Entities;
using _153504_Pryhozhy_Lab2.Exceptions;
using System.Collections;


//variant #2
namespace Program
{
    public class Program
    {
        public static void Main()
        {
            Station station = new Station();
            Journal journal = new Journal();
            //link event with action
            station.AddModificationsHandler(journal.SaveEventInfo);
            //add lambda expression like function
            station.AddPurchaseHandler((string message) => Console.WriteLine(message));
            //add passengers and tariffs
            station.AddPassenger("Kiryl");      //will  
            station.AddPassenger("Egor");       //be 
            station.AddTariff(100, "Minsk");    //in
            station.AddTariff(200, "Soligorsk");//journal
            station.BuyTicketToPassenger("Kiryl", "Minsk");   //will print
            station.BuyTicketToPassenger("Egor", "Soligorsk");//in console

            journal.PrintEventsInfo();
            MyCustomCollection<int> list = new MyCustomCollection<int>();
            list.Add(1);
            try
            {
                list[12] = 123;
            }
            catch (IndexOutOfRangeException) { }
            try
            {
                list.Remove(1233123123); //custom ex - ValueNotFound
            }
            catch (ValueNotFoundException) { }
            list.Remove(1);
            try
            {
                list.Remove(1233123123); //empty collection
            }
            catch (InvalidOperationException) { }
        }
    }

}