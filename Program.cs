using System;

namespace JohnnyRockersMusic
{
    class Program
    {
        static void Main(string[] args)
        {


            Item cdOne = new CompactDisc("Punisher", "Phoebe Bridgers", 2020, 10, "CD", 200.0);
            Item lpOne = new LongPlay("What kinda music", "Tome Mish", 2020, 10, "LP", 150.0);
            Item lpTwo = new LongPlay("Little Oblivious", "Julien Barker", 2021, 10, "LP", 120.0);




            Item[] order = { cdOne, lpOne, lpTwo };
            Order order1 = new Order(373928,order);
            order1.GetReceipt();

            Item[] orderNew = { lpOne, lpTwo };
            Order order2 = new Order(372929, orderNew);
            order2.GetReceipt();




        }
    }
}
