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
namespace admin.wind
{
    public partial class viewSale : UserControl
    {
        public viewSale()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=OSHAN-MX\\SQLEXPRESS;Initial Catalog=Pharmacy_mgmt_system_DB;Integrated Security=True");
       

        private void viewSale_Load(object sender, EventArgs e)
        {
            Vi_sale_DGV.ColumnHeadersDefaultCellStyle.BackColor = Color.Purple;
            Vi_sale_DGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            Vi_sale_DGV.EnableHeadersVisualStyles = false;
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            display_d();
        }
       // int c ,n= 0;
        private void display_d()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [sale]", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Vi_sale_DGV.AutoGenerateColumns = false;
            Vi_sale_DGV.DataSource = dt;
           
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            tokenIDSearch();
            
        }

        private void tokenIDSearch() {

            if (catSaleBox.Text == "token_id")
            {
                con.Open();
                DataTable dt1 = new DataTable();
                SqlDataAdapter sda1 = new SqlDataAdapter("SELECT * FROM [sale] WHERE token_id LIKE '%" + SearchBox.Text + "%'", con);
                sda1.Fill(dt1);
                Vi_sale_DGV.DataSource = dt1;
                Vi_sale_DGV.AutoGenerateColumns = false;
                con.Close();
            }
            else if (catSaleBox.Text == "sale_id")
            {
                con.Open();
                DataTable dt1 = new DataTable();
                SqlDataAdapter sda1 = new SqlDataAdapter("SELECT * FROM [sale] WHERE sale_id LIKE '%" + SearchBox.Text + "%'", con);
                sda1.Fill(dt1);
                Vi_sale_DGV.DataSource = dt1;
                Vi_sale_DGV.AutoGenerateColumns = false;
                con.Close();
            }
            else if (catSaleBox.Text == "medicine_id")
            {
                con.Open();
                DataTable dt1 = new DataTable();
                SqlDataAdapter sda1 = new SqlDataAdapter("SELECT * FROM [sale] WHERE medicine_id LIKE '%" + SearchBox.Text + "%'", con);
                sda1.Fill(dt1);
                Vi_sale_DGV.DataSource = dt1;
                Vi_sale_DGV.AutoGenerateColumns = false;
                con.Close();
            }
            else if (catSaleBox.Text == "pharmacist_id")
            {
                con.Open();
                DataTable dt1 = new DataTable();
                SqlDataAdapter sda1 = new SqlDataAdapter("SELECT * FROM [sale] WHERE pharmacist_id LIKE '%" + SearchBox.Text + "%'", con);
                sda1.Fill(dt1);
                Vi_sale_DGV.DataSource = dt1;
                Vi_sale_DGV.AutoGenerateColumns = false;
                con.Close();
            }
            else if (catSaleBox.Text == "cashier_id")
            {
                con.Open();
                DataTable dt1 = new DataTable();
                SqlDataAdapter sda1 = new SqlDataAdapter("SELECT * FROM [sale] WHERE cashier_id LIKE '%" + SearchBox.Text + "%'", con);
                sda1.Fill(dt1);
                Vi_sale_DGV.DataSource = dt1;
                Vi_sale_DGV.AutoGenerateColumns = false;
                con.Close();
            }
            else {
                MessageBox.Show("Not Matched Selected Data'\nCheck data and Try again","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void reportGenBtn_Click(object sender, EventArgs e)
        {
            Report.Sale_Report SR = new Report.Sale_Report();
            SR.Show();
        }

        
       
    }
}
