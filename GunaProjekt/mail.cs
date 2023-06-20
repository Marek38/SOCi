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
    public partial class Mail : Form
    {

        public Mail()
        {
            InitializeComponent();

        }
        static string constrig = ("Data Source=localhost;port=3306;username=root;password=");
        static MySqlConnection conn = new MySqlConnection(constrig);

        public static string inTable;

        private void Mail_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(guna2TextBox2.Text))
            {
                guna2GradientButton7.Visible = false;
                guna2GradientButton8.Visible = false;
            }



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
            this.Close();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string taskName = guna2TextBox2.Text;
                int taskChecked = 0;

                if (string.IsNullOrEmpty(taskName))
                {
                    label4.ForeColor = Color.WhiteSmoke;
                    label5.ForeColor = Color.WhiteSmoke;
                    label5.ForeColor = Color.Red;
                }
                else
                {
                    label4.ForeColor = Color.WhiteSmoke;
                    label5.ForeColor = Color.WhiteSmoke;

                    string taskQuery = "SELECT text FROM _sample.soci_messagebox WHERE text = '" + guna2TextBox2.Text + "'";
                    MySqlCommand selectCmd = new MySqlCommand(taskQuery, conn);
                    selectCmd.Parameters.AddWithValue("@taskName", taskName);

                    MySqlDataReader selectReader = selectCmd.ExecuteReader();

                    if (selectReader.HasRows)
                    {
                        selectReader.Close();
                        label4.ForeColor = Color.WhiteSmoke;
                        label5.ForeColor = Color.WhiteSmoke;
                        label4.ForeColor = Color.Red;
                        conn.Close();
                    }
                    else
                    {
                        selectReader.Close();

                        string insertQuery = "INSERT INTO _sample.soci_messagebox(text) VALUES('" + guna2TextBox2.Text + "'); ";
                        MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn);
                        insertCmd.Parameters.AddWithValue("@taskName", taskName);

                        insertCmd.ExecuteNonQuery();

                        string inTable = selectReader[taskName].ToString();
                        MessageBox.Show("Value from the database: " + inTable);
                        conn.Close();
                        label4.ForeColor = Color.WhiteSmoke;
                        label5.ForeColor = Color.WhiteSmoke;


                    }
                    }

                
            }
            catch (Exception)
            {
                conn.Close();
                label4.ForeColor = Color.WhiteSmoke;
                label5.ForeColor = Color.WhiteSmoke;
            }



        }
        private void Mail_Load_1(object sender, EventArgs e)
        {


        }

    private void guna2Panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientButton8_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton9_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(guna2TextBox2.Text))
            {
                guna2GradientButton7.Visible = true;
                guna2GradientButton8.Visible = true;
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM _sample.soci_messagebox;", conn);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string message = reader.GetString(1);
                    guna2GradientButton7.Text = message;
                }
                reader.Close();
                conn.Close();
                guna2GradientButton8.Text = "Fuu to znie ako vážny problem... Bolo by lepšie si o tom pohovoriť na videohovore";
            }        

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            string url = "https://meet.google.com/ifb-beex-nbu"; 
            System.Diagnostics.Process.Start(url);
        }
    }
   
}
