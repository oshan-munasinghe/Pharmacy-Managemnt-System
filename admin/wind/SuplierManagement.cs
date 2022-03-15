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
    public partial class SuplierManagement : UserControl
    {
        public SuplierManagement()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=OSHAN-MX\\SQLEXPRESS;Initial Catalog=Pharmacy_mgmt_system_DB;Integrated Security=True");
        private void SuplierManagement_Load(object sender, EventArgs e)
        {
            S_suplierDGV.ColumnHeadersDefaultCellStyle.BackColor = Color.Purple;
            S_suplierDGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            S_suplierDGV.EnableHeadersVisualStyles = false;

        }

        private void S_addbtn_Click(object sender, EventArgs e)
        {
            AddingNew.AddSuplier adsup = new AddingNew.AddSuplier();
            adsup.Show();
        }

        private void display_d()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [suplier]", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            S_suplierDGV.AutoGenerateColumns = false;
            S_suplierDGV.DataSource = dt;
        }

        private void clear_data() { 
             S_IDSuplier.Clear();
             S_NameSuplier.Clear();
             S_Address.Clear();
             S_Email.Clear();
             S_contactNo.Clear();
        }
        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            display_d();
        }

        private void S_suplierDGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            S_IDSuplier.Text = S_suplierDGV.SelectedRows[0].Cells[0].Value.ToString();
            S_NameSuplier.Text = S_suplierDGV.SelectedRows[0].Cells[1].Value.ToString();
            S_Address.Text = S_suplierDGV.SelectedRows[0].Cells[2].Value.ToString();
            S_Email.Text = S_suplierDGV.SelectedRows[0].Cells[3].Value.ToString();
            S_contactNo.Text = S_suplierDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void S_deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You sure Delete this ?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
            if (result == DialogResult.Yes)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM [suplier] WHERE suplier_id='" + S_IDSuplier.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("sucessfully Deleted");
                display_d();
                clear_data();
            }
        }

        private void S_clesrBtn_Click(object sender, EventArgs e)
        {
            clear_data();
        }

        private void S_updateBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE [suplier] SET [suplier_name] =  '" + S_NameSuplier.Text + "' , suplier_address= '" + S_Address.Text + "', suplier_email= '" + S_Email.Text + "', suplier_contact= '" + S_contactNo.Text + "'  WHERE [suplier_id] = '" + S_IDSuplier.Text + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("sucessfully Updated","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            display_d();
            clear_data();
        }

        private void searchBtn1_Click(object sender, EventArgs e)
        {
            if (catSaleBox.Text == "suplier_id")
            {
                con.Open();
                DataTable dt1 = new DataTable();
                SqlDataAdapter sda1 = new SqlDataAdapter("SELECT * FROM [suplier] WHERE suplier_id LIKE '%" + SearchBox.Text + "%'", con);
                sda1.Fill(dt1);
                S_suplierDGV.DataSource = dt1;
                S_suplierDGV.AutoGenerateColumns = false;
                con.Close();
            }
            else if (catSaleBox.Text == "suplier_name")
            {
                con.Open();
                DataTable dt1 = new DataTable();
                SqlDataAdapter sda1 = new SqlDataAdapter("SELECT * FROM [suplier] WHERE suplier_name LIKE '%" + SearchBox.Text + "%'", con);
                sda1.Fill(dt1);
                S_suplierDGV.DataSource = dt1;
                S_suplierDGV.AutoGenerateColumns = false;
                con.Close();
            }
        }
    }
}
