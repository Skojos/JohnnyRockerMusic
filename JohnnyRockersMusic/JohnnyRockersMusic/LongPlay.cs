using System;
namespace JohnnyRockersMusic
{
    public class LongPlay : Recordning
    {
        public LongPlay(string artist, int year, int condition, string type, double price)
        {
            this.Artist = artist;
            this.Year = year;
            this.Condition = condition;
            this.Type = type;
            this.Price = price;
        }

        public override double GetPrice()
        {

            int yearsOld = 2021 - Year;
            int valueChange = 5 * yearsOld;


            return Price + valueChange;
        }
    }
}
