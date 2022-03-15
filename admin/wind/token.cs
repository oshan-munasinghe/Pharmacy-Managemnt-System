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
    public partial class token : UserControl
    {
        public token()
        {
            InitializeComponent();
            display_dtk();
            fillcombo_med();
            fillcombo_user();
            load_TK_data();
        }
        SqlConnection con = new SqlConnection("Data Source=OSHAN-MX\\SQLEXPRESS;Initial Catalog=Pharmacy_mgmt_system_DB;Integrated Security=True");
        int medqtyx = 0;
        private void fillcombo_med()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [medicine]", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                medIdtxt.Items.Add(dr["medicine_id"].ToString());
                qtymaxLbl.Text = dr["med_quantity"].ToString();
                medqtyx = Convert.ToInt16(qtymaxLbl.Text);
            }
            con.Close();
        }

        private void fillcombo_user()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [user] ", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                userID.Items.Add(dr["name"].ToString());
                
            }
            con.Close();
        }

        private void display_dtk()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [medicine]", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            med_DGV_tk.AutoGenerateColumns = false;
            med_DGV_tk.DataSource = dt;
        }
        
        private void medIdtxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [medicine] where medicine_id='" + medIdtxt.SelectedItem.ToString() + "'", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {

                mednameTxt.Text = dr["medicine_name"].ToString();
                //qtytxt.Text = dr["med_quantity"].ToString();
                priceTxt.Text = dr["unit_price"].ToString();
                qtymaxLbl.Text = dr["med_quantity"].ToString();
                medqtyx = Convert.ToInt16(qtymaxLbl.Text);
                
            }
            con.Close();
        }

        private void med_DGV_tk_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                medIdtxt.Text = med_DGV_tk.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch (Exception) { 
                
            }
            }
        
        private void addBtn_Click(object sender, EventArgs e)
        {
            int ff = Convert.ToInt32(qtytxt.Text);
            if (ff <= medqtyx)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO [token] VALUES('" + tokenTxt.Text + "','" + medIdtxt.Text + "','" + mednameTxt.Text + "','" + qtytxt.Text + "','" + priceTxt.Text + "','" + dateTxt.Value + "','"+userID.Text+"')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Succesfully Added List ", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                int tt = medqtyx - ff;
                con.Open();
                SqlCommand cmd1 = new SqlCommand("UPDATE [medicine] SET [med_quantity] =  '" + tt + "'WHERE [medicine_id] =  '" + medIdtxt.SelectedItem.ToString() + "'", con);
                cmd1.ExecuteNonQuery();
                con.Close();
            }
            else {
                MessageBox.Show("Not Enough Stock", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                qtytxt.Text = "0";

                
                
            }
        }

        private void load_TK_data() {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [token]", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            TokenDGV.AutoGenerateColumns = false;
            TokenDGV.DataSource = dt;
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            load_TK_data();
            display_dtk();
        }

        private void priceTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You sure Delete this ?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
            if (result == DialogResult.Yes)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM [token] WHERE Token_Id='" + tokenTxt.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("sucessfully Deleted");
                load_TK_data();
                
            }
        
        }

        private void TokenDGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tokenTxt.Text = TokenDGV.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (catSaleBox.Text == "medicine_name")
            {
                con.Open();
                DataTable dt1 = new DataTable();
                SqlDataAdapter sda1 = new SqlDataAdapter("SELECT * FROM [medicine] WHERE medicine_name LIKE '%" + SearchBox.Text + "%'", con);
                sda1.Fill(dt1);
                med_DGV_tk.DataSource = dt1;
                med_DGV_tk.AutoGenerateColumns = false;
                con.Close();
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void clear_btn() { 
        
        }
         
    }
}
