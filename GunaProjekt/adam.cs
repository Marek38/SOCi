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
    public partial class Adam : Form
    {
        public Adam()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var dashboardform = new Dashboard();
            dashboardform.Closed += (s, args) => this.Close();
            dashboardform.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var tomasdform = new Tomas();
            tomasdform.Closed += (s, args) => this.Close();
            tomasdform.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ronnieform = new Ronnie();
            ronnieform.Closed += (s, args) => this.Close();
            ronnieform.Show();
        }

        private void Adam_Load(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
