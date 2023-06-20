using Guna.UI2.WinForms;
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
    public partial class main_dashboard : Form
    {
        public static main_dashboard Self;
        public main_dashboard()
        {
            InitializeComponent();
            Self=this;
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }
        public static Form activeform = null;
        public void openchildFrom(Form childForm)
        {
            if (activeform != null)
            {
                activeform.Close();
            }
            activeform = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            mainpanel.BorderRadius = 10;
            mainpanel.Controls.Add(childForm);
            mainpanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            openchildFrom(new Dashboard());
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            openchildFrom(new Calendar());
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            openchildFrom(new Mail());
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            openchildFrom(new Workflow());
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void main_dashboard_Load(object sender, EventArgs e)
        {
            openchildFrom(new Dashboard());
        }
    }
}
