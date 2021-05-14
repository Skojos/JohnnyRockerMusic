using System;
using System.Collections;
using JohnnyRockersMusic.Interface;

namespace JohnnyRockersMusic
{
    public abstract class Item : IVat

    {

        public string Name { get; set;}

        public Item(string name)
        {
            this.Name = name;
        }

        public abstract double GetPrice();

        public double GetPricePlusVAT()
        {
            double price = GetPrice();
            double vat = GetVat();
            double total = price * (1+vat);

            return total;
        }

        public abstract double GetVat();

       
    }
}
