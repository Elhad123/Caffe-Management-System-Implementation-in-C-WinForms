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
    public partial class UC_Dodaj : UserControl
    {
        private  ItemService _itemservice;

        public UC_Dodaj()
        {
            InitializeComponent();
            _itemservice = new ItemService();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Item items = new Item();
            items.Category = cbCategory.Text;
            items.Name = tbName.Text;
            items.Price = Int32.Parse(tbPrice.Text);
            _itemservice.Add(items);
            MessageBox.Show("Uspješno dodano!");
        }

        private void UC_Dodaj_Load(object sender, EventArgs e)
        {

        }
    }
}
