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
    public partial class AddcostCat : Form
    {
        public AddcostCat()
        {
            InitializeComponent();
            fillcombo_costType();
        }
        //SqlConnection con = new SqlConnection("Data Source=OSHAN-PC\\SQLEXPRESS;Initial Catalog=Pharmacy_mgmt_system_DB;Integrated Security=True");
        static string connec = System.Configuration.ConfigurationManager.ConnectionStrings["connec"].ConnectionString;
        SqlConnection con = new SqlConnection(connec);

        private void AddCostBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO [ref] VALUES('" + costCatBox.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Succesfully Added Data ", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            costCatBox.Text = "";
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void fillcombo_costType()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [ref]", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                costCatBox.Items.Add(dr["cost_type"].ToString());
            }
            con.Close();

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            //delete
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM [ref] WHERE cost_type ='" + costCatBox.Text + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("sucessfully Deleted");
            costCatBox.Text = "";
        }
    }
}
