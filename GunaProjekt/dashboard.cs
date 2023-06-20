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
using System.Web.UI.WebControls;
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

                label1.Text = "Ahoj " + loginin.name + "!";
            

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

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            openchildFrom(new Mail());
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

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
            this.Hide();
            main_dashboard.Self.Hide();
            var form = new teachers_dashboard();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void guna2CirclePictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            main_dashboard.Self.Hide();
            var form = new teachers_dashboard();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            main_dashboard.Self.Hide();
            var form = new teachers_dashboard();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string taskName = guna2TextBox1.Text;
                int taskChecked = 0;

                if (string.IsNullOrEmpty(taskName))
                {
                    label10.ForeColor = Color.Silver;
                    label11.ForeColor = Color.LightGray;
                    label11.ForeColor = Color.Red;
                }
                else
                {
                    label10.ForeColor = Color.Silver;
                    label11.ForeColor = Color.LightGray;

                    string taskQuery = "SELECT u_task FROM _sample.soci_task WHERE u_task = '" + guna2TextBox1.Text + "'";
                    MySqlCommand selectCmd = new MySqlCommand(taskQuery, conn);
                    selectCmd.Parameters.AddWithValue("@taskName", taskName);

                    MySqlDataReader selectReader = selectCmd.ExecuteReader();

                    if (selectReader.HasRows)
                    {
                        selectReader.Close();
                        label10.ForeColor = Color.Silver;
                        label11.ForeColor = Color.LightGray;
                        label10.ForeColor = Color.Red;
                    }
                    else
                    {
                        selectReader.Close();

                        string insertQuery = "INSERT INTO _sample.soci_task(u_task) VALUES('" + guna2TextBox1.Text + "'); ";
                        MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn);
                        insertCmd.Parameters.AddWithValue("@taskName", taskName);

                        insertCmd.ExecuteNonQuery();

                        string inTable = selectReader[taskName].ToString();
                        MessageBox.Show("Value from the database: " + inTable);

                    }

                }
            }
            catch (Exception)
            {
                conn.Close();
                label10.ForeColor = Color.Silver;
                label11.ForeColor = Color.LightGray;
                //label4.ForeColor = Color.Red;
                //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
