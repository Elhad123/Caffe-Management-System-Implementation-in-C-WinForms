using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cafe.Data;

namespace cafe.Services
{
    internal class PrintService
    {
      public void PrintToTxt(Order order,string fileName,bool apend = false)
        {
            string projectRoot = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
            string folderPath = Path.Combine(projectRoot, "Racuni");
            string filePath = Path.Combine(folderPath, fileName);

            // ✅ Create folder if it doesn't exist
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (StreamWriter writer = new StreamWriter(filePath,apend))
            {
                writer.WriteLine("\n==================== NEW ORDER ====================\n");
                // Write User Info
                writer.WriteLine("Employee Information");
                writer.WriteLine("--------------------");
                writer.WriteLine($"Name   : {order.UserOrder.Name}");
                writer.WriteLine($"Date   : {DateTime.Now.ToString()}");
                writer.WriteLine();

                // Write Order Items
                writer.WriteLine("Order Items");
                writer.WriteLine("-----------");
                foreach (var item in order.OrderItems)
                {
                    writer.WriteLine($"{item.quantity} x {item.item.Name} @ {item.item.Price:C} = {item.OrderItemPrice:C}");
                }
                writer.WriteLine();

                // Write Total
                writer.WriteLine($"Total Order Value: {order.GrandTotal:C}");
            }
        }
    }
}
