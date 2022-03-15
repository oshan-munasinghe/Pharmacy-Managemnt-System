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

namespace app03
{
    public partial class cashier : Form
    {
        public cashier(String user)
        {
            InitializeComponent();
            userdemo.Text = user;
            usernameLblgt();
        }
        static string connec = System.Configuration.ConfigurationManager.ConnectionStrings["connec"].ConnectionString;
        SqlConnection con = new SqlConnection(connec);
        private void Form1_Load(object sender, EventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            uc_Dashboard1.Visible = true;
            uc_Dashboard1.BringToFront();

        }
        
        

        private void label2_Click(object sender, EventArgs e)
        {
            //logout label

            label2.Text = "logouting...";


            DialogResult result = MessageBox.Show("Are u sure Logout", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (result == DialogResult.Yes)
            {
                admin.LoginForm lg = new admin.LoginForm();
                lg.Show();
                this.Hide();
            }
            else
            {
                label2.Text = "_Logout";
            }
        }

        private void userControl21_Load(object sender, EventArgs e)
        {

        }

        private void uc_Dashboard1_Load(object sender, EventArgs e)
        {
           // uc_Dashboard1.Visible = false;

        }

        private void viewSale1_Load(object sender, EventArgs e)
        {
            viewSale1.Visible = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void CreateSaleBtn_Click(object sender, EventArgs e)
        {
            sale1.Visible = true;
            sale1.BringToFront();
            
        }

        private void sale1_Load(object sender, EventArgs e)
        {
            sale1.Visible = false;
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

        private void cashier_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ViewSaleBtn_Click(object sender, EventArgs e)
        {
            viewSale1.Visible = true;
            viewSale1.BringToFront();
        }
    }
}
