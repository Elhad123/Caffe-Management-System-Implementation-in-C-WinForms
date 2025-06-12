using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafe.Data
{
    internal class Order
    {
        public Order()
        {
            OrderItems = new List<OrderItem>();
        }
    
        public List <OrderItem> OrderItems { get; set; }
        public double GrandTotal { get; set; }
        public User UserOrder { get; set; }
    }
}
