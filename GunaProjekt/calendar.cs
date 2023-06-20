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

        public static string inTable;


        private void Calendar_Load(object sender, EventArgs e)
        {
            string constrig = ("Data Source=localhost;port=3306;username=root;password=");
            MySqlConnection conn = new MySqlConnection(constrig);


           
        }

        public string GetDataFromDatabase()
        {
            string query = "SELECT * FROM _sample.soci_task; "; // Replace with your column and table names

            using (MySqlConnection connection = new MySqlConnection(constrig))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        return result.ToString();
                    }
                }
            }

            return string.Empty; // Return empty string if no data found
        }

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
                label3.ForeColor = Color.Silver;
                label3.ForeColor = Color.LightGray;
                //label4.ForeColor = Color.Red;
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

        private void Calendar_Load_1(object sender, EventArgs e)
        {
            conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT u_task FROM _sample.soci_task; ", conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                int y = 43;
                while (reader.Read())
                {

                string taskName = reader.GetString(0);
                    //guna2CheckBox2.Text = taskName;

                //string taskName2 = reader.GetString(1);
                //guna2CheckBox6.Text = taskName2;

                Guna2CheckBox box = new Guna2CheckBox();
                box.Text = taskName;
                box.Parent = guna2GradientPanel3;
                box.Location = new Point(28, y);
                box.AutoSize = true;
                guna2GradientPanel3.Controls.Add(box);
                box.BringToFront();

                Font font = new Font("Segoe UI Semibold", 15.75f, FontStyle.Bold);
                box.Font = font;
                box.ForeColor = Color.MidnightBlue;
                //box.TabStop = true;
                //box.TabIndex = 80;
                //Controls.Add(box);

                //string taskName3 = reader.GetString(2);
                //guna2CheckBox4.Text = taskName3;
                y += 35;
                
                //if (box.Checked)
                //{
                  //  string insertQuery = "INSERT INTO _sample.soci_task(u_checked) VALUES('1')";
                  //  MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn);
                   // insertCmd.ExecuteNonQuery();
                //}
                //else{
                  //  string insertQuery = "INSERT INTO _sample.soci_task(u_checked) VALUES('0')";
                   // MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn);
                    //insertCmd.ExecuteNonQuery();
                //}

               
            }
            conn.Close();
        }
   

        private void guna2CheckBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label6_load(object sender, EventArgs e)
        {
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT u_task FROM _sample.soci_task; ", conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            int y = 43;
            while (reader.Read())
            {

                string taskName = reader.GetString(0);

                Guna2CheckBox box = new Guna2CheckBox();
                box.Text = taskName;
                box.Parent = guna2GradientPanel3;
                box.Location = new Point(28, y);
                box.AutoSize = true;
                guna2GradientPanel3.Controls.Add(box);
                box.BringToFront();

                Font font = new Font("Segoe UI Semibold", 15.75f, FontStyle.Bold);
                box.Font = font;
                box.ForeColor = Color.MidnightBlue;
                y += 35;


            }
            conn.Close();
        }

        private void guna2CheckBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}

