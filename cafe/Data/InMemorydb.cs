using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafe.Data
{
    internal static class InMemorydb
    {
        public static List<Item> Items = new List<Item>();
        public static List<Order> Orders = new List<Order>();
        public static  List<User> Users = new List<User>();
        public static User LoggedIn { get; set; }
        public static void Seed()
        {
            User Admin = new User("elhad", "elhad123");
            Users.Add(Admin);

            Item CocaCola = new Item();
            CocaCola.Id = 1;
            CocaCola.Name = "CocaCola";
            CocaCola.Price = 5.00;
            CocaCola.Category = "Hladni Napici";
            Items.Add(CocaCola);

            Item Kafa = new Item();
            Kafa.Id = 2;
            Kafa.Name = "Kafa";
            Kafa.Price = 2.00;
            Kafa.Category = "Topli Napici";
            Items.Add(Kafa);

            Item SladoledCokolada = new Item();
            SladoledCokolada.Id = 3;
            SladoledCokolada.Name = "Sladoled Čokolada";
            SladoledCokolada.Price = 2.00;
            SladoledCokolada.Category = "Sladoledi";
            Items.Add(SladoledCokolada);

            Item Trilece = new Item();
            Trilece.Id = 4;
            Trilece.Name = "Trileće";
            Trilece.Price = 3.00;
            Trilece.Category = "Kolači";
            Items.Add(Trilece);

            Order Narudzba = new Order();
            Narudzba.OrderItems = new List<OrderItem>();
            Narudzba.GrandTotal = 0;

            OrderItem NarudzbaStavka = new OrderItem(CocaCola, 10);
            NarudzbaStavka.item = CocaCola;
            NarudzbaStavka.quantity = 10;
            NarudzbaStavka.OrderItemPrice = NarudzbaStavka.item.Price * NarudzbaStavka.quantity;

            Narudzba.OrderItems.Add(NarudzbaStavka);
            Narudzba.UserOrder = Admin;
            Orders.Add(Narudzba);


        
        }




    }
}
