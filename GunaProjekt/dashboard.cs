using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using Openapi.Weibo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GunaProjekt
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
            static string constrig = ("Data Source=localhost;port=3306;username=root;password=");
            static MySqlConnection conn = new MySqlConnection(constrig);


        private void moveImageBox(object sender)
        {
            //Guna2Button b = (Guna2Button)sender;
            //imgSlider.Location = new Point(b.Location.X + 34, b.Location.Y - 25);
            //imgSlider.SendToBack();
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //moveImageBox(sender);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            
            this.Hide();
            var calendarform = new Calendar();
            calendarform.Closed += (s, args) => this.Close();
            calendarform.Show();



        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var mailform = new Mail();
            mailform.Closed += (s, args) => this.Close();
            mailform.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var workflowform = new Workflow();
            workflowform.Closed += (s, args) => this.Close();
            workflowform.Show();
        }

        private void dashboard_EnabledChanged(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
