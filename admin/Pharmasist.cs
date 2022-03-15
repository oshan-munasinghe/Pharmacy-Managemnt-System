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

namespace admin
{
    public partial class Pharmasist : Form
    {
        public Pharmasist(String user)
        {
            InitializeComponent();
            usrDemo.Text = user;
            usernameLblgt();
            usrDemo.Visible = false;
        }
        static string connec = System.Configuration.ConfigurationManager.ConnectionStrings["connec"].ConnectionString;
        SqlConnection con = new SqlConnection(connec);
        private void Pharmasist_Load(object sender, EventArgs e)
        {
           WindowState = FormWindowState.Maximized;

            
            
            /*Connection state */

            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    Contlbl.Text = "Connected";
                    Contlbl.ForeColor = Color.Green;
                }
                else
                {
                    Contlbl.Text = "Not Connected";
                    Contlbl.ForeColor = Color.Red;
                }
            }
            catch(Exception){}

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Ph_mDMgmtBtn_Click(object sender, EventArgs e)
        {
            medicineManagement1.Visible = true;
            medicineManagement1.BringToFront();
        }

        private void medicineManagement1_Load(object sender, EventArgs e)
        {
            medicineManagement1.Visible = false;
        }

        private void Ph_dashboardBtn_Click(object sender, EventArgs e)
        {
            uc_Dashboard1.Visible = true;
            uc_Dashboard1.BringToFront();
        }

        private void uc_Dashboard1_Load(object sender, EventArgs e)
        {
            //uc_Dashboard1.Visible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //logout label
            label5.Text = "logouting...";


            DialogResult result = MessageBox.Show("Are u sure Logout", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                LoginForm lg = new LoginForm();
                lg.Show();
                this.Hide();
            }
            else
            {
                label5.Text = "_Logout";
            }
        }

        private void ph_tolkecCr_btn_Click(object sender, EventArgs e)
        {
            token1.Visible = true;
            token1.BringToFront();
        }

        private void token1_Load(object sender, EventArgs e)
        {
            token1.Visible = false;
        }

        private void Pharmasist_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void usernameLblgt()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [user] where username= '"+usrDemo.Text+"'",con);
            cmd.ExecuteNonQuery();
            con.Close();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                usrLbl.Text = dr["name"].ToString();

            }


        }
    }
}
