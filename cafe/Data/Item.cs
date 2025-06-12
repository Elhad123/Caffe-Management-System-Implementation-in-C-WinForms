using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafe.Data
{
    internal class Item
    {
        public Item(int id,string name,string category,double price) { 
            this.Id = id;
            this.Name = name;
            this.Category = category; 
            this.Price = price;
        }

        public Item() { }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
    }
}
