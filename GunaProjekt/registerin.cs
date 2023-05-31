using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace GunaProjekt
{
    public partial class registerin : Form
    {
        public registerin()
        {
            InitializeComponent();
        }

       static string constrig = ("Data Source=localhost;port=3306;username=root;password=");
        static MySqlConnection conn = new MySqlConnection(constrig);

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            var logininform = new loginin();
            logininform.Closed += (s, args) => this.Close();
            logininform.Show();
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {


            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string name_query = "SELECT u_name FROM _sample.soci_users WHERE u_name = '" + guna2TextBox3.Text + "'";
                MySqlCommand cmd = new MySqlCommand(name_query, conn);
                MySqlDataReader sdr = cmd.ExecuteReader();
                if (guna2TextBox3.Text == "" && guna2TextBox6.Text == "" && guna2TextBox1.Text == "" && guna2TextBox5.Text == "")
                {
                    label1.ForeColor = Color.White;
                    label2.ForeColor = Color.White;
                    label4.ForeColor = Color.White;
                    label5.ForeColor = Color.White;
                    label7.ForeColor = Color.White;
                    label6.ForeColor = Color.Red;
                }
                else
                {
                    label1.ForeColor = Color.White;
                    label2.ForeColor = Color.White;
                    label4.ForeColor = Color.White;
                    label5.ForeColor = Color.White;
                    label7.ForeColor = Color.White;
                    label6.ForeColor = Color.White;
                    if (sdr.HasRows)
                    {
                        label1.ForeColor = Color.White;
                        label2.ForeColor = Color.White;
                        label4.ForeColor = Color.White;
                        label7.ForeColor = Color.White;
                        label6.ForeColor = Color.White;
                        label5.ForeColor = Color.Red;
                    }
                    else
                    {
                        sdr.Close();
                        string mail_query = "SELECT u_mail FROM _sample.soci_users WHERE u_mail = '" + guna2TextBox6.Text + "'";
                        MySqlCommand cnmd = new MySqlCommand(mail_query, conn);
                        MySqlDataReader sdrr = cnmd.ExecuteReader();
                        if (sdrr.HasRows)
                        {
                            label2.ForeColor = Color.White;
                            label4.ForeColor = Color.White;
                            label5.ForeColor = Color.White;
                            label6.ForeColor = Color.White;
                            label7.ForeColor = Color.White;
                            label1.ForeColor = Color.Red;
                        }
                        else
                        {
                            label1.ForeColor = Color.White;
                            label2.ForeColor = Color.White;
                            label4.ForeColor = Color.White;
                            label5.ForeColor = Color.White;
                            label7.ForeColor = Color.White;
                            label6.ForeColor = Color.White;
                            
                            string password = guna2TextBox5.Text;
                            int passwordlenght = password.Length;
                            if (passwordlenght < 8)
                            {
                                label1.ForeColor = Color.White;
                                label4.ForeColor = Color.White;
                                label5.ForeColor = Color.White;
                                label7.ForeColor = Color.White;
                                label6.ForeColor = Color.White;
                                label2.ForeColor = Color.Red;
                            }
                            else
                            {
                                sdrr.Close();
                                string projekt_query = "SELECT u_projekt FROM _sample.soci_users WHERE u_projekt = '" + guna2TextBox1.Text + "'";
                                MySqlCommand cnmnd = new MySqlCommand(projekt_query, conn);
                                MySqlDataReader sdrrr = cnmnd.ExecuteReader();
                                if (sdrrr.HasRows)
                                {
                                    label2.ForeColor = Color.White;
                                    label4.ForeColor = Color.Red;
                                    label5.ForeColor = Color.White;
                                    label6.ForeColor = Color.White;
                                    label7.ForeColor = Color.White;
                                    label1.ForeColor = Color.White;
                                }
                                else
                                {
                                    
                                    label1.ForeColor = Color.White;
                                    label2.ForeColor = Color.White;
                                    label4.ForeColor = Color.White;
                                    label5.ForeColor = Color.White;
                                    label7.ForeColor = Color.White;
                                    label6.ForeColor = Color.White;
                                 

                                    string vali_name = guna2TextBox3.Text;
                                    string vali_mail = guna2TextBox6.Text;
                                    string vali_projekt = guna2TextBox1.Text;
                                    string vali_password = guna2TextBox5.Text;
                                    string n_pattern = @"^[a-zA-Z0-9]+$";
                                    string e_pattern1 = @"^[a-zA-Z0-9]+.[a-zA-Z0-9]+@[a-zA-Z0-9]+.[a-zA-Z]{2,}$";
                                    string e_pattern2 = @"^[a-zA-Z0-9]+@[a-zA-Z0-9]+.[a-zA-Z]{2,}$";

                                    if (Regex.IsMatch(vali_name, n_pattern))
                                    {
                                        if ((Regex.IsMatch(vali_mail, e_pattern1)) || (Regex.IsMatch(vali_mail, e_pattern2)))
                                        {
                                            sdrrr.Close();
                                            string vklad_query = "INSERT INTO _sample.soci_users(u_name,u_mail,u_projekt,u_password) VALUES('" + vali_name + "', '" + vali_mail + "', '" + vali_projekt + "', '" + vali_password + "');";
                                            MySqlCommand cmmd = new MySqlCommand(vklad_query, conn);
                                            MySqlDataReader sdrrrr = cmmd.ExecuteReader();
                                            sdrrrr.Close();
                                        }
                                        else
                                        {
                                            
                                            MessageBox.Show("zle ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                    
                                    else
                                    {
                                        
                                        MessageBox.Show("cele zle ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                        conn.Close();
                        


                    }
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label1.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                label5.ForeColor = Color.White;
                label6.ForeColor = Color.White;
                label7.ForeColor = Color.Red;
                label2.ForeColor = Color.White;
            }
        }
    

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var logininform = new loginin();
            logininform.Closed += (s, args) => this.Close();
            logininform.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void registerin_Load(object sender, EventArgs e)
        {

        }
    }
}
