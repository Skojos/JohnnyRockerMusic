using System;
namespace JohnnyRockersMusic
{
    public class CompactDisc : Recordning
    {
        public CompactDisc(string artist, int year, int condition, string type, double price)
        {
            this.Artist = artist;
            this.Year = year;
            this.Condition = condition;
            this.Type = type;
            this.Price = price;
        }

    }
}
