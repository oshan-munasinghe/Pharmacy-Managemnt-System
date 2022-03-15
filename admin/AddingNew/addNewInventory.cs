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
    public partial class addNewInventory : Form
    {
        public addNewInventory()
        {
            InitializeComponent();
            fillcombo_user();
        }
        //SqlConnection con = new SqlConnection("Data Source=OSHAN-PC\\SQLEXPRESS;Initial Catalog=Pharmacy_mgmt_system_DB;Integrated Security=True");
        static string connec = System.Configuration.ConfigurationManager.ConnectionStrings["connec"].ConnectionString;
        SqlConnection con = new SqlConnection(connec);
        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
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
                recerved_person.Items.Add(dr["username"].ToString());
            }
            con.Close();
        }
        private void I_SubmitBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO [inventory] VALUES('" + InvId.Text + "','" + invName.Text + "','" + Invdiscription.Text + "','" + invQuantity.Text + "','" + recerved_person.SelectedItem.ToString() + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Succesfully Added Data ", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            invClear();
        }

        private void I_clerBtn_Click(object sender, EventArgs e)
        {
            invClear(); 
        }
        private void invClear() {
            InvId.Clear();
            invName.Clear();
            Invdiscription.Clear();
            invQuantity.Clear();
            recerved_person.Text = "";

        }
    }
}
