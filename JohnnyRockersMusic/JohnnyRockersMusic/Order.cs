using System;
using System.Collections;
using System.Collections.Generic;

namespace JohnnyRockersMusic
{
    public class Order
    {

        private List<Item> orders;
      
        //public List<Item> items { get; set; }

        public long Counter { get; set; }
        public long OrderNumber { get; set; }
       

        public Order(Item[] items)
        {
            this.orders = items;
        }

       



        /* public void GetTotalValue()
         {
             foreach (var item in orders)
             {
                 Console.WriteLine(item);
             }
         }*/



        public void GetReceipt()
        {
            Console.WriteLine($"Receipt ")
            
          
        }


    }
}
