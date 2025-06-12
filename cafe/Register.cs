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

namespace cafe
{
    public partial class Register : Form
    {
        private readonly AuthService _authService;
        public Register()
        {
            _authService = new AuthService();
            InitializeComponent();
        }

        private void btnRegisterForm_Click(object sender, EventArgs e)
        {
            User New = _authService.Register(tbUsernameReg.Text, tbPasswordReg.Text);
            if (New != null)
            {

                MessageBox.Show("Uspijesno Registrovan!");
                Login ds = new Login();
                ds.Show();
                this.Hide();
            }
            else
            {
                tbPasswordReg.Text = "";
                tbUsernameReg.Text = "";
            }

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
