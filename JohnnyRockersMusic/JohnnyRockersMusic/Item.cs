using System;
using System.Collections;
using JohnnyRockersMusic.Interface;

namespace JohnnyRockersMusic
{
    public abstract class Item : IVat

    {

        public abstract string Name { get; }


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
