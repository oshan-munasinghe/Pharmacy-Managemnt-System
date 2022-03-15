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
    public partial class InventoryManagement : UserControl
    {
        public InventoryManagement()
        {
            InitializeComponent();
            fillcombo_user();
        }

        SqlConnection con = new SqlConnection("Data Source=OSHAN-MX\\SQLEXPRESS;Initial Catalog=Pharmacy_mgmt_system_DB;Integrated Security=True");

        private void Inv_Mg_Add_btn_Click_1(object sender, EventArgs e)
        {
            addNewInventory invt = new addNewInventory();
            invt.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void fillcombo_user()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [user]", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                I_ReservePerson.Items.Add(dr["username"].ToString());
            }
            con.Close();
            
        }

        private void InventoryManagement_Load(object sender, EventArgs e)
        {
            I_Mg_DGV.ColumnHeadersDefaultCellStyle.BackColor = Color.Purple;
            I_Mg_DGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            I_Mg_DGV.EnableHeadersVisualStyles = false;
        }
        private void display_d()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [inventory]", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            I_Mg_DGV.AutoGenerateColumns = false;
            I_Mg_DGV.DataSource = dt;
        }
        private void I_Mg_Inventry_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                I_ID.Text = I_Mg_DGV.SelectedRows[0].Cells[0].Value.ToString();
                I_Name.Text = I_Mg_DGV.SelectedRows[0].Cells[1].Value.ToString();
                inv_Discription.Text = I_Mg_DGV.SelectedRows[0].Cells[2].Value.ToString();
                I_Quantitytext.Text = I_Mg_DGV.SelectedRows[0].Cells[3].Value.ToString();
                I_ReservePerson.Text = I_Mg_DGV.SelectedRows[0].Cells[4].Value.ToString();
            }
            catch (Exception) { 
            
            }
           
        }

        private void I_RefreshBtn_Click(object sender, EventArgs e)
        {
            display_d();
        }

        private void I_DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You sure Delete this ?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(" DELETE FROM [inventory] WHERE inventory_id='" + I_ID.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("sucessfully Deleted");
                display_d();
                clear_d();
            }
            else
            {

            }
        }
        private void clear_d() {
            I_ID.Clear();
            I_Name.Clear();
            inv_Discription.Clear();
            I_Quantitytext.Clear();
            I_ReservePerson.Text = "";
        }

        private void I_ClearBtn_Click(object sender, EventArgs e)
        {
            clear_d();
        }

        private void I_ReservePerson_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void I_UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE [inventory] SET [inventory_name] = '" + I_Name.Text + "' ,[discription] =  '" + inv_Discription.Text + "',[quantity] =  '" + I_Quantitytext.Text + "' ,[username] =  '" + I_ReservePerson.Text + "'WHERE [inventory_id] =  '" + I_ID.Text+ "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("sucessfully Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                display_d();
                clear_d();
            }
            catch (Exception)
            {

            }
        }

        private void I_genReportBtn_Click(object sender, EventArgs e)
        {
            Report.InvReport invReport = new Report.InvReport();
            invReport.Show();
        }
    }
}
/*
 DELETE FROM [inventory] WHERE '"+ I_ID.Text + "'
 */