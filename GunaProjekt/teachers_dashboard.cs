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
    public partial class teachers_dashboard : Form
    {
        public static teachers_dashboard Selff;
        public teachers_dashboard()
        {
            InitializeComponent();
            Selff = this;
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

            teachers_mainpanel.BorderRadius = 10;
            teachers_mainpanel.Controls.Add(childForm);
            teachers_mainpanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Selff.Hide();
            var calendarform = new main_dashboard();
            calendarform.Closed += (s, args) => this.Close();
            calendarform.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            openchildFrom(new Zajdo());
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            openchildFrom(new Ronnie());
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            openchildFrom(new Adam());
        }

        private void guna2GradientPanel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Tomas_Load(object sender, EventArgs e)
        {
            openchildFrom(new Ronnie());
        }
    }
}
