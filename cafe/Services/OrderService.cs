using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cafe.Data;
using static Guna.UI2.WinForms.Suite.ShadowForm;

namespace cafe.Services
{
    internal class OrderService
    {
        public  void ClearOrders() { InMemorydb.Orders.Clear(); }
        public  List<Order> GetAllOrders() { return InMemorydb.Orders; }
        public double GetGrandTotalPrice(Order order)
        {
            order.GrandTotal = 0;

            foreach (OrderItem item in order.OrderItems)
            {
                order.GrandTotal += item.OrderItemPrice;
            }

            return order.GrandTotal;
        }

    }
}
