using MySql.Data.MySqlClient;
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
    public partial class Mail : Form
    {

        public Mail()
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

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var calendarform = new Calendar();
            calendarform.Closed += (s, args) => this.Close();
            calendarform.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var workflowform = new Workflow();
            workflowform.Closed += (s, args) => this.Close();
            workflowform.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Mail_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
