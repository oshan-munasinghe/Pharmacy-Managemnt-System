using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace admin.AddingNew
{
    public partial class token_sh : Form
    {
        public token_sh()
        {
            InitializeComponent();
            fillcombo_tkn();
        }
        //SqlConnection con = new SqlConnection("Data Source=OSHAN-PC\\SQLEXPRESS;Initial Catalog=Pharmacy_mgmt_system_DB;Integrated Security=True");
        static string connec = System.Configuration.ConfigurationManager.ConnectionStrings["connec"].ConnectionString;
        SqlConnection con = new SqlConnection(connec);

        private void fillcombo_tkn()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [token]", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                tokenIdSe.Items.Add(dr["Token_Id"].ToString());
                
            }
            con.Close();
        }
        private void tokenIdSe_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void searchdt() {
            try
            {
                con.Open();
                DataTable dt1 = new DataTable();
                SqlDataAdapter sda1 = new SqlDataAdapter("SELECT * FROM [Token] WHERE Token_Id LIKE '%" + tokenIdSe.Text + "%'", con);
                sda1.Fill(dt1);
                tokenGDv.DataSource = dt1;
                con.Close();
            }
            catch (Exception) { 
            
            }
        }
        private void display_d()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [token]", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            tokenGDv.AutoGenerateColumns = false;
            tokenGDv.DataSource = dt;
        }

        private void tokenGDv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void token_sh_Load(object sender, EventArgs e)
        {
            display_d();
           // userLblSh();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            display_d();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            searchdt();
            userLblSh();
            
        }

        private void userLblSh() {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM [token] where Token_Id='" + tokenIdSe.SelectedItem.ToString() + "'", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    userlbl.Text = dr["userid"].ToString();

                }
                con.Close();
            }
            catch(Exception) { 
            
            }
        }
    }
}
