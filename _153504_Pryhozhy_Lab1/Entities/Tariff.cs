using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _153504_Pryhozhy_Lab1.Collections;

namespace _153504_Pryhozhy_Lab1.Entities
{
    public class Tariff
    {
        private double price = 10;
        private string path = "Minsk";
        private MyCustomCollection<Passenger> passes = new();
        public string Path
        {
            get => path;
            set => path = value;
        }

        public double Price
        {
            get => price; 
            set => price = value;
        }

        public MyCustomCollection<Passenger> GetPasses()
        {
            return passes;
        }

        public Tariff() { }

        public Tariff(double price, string path)
        {
            this.price = price;
            this.path = path;
        }

        public void AddPassenger(Passenger pass)
        {
            passes.Add(pass);
        }

        public override bool Equals(object? other)
        {
            var obj = other as Tariff;
            return obj.price == price && obj.path == path;
        }
    }
}
