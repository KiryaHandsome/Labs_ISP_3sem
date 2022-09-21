using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    class LuggageCompartment
    {
        public LuggageCompartment(double capacity = 10, bool isFull = false)
        {
            Capacity = capacity;
            IsFull = isFull;
        }

        public double Capacity
        {
            get; set; 
        }

        public bool IsFull
        {
            get; set;
        }
    }
}
