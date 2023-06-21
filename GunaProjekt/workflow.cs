using Guna.UI2.WinForms;
using Microsoft.Win32;
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
using System.Windows.Media.Media3D;
using System.Xml;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Font = iTextSharp.text.Font;

namespace GunaProjekt
{
    public partial class Workflow : Form
    {
        public Workflow()
        {
            InitializeComponent();
        }
        static string constrig = ("Data Source=localhost;port=3306;username=root;password=");
        static MySqlConnection conn = new MySqlConnection(constrig);
        
        private void Form1_Load(object sender, EventArgs e)
        {
            string project = "";
            MySqlCommand cmd = new MySqlCommand("SELECT u_projekt FROM _sample.soci_users WHERE u_name= '" +loginin.name+ "'", conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string message = reader.GetString(1);
                project = message;
                guna2GradientCircleButton1.FillColor = Color.Green;
                guna2VProgressBar15.FillColor = Color.Red;
                
            }
            reader.Close();
            conn.Close();
            Console.WriteLine(project);
            //label1.Text = "Hodnotenie práce" + project;
        }
       
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var mailform = new Mail();
            mailform.Closed += (s, args) => this.Close();
            mailform.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var calendarform = new Calendar();
            calendarform.Closed += (s, args) => this.Close();
            calendarform.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var dashboardform = new Dashboard();
            dashboardform.Closed += (s, args) => this.Close();
            dashboardform.Show();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2ProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            {
                string meno = loginin.name;
                int percenta = 75;

                // Názov súboru PDF
                string pdfFileName = "C:/Users/teso/OneDrive/Počítač/soc_results.pdf";

                // Vytvorenie nového dokumentu PDF
                Document document = new Document();

                // Vytvorenie writer-a pre zápis do PDF súboru
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(pdfFileName, FileMode.Create));

                // Otvorenie dokumentu
                document.Open();

                Paragraph nadpis = new Paragraph("Proces vytvorenia SOC", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18));
                nadpis.Alignment = Element.ALIGN_CENTER;
                document.Add(nadpis);

                // Pridanie obsahu
                Paragraph obsah = new Paragraph();
                obsah.Alignment = Element.ALIGN_LEFT;

                obsah.Add(new Chunk("Mily " + meno + ",", FontFactory.GetFont(FontFactory.HELVETICA, 12)));
                obsah.Add(Environment.NewLine + Environment.NewLine);
                obsah.Add(new Chunk("S velkou radostou a hrdostou sa obraciam na teba, aby som ti srdecne blahozelal k dokonceniu tvojho SOC (Stredoskolska odborna cinnost). Tvoje usilie, odhodlanie a oddanost k tomuto projektu si zasluzia obdiv a uznanie.", FontFactory.GetFont(FontFactory.HELVETICA, 12)));
                obsah.Add(Environment.NewLine + Environment.NewLine);
                obsah.Add(new Chunk("Sledovat ta v poslednych mesiacoch, ako si sa venoval svojej praci a obetoval neurekom hodin na vyskum, analyzu a tvorbu svojho projektu, bolo pre mna nesmierne potesujuce. Tvoj zapal a vasen pre dann temu boli viditelne vo vsetkych aspektoch tvojej prace.", FontFactory.GetFont(FontFactory.HELVETICA, 12)));
                obsah.Add(Environment.NewLine + Environment.NewLine);
                obsah.Add(new Chunk("Viem, ze SOC nebolo lahkou ulohou a vyzadovalo si vela usilia, obeti a discipliny. Musel si prekonat mnozstvo vyziev, najst riesenia a pokracovať aj vtedy, ked sa veci zdali nemozne. Tvoja vytrvalost a odhodlanie sú zárukou tvojho uspechu nielen v ramci SOC, ale aj v buducnosti.", FontFactory.GetFont(FontFactory.HELVETICA, 12)));
                obsah.Add(Environment.NewLine + Environment.NewLine);

                //obsah.Add(new Chunk("Výsledok tvojej práce:", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14)));
                document.Add(obsah);

                // Nastavenie písma
                Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
                Font headerFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);
                Font contentFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);

                // Vytvorenie nadpisu
                Paragraph title = new Paragraph("Vysledky SOC", titleFont);
                title.Alignment = Element.ALIGN_CENTER;

                // Pridanie nadpisu do dokumentu
                document.Add(title);

                // Vytvorenie tabuľky
                PdfPTable table = new PdfPTable(3);
                table.WidthPercentage = 100;
                table.SpacingBefore = 20;

                // Nastavenie hlavičiek tabuľky
                table.AddCell(new PdfPCell(new Phrase("Nazov tasku", headerFont)));
                table.AddCell(new PdfPCell(new Phrase("Tebou prideleny stav", headerFont)));
                table.AddCell(new PdfPCell(new Phrase("Konecny stav", headerFont)));

                // Naplnenie tabuľky s hodnotami
                table.AddCell(new PdfPCell(new Phrase("Task 1", contentFont)));
                table.AddCell(new PdfPCell(new Phrase("In progress", contentFont)));
                table.AddCell(new PdfPCell(new Phrase("Completed", contentFont)));

                table.AddCell(new PdfPCell(new Phrase("Task 2", contentFont)));
                table.AddCell(new PdfPCell(new Phrase("Not started", contentFont)));
                table.AddCell(new PdfPCell(new Phrase("Pending", contentFont)));

                table.AddCell(new PdfPCell(new Phrase("Task 3", contentFont)));
                table.AddCell(new PdfPCell(new Phrase("In progress", contentFont)));
                table.AddCell(new PdfPCell(new Phrase("In progress", contentFont)));

                // Pridanie tabuľky do dokumentu
                document.Add(table);

                // Pridanie informácie o percentuálnom dokončení SOČ
                Paragraph percentage = new Paragraph($"Dokoncene na: {percenta}%", contentFont);
                percentage.SpacingBefore = 20;
                document.Add(percentage);


                // Pridanie informácie o meno
                Paragraph thanks = new Paragraph($"Vela stastia do buducna {meno}", contentFont);
                Paragraph name = new Paragraph($"SOCi", contentFont);
                document.Add(thanks);
                document.Add(name);

                // Uzavretie dokumentu
                document.Close();

                Console.WriteLine("Vysledky SOC boli uspesne exportovane do PDF suboru.");
                Console.ReadLine();
            }
        }


        private void Workflow_Load(object sender, EventArgs e)
        {

        }

        private void guna2VProgressBar15_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}