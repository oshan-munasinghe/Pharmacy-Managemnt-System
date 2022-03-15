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
using System.Configuration;

namespace admin
{
    public partial class Store_keeper : Form
    {
        public Store_keeper(String user)
        {
            InitializeComponent();
            userdemo.Text = user;
            usernameLblgt();
        }
        static string connec = System.Configuration.ConfigurationManager.ConnectionStrings["connec"].ConnectionString;
        SqlConnection con = new SqlConnection(connec);

        private void Store_keeper_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    conStateLBL.Text = "Connected";
                    conStateLBL.ForeColor = Color.Green;
                }
                else
                {
                    conStateLBL.Text = "Not Connected";
                    conStateLBL.ForeColor = Color.Red;
                }
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
                DialogResult result = MessageBox.Show("Not connected Database", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Retry)
                {
                    Application.Restart();
                }
                else
                    Application.Exit();
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            suplierManagement1.Visible = true;
            suplierManagement1.BringToFront();
        }

        private void suplierManagement1_Load(object sender, EventArgs e)
        {
            suplierManagement1.Visible = false;
        }

        private void MedMgmtBtn_Click(object sender, EventArgs e)
        {
            medicineManagement1.Visible = true;
            medicineManagement1.BringToFront();
        }

        private void medicineManagement1_Load(object sender, EventArgs e)
        {
            medicineManagement1.Visible = false;

        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            uc_Dashboard1.Visible = true;
            uc_Dashboard1.BringToFront();
        }

        private void uc_Dashboard1_Load(object sender, EventArgs e)
        {

        }

        private void logoutlbl_Click(object sender, EventArgs e)
        {
            logoutlbl.Text = "logouting...";


            DialogResult result = MessageBox.Show("Are u sure Logout", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (result == DialogResult.Yes)
            {
                LoginForm lg = new LoginForm();
                lg.Show();
                this.Hide();
            }
            else
            {
                logoutlbl.Text = "_Logout";
            }
        }
        private void usernameLblgt()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [user] where username='" + userdemo.Text.ToString() + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                userLbl.Text = dr["name"].ToString();

            }


        }

        private void Store_keeper_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
