using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cafe.Data;
using cafe.Services;

namespace cafe
{
    public partial class Login : Form
    {

        private readonly AuthService _authService;
        public Login()
        {
            _authService = new AuthService();
            InitializeComponent();
            InMemorydb.Seed();
        }

        private void btnGuest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dashboard ds = new Dashboard("Guest");
            ds.Show();
            this.Hide();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User LoggedInUser = _authService.Login(txtUsername.Text, txtPassword.Text);
            if (LoggedInUser == null)
            {
                MessageBox.Show("Neispravno korisničko ime ili lozinka!");
                txtUsername.Clear();
                txtPassword.Clear();
            }
            else 
            {
                Dashboard ds = new Dashboard("Admin");
                ds.Show();
                this.Hide();
            }
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(39, 40, 51);
            btnGuest.LinkColor = Color.FromArgb(235, 82, 4);
            txtElhadsCafe.ForeColor = Color.FromArgb(235, 82, 4);
            btnLogin.BackColor = Color.FromArgb(235, 82, 4);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register rg = new Register();
            rg.Show();
            this.Hide();
        }
    }
}
