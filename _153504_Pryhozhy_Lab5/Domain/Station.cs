using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Station
    {
        private LuggageCompartment luggageCompartment = new LuggageCompartment();
        private List<string> directions = new List<string>();


        public Station() { }
        public Station(double luggageCompartmentCapacity, bool isFull = false)
        {
            luggageCompartment = new LuggageCompartment(luggageCompartmentCapacity, isFull);
        }

        public Station(double luggageCompartmentCapacity, bool isFull, List<string> directions)
        {
            luggageCompartment = new LuggageCompartment(luggageCompartmentCapacity, isFull);
            this.directions = directions;
        }

        public void PrintDirections()
        {
            directions.ForEach(direction => Console.WriteLine(direction));
        }

        public void AddDirection(string direction)
        {
            directions.Add(direction);
        }
    }
}
