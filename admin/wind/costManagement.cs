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
    public partial class costManagement : UserControl
    {
        public costManagement()
        {
            InitializeComponent();
            fillcombo_user();
        }
        SqlConnection con = new SqlConnection("Data Source=OSHAN-MX\\SQLEXPRESS;Initial Catalog=Pharmacy_mgmt_system_DB;Integrated Security=True");

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
                userBox.Items.Add(dr["username"].ToString());
            }
            con.Close();

        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void costManagement_Load(object sender, EventArgs e)
        {
            cost_Mg_DataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Purple;
            cost_Mg_DataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            cost_Mg_DataGridView.EnableHeadersVisualStyles = false;
        }

        

        private void C_addCostBtn_Click(object sender, EventArgs e)
        {
            AddingNew.AddNewCost adc = new AddingNew.AddNewCost();
            adc.Show();

        }
        private void clear() {
            cost_Mg_CostTypeBox.Clear();
            cost_Mg_AmountBox.Clear();
            cost_Mg_DiscriptionBox.Clear();
            userBox.Text = "";
        }
        private void C_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void C_RefreshBtn_Click(object sender, EventArgs e)
        {
            display_d();
        }

        private void display_d() {
            
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [cost]",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cost_Mg_DataGridView.AutoGenerateColumns = false;
            cost_Mg_DataGridView.DataSource = dt;
            
        }

        private void cost_Mg_DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cost_Mg_DataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                cost_Mg_CostTypeBox.Text = cost_Mg_DataGridView.SelectedRows[0].Cells[0].Value.ToString();
                cost_Mg_AmountBox.Text=cost_Mg_DataGridView.SelectedRows[0].Cells[1].Value.ToString();
                cost_Mg_DiscriptionBox.Text =cost_Mg_DataGridView.SelectedRows[0].Cells[2].Value.ToString();
                userBox.Text = cost_Mg_DataGridView.SelectedRows[0].Cells[3].Value.ToString();
                
            }
            catch (Exception) { }
        }

        private void C_Update_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE [cost] SET [userid] = '" + userBox.Text +"' ,[cost_price] =  '" + cost_Mg_AmountBox.Text + "',[discription] =  '" + cost_Mg_DiscriptionBox.Text + "' WHERE [cost_type] =  '" + cost_Mg_CostTypeBox.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("sucessfully Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                display_d();
                clear();
            }
            catch (Exception)
            {

            }
        }

        private void C_Delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You sure Delete this ?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(" DELETE FROM [cost] WHERE discription='" + cost_Mg_DiscriptionBox.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("sucessfully Deleted");
                display_d();
                clear();
            }
            else
            {

            }
        }

    }
}
