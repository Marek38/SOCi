using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using MySql.Data.MySqlClient;
using System.Xml.Linq;

namespace GunaProjekt
{
    public partial class loginin : Form
    {
        public loginin()
        {
            InitializeComponent();

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        static string constrig = ("Data Source=localhost;port=3306;username=root;password=");
        static MySqlConnection con = new MySqlConnection(constrig);
        public static string name = "";
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                string query = "SELECT u_name, u_password FROM _sample.soci_users where u_name = '" + guna2TextBox1.Text + "'";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader sdr = cmd.ExecuteReader();
                if (guna2TextBox1.Text == "" && guna2TextBox2.Text == "")
                {
                    label4.ForeColor = Color.White;
                    label7.ForeColor = Color.White;
                    label8.ForeColor = Color.White;
                    label4.ForeColor = Color.Red;
                }
                else
                {
                    if (sdr.HasRows)
                    {
                        sdr.Read();

                        if (sdr["u_password"].Equals(guna2TextBox2.Text))
                        {
                            //MessageBox.Show("Login Successfull...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //userFullname = sdr["u_name"].ToString();
                            name = guna2TextBox1.Text;
                            this.Hide();
                            var Dashboardform = new main_dashboard();
                            Dashboardform.Closed += (s, args) => this.Close();
                            Dashboardform.Show();
                        }
                        else
                        {
                            //MessageBox.Show("Invalid Password...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            label4.ForeColor = Color.White;
                            label7.ForeColor = Color.White;
                            label8.ForeColor = Color.White;
                            label8.ForeColor = Color.Red;
                        }
                    }

                    else
                    {
                        //MessageBox.Show("Username is incorrect...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        label4.ForeColor = Color.White;
                        label7.ForeColor = Color.White;
                        label8.ForeColor = Color.White;
                        label7.ForeColor = Color.Red;
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2ToggleSwitch1.Checked == true)
            {
                guna2TextBox2.PasswordChar = default;
            }
            else if (guna2ToggleSwitch1.Checked == false)
            {
                guna2TextBox2.PasswordChar = '●';
            }
        }


        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var registerinform = new registerin();
            registerinform.Closed += (s, args) => this.Close();
            registerinform.Show();
        }

        private void guna2TextBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void loginin_Load(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox3_Click_1(object sender, EventArgs e)
        {
     
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var registerinform = new registerin();
            registerinform.Closed += (s, args) => this.Close();
            registerinform.Show();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            label5.ForeColor = Color.White;
            //meno
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            label6.ForeColor = Color.White;
            //udaje
        }

        private void label3_Click_2(object sender, EventArgs e)
        {
            label3.ForeColor = Color.White;
            //heslo
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var loadingform = new Loading();
            loadingform.Closed += (s, args) => this.Close();
            loadingform.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_2(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var loadingform = new Loading();
            loadingform.Closed += (s, args) => this.Close();
            loadingform.Show();
        }
    }
}
