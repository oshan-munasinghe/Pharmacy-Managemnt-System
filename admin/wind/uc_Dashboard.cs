using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace admin.wind
{
    public partial class uc_Dashboard : UserControl
    {
        public uc_Dashboard()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=OSHAN-MX\\SQLEXPRESS;Initial Catalog=Pharmacy_mgmt_system_DB;Integrated Security=True");
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uc_Dashboard_Load(object sender, EventArgs e)
        {
            //timer
            timerstat();
            piechart1();
            barchart();

        }
        private void timerstat() {
            timerst.Start();
        
        }
        private void barchart() {
            //barchart Code
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT [med_quantity] FROM [medicine] ", con);
            SqlDataReader reader = cmd.ExecuteReader();
            Series sr = new Series();
            while (reader.Read())
            {
                chart1.Series[0].Points.AddY(reader.GetInt32(0));
                

            }
        }
        private void piechart1() {
            //chart2.Titles.Add("Top Selling");
           chart2.Series["s1"].IsValueShownAsLabel = false;
           
            chart2.Series["s1"].Points.AddXY("1", "20");
            chart2.Series["s1"].Points.AddXY("2", "25");
            chart2.Series["s1"].Points.AddXY("3", "35");
            chart2.Series["s1"].Points.AddXY("4", "10");
            chart2.Series["s1"].Points.AddXY("5", "4");
            chart2.Series["s1"].Points.AddXY("6", "6");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userPnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void timerst_Tick(object sender, EventArgs e)
        {
            int val = Convert.ToInt16(salesct.Text);
            int val1 = Convert.ToInt16(actu.Text);
            int val2 = Convert.ToInt16(instock.Text);
            int val3 = Convert.ToInt16(outofstock.Text);

            if (val1 < 1)
            {
                val1 += 1;
                actu.Text = val1.ToString();
            }
            //sales
            if (val < 561)
            {
                val += 4;
                salesct.Text = val.ToString();
            }
            if (val2 < 2120)
            {
                val2 += 16;
                instock.Text = val2.ToString();
            }
            if (val3 < 10523)
            {
                val3 += 75;
                outofstock.Text = val3.ToString();
            }
            else
            {
                timerst.Stop();
            }
            //users
           
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void timercircle_Tick(object sender, EventArgs e)
        {
            //empcirc.Increment(1);
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void TechSupport_Click(object sender, EventArgs e)
        {
            AddingNew.TechSupport ts = new AddingNew.TechSupport();
            ts.Show();
        }
    }
}
