using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GunaProjekt
{
    public partial class Ronnie : Form
    {
        public Ronnie()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var dashboardform = new Dashboard();
            dashboardform.Closed += (s, args) => this.Close();
            dashboardform.Show();
        }

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var tomasform = new teachers_dashboard();
            tomasform.Closed += (s, args) => this.Close();
            tomasform.Show();
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var adamform= new Adam();
            adamform.Closed += (s, args) => this.Close();
            adamform.Show();
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
