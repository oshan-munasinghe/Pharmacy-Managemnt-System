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
    public partial class AddSuplier : Form
    {
        public AddSuplier()
        {
            InitializeComponent();
        }
        //SqlConnection con = new SqlConnection("Data Source=OSHAN-PC\\SQLEXPRESS;Initial Catalog=Pharmacy_mgmt_system_DB;Integrated Security=True");
        static string connec = System.Configuration.ConfigurationManager.ConnectionStrings["connec"].ConnectionString;
        SqlConnection con = new SqlConnection(connec);

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO [suplier] VALUES('" + SuplierID.Text + "','" + SuplierNAme.Text + "','" + SuplierAddress.Text + "','" + SuplierMail.Text + "','" + SupContactNo.Text + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Succesfully Added Data ", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear_d();
            }
            catch (Exception)
            {
                MessageBox.Show("Check Details And try again ", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void clear_d() {
            SuplierID.Clear();
            SuplierNAme.Clear();
            SuplierAddress.Clear();
            SuplierMail.Clear();
            SupContactNo.Clear();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            clear_d();
        }
    }
}
