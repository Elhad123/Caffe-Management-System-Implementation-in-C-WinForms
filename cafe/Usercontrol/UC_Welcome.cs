using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafe.Usercontrol
{
    public partial class UC_Welcome : UserControl
    {
        public UC_Welcome()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        int a = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (a == 0)
            {
                labelBanner.Location = new Point(90, 367);
                labelBanner.ForeColor = Color.Orange;
                a++;
            }
            else if (a == 1)
            {
                labelBanner.Location = new Point(600, 367);
                labelBanner.ForeColor = Color.Blue;
                a++;
            }
            else if (a == 2)
            {
                labelBanner.Location = new Point(298, 425);
                labelBanner.ForeColor = Color.White;
                a = 0;
            }
        }

        private void UC_Welcome_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }
    }
}
