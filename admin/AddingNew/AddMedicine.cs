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
    public partial class AddMedicine : Form
    {
        public AddMedicine()
        {
            InitializeComponent();
            //fillcombo_user();
            fillcombo_sup();
        }
        //SqlConnection con = new SqlConnection("Data Source=OSHAN-PC\\SQLEXPRESS;Initial Catalog=Pharmacy_mgmt_system_DB;Integrated Security=True");
        static string connec = System.Configuration.ConfigurationManager.ConnectionStrings["connec"].ConnectionString;
        SqlConnection con = new SqlConnection(connec);

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
                userIdbox.Items.Add(dr["username"].ToString());
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
                supIdbox.Items.Add(dr["suplier_id"].ToString());
            }
            con.Close();
        }

        private void M_submitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO [medicine] VALUES('" + M_Medicine_ID.Text + "','" + M_Medicine_Name.Text + "','" + supIdbox.Text + "','" + M_MFD.Value + "','" + M_EXP.Value + "','" + M_UnitPrice.Text + "','" + M_Quantity.Text + "','" + userIdbox.Text + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Succesfully Added Medicine ", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception) { 
            }
        }
    }
}
