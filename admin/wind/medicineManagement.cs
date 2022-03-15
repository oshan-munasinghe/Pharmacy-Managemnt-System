using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using admin.AddingNew;
using System.Data.SqlClient;



namespace admin.wind
{
    public partial class medicineManagement : UserControl
    {
        public medicineManagement()
        {
            InitializeComponent();
           //fillcombo_user();
            fillcombo_sup();
        }
        SqlConnection con = new SqlConnection("Data Source=OSHAN-MX\\SQLEXPRESS;Initial Catalog=Pharmacy_mgmt_system_DB;Integrated Security=True");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            AddMedicine ad_med = new AddMedicine();
            ad_med.Show();
        }

        private void medicineManagement_Load(object sender, EventArgs e)
        {
            M_Mg_DataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Purple;
            M_Mg_DataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            M_Mg_DataGridView.EnableHeadersVisualStyles = false;
        }

        private void M_refreshBtn_Click(object sender, EventArgs e)
        {
            display_d();
        }

        private void display_d() {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [medicine]", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            M_Mg_DataGridView.AutoGenerateColumns = false;
            M_Mg_DataGridView.DataSource = dt;
        }

        private void fillcombo_user() {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [medicine]", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                user_id_combo.Items.Add(dr["category"].ToString());
            }
            con.Close();
        }
        private void fillcombo_sup()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [suplier]", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                suplier_combo.Items.Add(dr["suplier_id"].ToString());
            }
            con.Close();
        }

        private void M_Mg_DataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //populate data to table
            try
            {
                M_id.Text = M_Mg_DataGridView.SelectedRows[0].Cells[0].Value.ToString();
                M_name.Text = M_Mg_DataGridView.SelectedRows[0].Cells[1].Value.ToString();
                suplier_combo.Text = M_Mg_DataGridView.SelectedRows[0].Cells[2].Value.ToString();
                M_mfd.Text = M_Mg_DataGridView.SelectedRows[0].Cells[3].Value.ToString();
                M_EXP.Text = M_Mg_DataGridView.SelectedRows[0].Cells[4].Value.ToString();
                user_id_combo.Text = M_Mg_DataGridView.SelectedRows[0].Cells[5].Value.ToString();
                M_Uprice.Text = M_Mg_DataGridView.SelectedRows[0].Cells[6].Value.ToString();
                M_quantity.Text = M_Mg_DataGridView.SelectedRows[0].Cells[7].Value.ToString();
            }
            catch (Exception) { 
            
            }
        }

        private void M_clearBtn_Click(object sender, EventArgs e)
        {
            clear_MD();
        }
        private void clear_MD() {
            M_id.Clear();
            M_name.Clear();
            suplier_combo.Text = " ";
            M_mfd.Text = "";
            M_EXP.Text = "";
            user_id_combo.Text = " ";
            M_Uprice.Clear();
            M_quantity.Clear();
            catSaleBox.Text = "";
            SearchBox.Clear();
        }

        private void MdeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You sure Delete this ?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM [medicine] WHERE medicine_id='" + M_id.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("sucessfully Deleted");
                display_d();
                clear_MD();
            }
            else
            {

            }
        }

        private void M_UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE [medicine] SET [medicine_name] = '" + M_name.Text + "' ,[supplier_id] =  '" + suplier_combo.Text + "',[mf_date] =  '" + M_mfd.Value + "' ,[exp_date] =  '" + M_EXP.Value + "',[category] =  '" + user_id_combo.Text + "' ,[unit_price] =  '" + M_Uprice.Text + "' ,[med_quantity] =  '" + M_quantity.Text + "'WHERE [medicine_id] =  '" + M_id.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("sucessfully Updated","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                display_d();
                clear_MD();
            }
            catch (Exception) { 
            
            }
           
        }

        private void searchBtn1_Click(object sender, EventArgs e)
        {
            if (catSaleBox.Text == "medicine_id")
            {
                con.Open();
                DataTable dt1 = new DataTable();
                SqlDataAdapter sda1 = new SqlDataAdapter("SELECT * FROM [medicine] WHERE medicine_id LIKE '%" + SearchBox.Text + "%'", con);
                sda1.Fill(dt1);
                M_Mg_DataGridView.DataSource = dt1;
                M_Mg_DataGridView.AutoGenerateColumns = false;
                con.Close();
            }
            else if (catSaleBox.Text == "medicine_name")
            {
                con.Open();
                DataTable dt1 = new DataTable();
                SqlDataAdapter sda1 = new SqlDataAdapter("SELECT * FROM [medicine] WHERE medicine_name LIKE '%" + SearchBox.Text + "%'", con);
                sda1.Fill(dt1);
                M_Mg_DataGridView.DataSource = dt1;
                M_Mg_DataGridView.AutoGenerateColumns = false;
                con.Close();
            }
            else if (catSaleBox.Text == "supplier_id")
            {
                con.Open();
                DataTable dt1 = new DataTable();
                SqlDataAdapter sda1 = new SqlDataAdapter("SELECT * FROM [medicine] WHERE supplier_id LIKE '%" + SearchBox.Text + "%'", con);
                sda1.Fill(dt1);
                M_Mg_DataGridView.DataSource = dt1;
                M_Mg_DataGridView.AutoGenerateColumns = false;
                con.Close();
            }
            else if (catSaleBox.Text == "category")
            {
                con.Open();
                DataTable dt1 = new DataTable();
                SqlDataAdapter sda1 = new SqlDataAdapter("SELECT * FROM [medicine] WHERE category LIKE '%" + SearchBox.Text + "%'", con);
                sda1.Fill(dt1);
                M_Mg_DataGridView.DataSource = dt1;
                M_Mg_DataGridView.AutoGenerateColumns = false;
                con.Close();
            }
            else
            {
                MessageBox.Show("Not Matched Selected Data'\nCheck data and Try again", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void user_id_combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void M_genReportBtn_Click(object sender, EventArgs e)
        {
            Report.medGenReport rep = new Report.medGenReport();
            rep.Show();
        }
    }

}
