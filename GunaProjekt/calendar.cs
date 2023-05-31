using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using static Org.BouncyCastle.Math.EC.ECCurve;

namespace GunaProjekt
{
    public partial class Calendar : Form
    {
        public Calendar()
        {
            InitializeComponent();
        }
        static string constrig = ("Data Source=localhost;port=3306;username=root;password=");
        static MySqlConnection conn = new MySqlConnection(constrig);
        private object guna2CheckBox1;

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var dashboardform = new Dashboard();
            dashboardform.Closed += (s, args) => this.Close();
            dashboardform.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var maillowform = new Mail();
            maillowform.Closed += (s, args) => this.Close();
            maillowform.Show();
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

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
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
                    label3.ForeColor = Color.Silver;
                    label4.ForeColor = Color.LightGray;
                    label4.ForeColor = Color.Red;
                }
                else
                {
                    label3.ForeColor = Color.Silver;
                    label4.ForeColor = Color.LightGray;

                    string taskQuery = "SELECT u_task FROM _sample.soci_task WHERE u_task = '" + guna2TextBox1.Text + "'";
                    MySqlCommand selectCmd = new MySqlCommand(taskQuery, conn);
                    selectCmd.Parameters.AddWithValue("@taskName", taskName);

                    MySqlDataReader selectReader = selectCmd.ExecuteReader();

                    if (selectReader.HasRows)
                    {
                        selectReader.Close();
                        label3.ForeColor = Color.Silver;
                        label4.ForeColor = Color.LightGray;
                        label3.ForeColor = Color.Red;
                    }
                    else
                    {
                        selectReader.Close();

                        string insertQuery = "INSERT INTO _sample.soci_task(u_task) VALUES('" + guna2TextBox1.Text + "'); ";
                        //string insert_chekedQuery = "INSERT INTO _sample.soci_task(u_checked) VALUES('" + taskChecked + "'); ";
                        MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn);
                        //MySqlCommand insertCmmd = new MySqlCommand(insert_chekedQuery, conn);
                        insertCmd.Parameters.AddWithValue("@taskName", taskName);
                        //insertCmmd.Parameters.AddWithValue("@taskName", 0);

                        insertCmd.ExecuteNonQuery();
                        //insertCmmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                conn.Close();
                label3.ForeColor = Color.Silver;
                label3.ForeColor = Color.LightGray;
                label4.ForeColor = Color.Red;
                //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }


        private void label4_Click(object sender, EventArgs e)
        {
            label4.ForeColor = Color.LightGray;
        }

        private void guna2GradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Silver;
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void guna2CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
 
        }
 
        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void Calendar_Load(object sender, EventArgs e)
        {
            
        }

        private void Calendar_Load_1(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            string constrig = "Data Source=localhost;port=3306;username=root;password=";

            using (SqlConnection connection = new SqlConnection(constrig))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM _sample.soci_task", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    // Získajte hodnoty z databázy
                    bool isChecked = (bool)reader["soci_task"];

                    // Priradte hodnoty k Guna CheckBoxu
                    //guna2CheckBox1.Checked = isChecked;
                }

                reader.Close();
                connection.Close();
            }
        }
    }
}

