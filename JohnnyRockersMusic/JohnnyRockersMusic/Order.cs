using System;
using System.Collections;
using System.Collections.Generic;

namespace JohnnyRockersMusic
{
    public class Order
    {

        public List<Item> Orders;



        public static long Counter = 0;
        public long OrderNumber { get; set; }


        public Order(int orderNumber, params Item[] items)
        {
            this.OrderNumber = orderNumber;
            Orders = new List<Item>(items);
            Counter = Counter + 1;
            
        }

       



         public double GetTotalValue()
         {
            double total = 0;

             foreach (Item item in Orders)
             {
                total += item.GetPrice();
             }

            return total;
         }

        public double GetTotalValuePlusVat()
        {
            double total = 0;

            foreach (Item item in Orders)
            {
                total += item.GetPricePlusVAT();

            }

            return total;
        }



        public void GetReceipt()
        {
            Console.WriteLine($"Receipt for Order #{Counter}");
            Console.WriteLine();

            foreach (Item item in Orders)
            {
                
                Console.WriteLine(item.ToString());
                Console.WriteLine();
                 
            }


           

            Console.WriteLine($"Your ordernumber is: {OrderNumber}");
            Console.WriteLine();
            Console.WriteLine("Total excl. VAT: " + GetTotalValue() + " kr");
            Console.WriteLine("Total incl. VAT: " + GetTotalValuePlusVat() + " kr");
            Console.WriteLine();
           

            Console.WriteLine("---------------------------------------------");

        }


    }
}
