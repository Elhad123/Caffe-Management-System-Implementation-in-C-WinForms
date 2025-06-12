using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cafe.Data;


namespace cafe.Services
{
    internal class ItemService
    {
        public List<string> GetAllCategories()
        {
         return new List<string>() { "Hladni Napici", "Topli Napici", "Kolači", "Sladoledi"};
        }
        public  List<Item> GetAll() { return InMemorydb.Items; }
        public Item GetByName(string name)
        {
            List <Item> Lista = GetAll();
            Item temp = Lista.FirstOrDefault(i => i.Name == name);
            return temp;
        }
        public List<Item> GetByCategory(string category)
        {
            List<Item> Lista = GetAll();
            return Lista.FindAll(i => i.Category == category); 
        }

        public  void Add(Item item)
        {
            List<Item> list = GetAll();
            if (list.Count > 0)
            {
                int maxItem = list.Max(t => t.Id);
                item.Id = maxItem + 1;
            }

            else
            {
                item.Id = 1;
            }

            InMemorydb.Items.Add(item);
        }

        public  void Update(Item item)
        {
            List<Item> list = GetAll();
            // Find the item with the specified ID
            Item itemToUpdate = list.FirstOrDefault(i => i.Id == item.Id);

            if (itemToUpdate != null)
            {
                // Update the item's properties
                itemToUpdate.Name = item.Name;
                itemToUpdate.Category = item.Category;
                itemToUpdate.Price = item.Price;


            }


        }

        internal  void Delete(Item item)
        {

            Item itemToDelete = InMemorydb.Items.FirstOrDefault(i => i.Id == item.Id);

            if (itemToDelete != null)
            {
                InMemorydb.Items.Remove(itemToDelete);

            }
        }

        public  void Clear() { InMemorydb.Items.Clear(); }
    }
}
