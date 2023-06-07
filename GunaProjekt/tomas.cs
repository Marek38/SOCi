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
    public partial class Tomas : Form
    {
        public Tomas()
        {
            InitializeComponent();
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

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var adamform = new Adam();
            adamform.Closed += (s, args) => this.Close();
            adamform.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ronnieform = new Ronnie();
            ronnieform.Closed += (s, args) => this.Close();
            ronnieform.Show();
        }
    }
}
