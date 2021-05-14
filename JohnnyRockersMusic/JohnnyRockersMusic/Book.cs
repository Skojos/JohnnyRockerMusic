using System;
using JohnnyRockersMusic.Interface;

namespace JohnnyRockersMusic
{
    public class Book : Item, IVat6
    {
        private string Author { get; set; }
        private double Price { get; set; }
        private bool Bound { get; set; }

       

        public Book(string name, string author, double price, bool bound) : base(name)
        {
            this.Author = author;
            this.Price = price;
            this.Bound = bound;
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

        public override string ToString()
        {
            return string.Format("Book : {0}, {1}, {2} {3}", Name, Author, Price, Bound);
        }
    }
}
