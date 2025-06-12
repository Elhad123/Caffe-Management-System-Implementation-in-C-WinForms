using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cafe.Data;
using cafe.Services;

namespace cafe.Usercontrol
{
    public partial class UC_Narudzba : UserControl
    {
        private readonly OrderService _orderService;
        private readonly ItemService _itemService;
        private readonly PrintService _printService;
        Order Narudzba = new Order();
        
        public UC_Narudzba()
        {
            _orderService = new OrderService();
            _itemService = new ItemService();
            _printService = new PrintService();
            InitializeComponent();
        }
        internal void LoadData()
        {
            this.lbListItems.Items.Clear();
            List<Item> list = _itemService.GetAll();
            foreach (Item item in list)
            {
                this.lbListItems.Items.Add(item.Name);
            }

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UC_Narudzba_Load(object sender, EventArgs e)
        {
            foreach (string kategorija in _itemService.GetAllCategories())
            {
                cbCategory.Items.Add(kategorija);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = this.lbListItems.SelectedItems[0];
            if (selectedItem != null)
            {
                Item selected = _itemService.GetByName(selectedItem.ToString());
                tbName.Text = selected.Name;
                tbUnitPrice.Text = selected.Price.ToString();
                tbQuantity.Text = 1.ToString();
                tbQuantity.Focus();
                
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = cbCategory.SelectedItem.ToString();
            lbListItems.Items.Clear(); 
            foreach (Item item in _itemService.GetByCategory(category)) {

                lbListItems.Items.Add(item.Name);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var selectedItem = this.lbListItems.SelectedItems[0];
            if (selectedItem != null)
            {
                Item selected = _itemService.GetByName(selectedItem.ToString());
                int quantity = Int32.Parse(tbQuantity.Text);
                OrderItem newItem = new OrderItem(selected,quantity);
                newItem.item.Name = selected.Name;
                
                this.OrderGrid.Rows.Add(newItem.item.Name,newItem.item.Price,newItem.quantity,newItem.OrderItemPrice);

                Narudzba.OrderItems.Add(newItem);
                Narudzba.GrandTotal = _orderService.GetGrandTotalPrice(Narudzba);

                lblGrandTotal.Text = Narudzba.GrandTotal.ToString();

                

            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void txtNarudzba_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the first selected row
            DataGridViewRow selectedRow = OrderGrid.SelectedRows[0];

            string name = (selectedRow.Cells["ColumnName"].Value.ToString());
            int Quantity = Int32.Parse(selectedRow.Cells["ColumnQuantity"].Value.ToString());
            this.OrderGrid.Rows.Clear();

            OrderItem item = null;
            foreach (OrderItem OI in Narudzba.OrderItems)
            {
                if(OI.quantity == Quantity && OI.item.Name == name)
                {
                    item = OI;
                    
                }
                else
                {
                    this.OrderGrid.Rows.Add(OI.item.Name, OI.item.Price, OI.quantity, OI.OrderItemPrice);
                }
            }


            Narudzba.OrderItems.Remove(item);
            Narudzba.GrandTotal = _orderService.GetGrandTotalPrice(Narudzba);
            lblGrandTotal.Text = Narudzba.GrandTotal.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbQuantity_TextChanged(object sender, EventArgs e)
        {
            if(tbQuantity.Text != "")
            {
                int quantity = Int32.Parse(tbQuantity.Text);
                tbTotalPrice.Text = (quantity * Int32.Parse(tbUnitPrice.Text)).ToString();


            }

        }

        private void tbTotalPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGrandTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Narudzba.UserOrder = InMemorydb.LoggedIn;
            InMemorydb.Orders.Add(Narudzba);
            MessageBox.Show("Uspiješno izdat Račun");
            _printService.PrintToTxt(Narudzba,"Racun.txt");
            Order NovaNarudzba = new Order();
            NovaNarudzba.OrderItems.Clear();
            NovaNarudzba.UserOrder = InMemorydb.LoggedIn;
            NovaNarudzba.GrandTotal = 0;
            OrderGrid.Rows.Clear();
            lblGrandTotal.Text = 0.ToString();


        }
    }
}
