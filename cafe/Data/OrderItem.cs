using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafe.Data
{
    internal class OrderItem
    {
        public OrderItem(Item item, int quantity)
        {
            this.item = item;
            this.quantity = quantity;
            this.OrderItemPrice = this.item.Price * this.quantity;
        }
    
        public Item item {get;set;}
        public int quantity {get;set;}
        public double OrderItemPrice {get;set;}
    }
}
