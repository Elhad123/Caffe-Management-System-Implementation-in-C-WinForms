using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cafe.Data;
using cafe.Services;
using cafe.Usercontrol;

namespace cafe
{
    public partial class Dashboard : Form
    {
        private readonly AuthService _authService;
        private readonly OrderService _orderService;
        private readonly PrintService _printService;
        public Dashboard()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;         
            this.Padding = new Padding(2); // for border thickness
            SetRoundedRegion(40); // radius in pixels


        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int thickness = 2;
            Color borderColor = Color.FromArgb(235, 82, 4);

            using (Pen pen = new Pen(borderColor, thickness))
            {
                pen.Alignment = PenAlignment.Inset;
                e.Graphics.DrawRectangle(pen, 0, 0, this.Width - thickness, this.Height - thickness);
            }
        }

        public void SetRoundedRegion(int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            this.Region = new Region(path);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            SetRoundedRegion(25); // update region on resize
        }

        public Dashboard(String user)
        {
            InitializeComponent();
            _authService = new AuthService();
            _orderService = new OrderService();
            _printService = new PrintService();
            if (InMemorydb.LoggedIn != null)
            {
                btnDodaj.Show();
                btnAzuriraj.Show();
                
            }
            else 
            {
                btnDodaj.Hide();
                btnAzuriraj.Hide();

            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _authService.LogOut();
            Login fm = new Login();
            this.Hide();
            fm.Show();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            uC_Dodaj1.Visible = true;
            uC_Dodaj1.BringToFront();
           

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblLoggedn.Text += InMemorydb.LoggedIn.Name;
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            uC_UpdateItems1.Visible = true;
            uC_UpdateItems1.BringToFront();
            uC_UpdateItems1.LoadData(); 
        }

        private void btnNarudzba_Click(object sender, EventArgs e)
        {
            uC_Narudzba1.Visible = true;
            uC_Narudzba1.BringToFront();
            uC_Narudzba1.LoadData();
        }

        private void uC_Narudzba1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(39, 40, 51);
            panel2.BackColor = Color.FromArgb(39, 40, 51);
            this.BackColor = Color.FromArgb(39, 40, 51);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Order> orders = _orderService.GetAllOrders();
            foreach (Order order in orders)
            {
                _printService.PrintToTxt(order,"IzvještajSmjene.txt",true);  
            }
            MessageBox.Show("Uspješno Generisan Izvještaj Smjene!");
        }
    }
}
