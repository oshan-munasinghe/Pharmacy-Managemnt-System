using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace admin
{
    public partial class Form1 : Form
    {
        public Form1(String user)
        {
            InitializeComponent();
            usrLbl.Text = user;
            usernameLblgt();
            usrLbl.Visible = false;
        }
        static string connec = System.Configuration.ConfigurationManager.ConnectionStrings["connec"].ConnectionString;
        SqlConnection con = new SqlConnection(connec);

        private void label1_Click(object sender, EventArgs e)
        {
            adminProfile1.Visible = true;
            adminProfile1.BringToFront();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            uc_Dashboard1.Visible = true;
            uc_Dashboard1.BringToFront();
        }

        private void uc_Dashboard1_Load(object sender, EventArgs e)
        {
            uc_Dashboard1.Visible = true;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            user_management1.Visible = true;
            user_management1.BringToFront();
        }

        private void userManagement1_Load(object sender, EventArgs e)
        {

        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            medicineManagement1.Visible = true;
            medicineManagement1.BringToFront();
        }

        private void medicineManagement1_Load(object sender, EventArgs e)
        {
            medicineManagement1.Visible = false;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            inventoryManagement1.Visible = true;
            inventoryManagement1.BringToFront();
        }

        private void inventoryManagement1_Load(object sender, EventArgs e)
        {
            inventoryManagement1.Visible = false;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            viewSale1.Visible = true;
            viewSale1.BringToFront();
        }

        private void viewSale1_Load(object sender, EventArgs e)
        {
            viewSale1.Visible = false;
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            costManagement1.Visible = true;
            costManagement1.BringToFront();

        }

        private void costManagement1_Load(object sender, EventArgs e)
        {
            costManagement1.Visible = false;
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {
            gunaLabel1.Text = "logouting...";
            
            
            DialogResult result = MessageBox.Show("Are u sure Logout","Logout",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                LoginForm lg = new LoginForm();
                lg.Show();
                this.Hide();
            }
            else {
                gunaLabel1.Text = "_Logout";
            }
        }

        private void adminProfile1_Load(object sender, EventArgs e)
        {
            adminProfile1.Visible = false;
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            suplierManagement1.Visible = true;
            suplierManagement1.BringToFront();
        }

        private void suplierManagement1_Load(object sender, EventArgs e)
        {
            suplierManagement1.Visible = true;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void costManagement1_Load_1(object sender, EventArgs e)
        {

        }

        private void userLabel_Click(object sender, EventArgs e)
        {

        }

        private void Contlbl_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            
            /*Connection state */

            try{
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
         catch (Exception ){
             //MessageBox.Show(ex.Message);
             DialogResult result =  MessageBox.Show("Not connected Database","Warning",MessageBoxButtons.RetryCancel ,MessageBoxIcon.Asterisk);
             if (result == DialogResult.Retry)
             {
                 Application.Restart();
             }
             else
                 Application.Exit();
           }
        }

        //private void user_management1_Load(object sender, EventArgs e)
        //{
            
        //}

        private void user_management1_Load_1(object sender, EventArgs e)
        {
            user_management1.Visible = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void usernameLblgt() //user fullname show in window
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [user] where username='" + usrLbl.Text.ToString() + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                userLabel.Text = dr["name"].ToString();

            }


        }
    }
}
