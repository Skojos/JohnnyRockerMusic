using System;

namespace JohnnyRockersMusic
{
    class Program
    {
        static void Main(string[] args)
        {





            Recordning cd1 = new CompactDisc("Jonas Skoog", 2020, 9, "CD", 29.99);
            Recordning cd2 = new CompactDisc("Kalle", 1990, 9, "CD", 10.0);
            Recordning lp1 = new LongPlay("Kalle", 2020, 9, "LP", 10.0);

            Book b1 = new Book("Pelle", 10.0, true);

            Console.WriteLine(b1.GetPricePlusVAT());
            

            Item[] order = {cd1,cd2, b1};
            Order order1 = new Order(order);
        
        }
    }
}
