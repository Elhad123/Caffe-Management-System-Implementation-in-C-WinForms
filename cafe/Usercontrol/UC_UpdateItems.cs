using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using cafe.Data;
using cafe.Services;

namespace cafe.Usercontrol
{
    public partial class UC_UpdateItems : UserControl
    {
        private readonly ItemService _itemService;
        public UC_UpdateItems()
        {
            InitializeComponent();
            _itemService = new ItemService();
        }

        internal void LoadData()
        {
            this.updateGrid.Rows.Clear();
            List<Item> list = _itemService.GetAll();
            foreach (Item item in list) {
                this.updateGrid.Rows.Add(item.Id,item.Category,item.Name,item.Price);
            }

            this.updateGrid.ClearSelection();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(updateGrid.SelectedRows.Count > 0) {

                // Get the first selected row
                DataGridViewRow selectedRow = updateGrid.SelectedRows[0];

                // Example: Get values from specific columns
                var id = selectedRow.Cells["ColumnID"].Value.ToString();
                var name = selectedRow.Cells["ColumnName"].Value.ToString();
                var category = selectedRow.Cells["ColumnCategory"].Value.ToString();
                var price = selectedRow.Cells["ColumnPrice"].Value.ToString();

                tbName.Enabled = true;
                tbName.Text = name;
                cbCategory.Enabled = true;
                cbCategory.Text = category;
                tbPrice.Enabled = true;
                tbPrice.Text = price;
                btnUpdate.Enabled = true;
                tbID.Text = id;

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            item.Name = tbName.Text;
            item.Category = cbCategory.Text;
            item.Price = Int32.Parse(tbPrice.Text);
            item.Id = Int32.Parse(tbID.Text);
            _itemService.Update(item);
            MessageBox.Show("Uspješno ažurirano!");


            tbName.Enabled = false;
            tbName.Text = "";
            cbCategory.Enabled = false;
            cbCategory.Text = "";
            tbPrice.Enabled = false;
            tbPrice.Text = "";
            btnUpdate.Enabled = false;
            tbID.Text = "";

            this.LoadData();   
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (updateGrid.SelectedRows.Count > 0)
            {

                // Get the first selected row
                DataGridViewRow selectedRow = updateGrid.SelectedRows[0];

                var id = Int32.Parse(selectedRow.Cells["ColumnID"].Value.ToString());
                var name = selectedRow.Cells["ColumnName"].Value.ToString();
                var category = selectedRow.Cells["ColumnCategory"].Value.ToString();
                var price = Double.Parse(selectedRow.Cells["ColumnPrice"].Value.ToString());

                _itemService.Delete(new Item(id,name,category,price));
            MessageBox.Show("Uspješno ažurirano!");

                this.LoadData();

            }
        }

        private void UC_UpdateItems_Load(object sender, EventArgs e)
        {
            
        }
    }
}
