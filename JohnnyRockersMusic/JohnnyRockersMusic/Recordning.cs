using System;
using JohnnyRockersMusic.Interface;

namespace JohnnyRockersMusic
{
    public abstract class Recordning : Item, IVat25
    {

        public int Year { get; set; }
        public string Artist { get; set; }
        public double Price { get; set; }
        public string Type { get; set; }
        public int Condition { get; set; }

        public override string Name { get; }

        public override double GetPrice()

        {
            double x = Condition;
            double value = (10 - x) / 10;
           

            if (Condition > 0 && Condition < 10)
            {
                Price -= (Price * value);
            }

            if (Price < 10)
            {
                Price = 10;
            }

            return Price;
        }

        public override double GetVat()
        {
            return 0.25;
        }
    }
}
