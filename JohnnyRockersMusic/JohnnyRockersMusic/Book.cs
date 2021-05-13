using System;
using JohnnyRockersMusic.Interface;

namespace JohnnyRockersMusic
{
    public class Book : Item, IVat6
    {
        private string Author { get; set; }
        private double Price { get; set; }
        private bool Bound { get; set; }

        public override string Name { get; }

        public Book(string name, double price, bool bound)
        {
            Name = name;
            Price = price;
            Bound = bound;
        }

        public override double GetPrice()
        {

            if (Bound)
            {
                Price = Price + 25;
            }

            return Price;
        }

        public override double GetVat()
        {
            return 0.06;
        }
    }
}
