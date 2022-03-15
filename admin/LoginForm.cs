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
using app03;
using System.Configuration;

namespace admin
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        /*
         code for Sql connection initiate 
         */
        static string connec = System.Configuration.ConfigurationManager.ConnectionStrings["connec"].ConnectionString;
        SqlConnection con = new SqlConnection(connec);
       

       //SqlConnection con = new SqlConnection("Data Source=OSHAN-PC\\SQLEXPRESS;Initial Catalog=Pharmacy_mgmt_system_DB;Integrated Security=True");
        private void logBtnLogin_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda  = new SqlDataAdapter("SELECT COUNT(*) FROM [user] WHERE username='"+log_username.Text+"' and password = '"+log_password.Text+"'and user_role='"+log_userRole.Text+"' ",con);
           //Error corect user -> [user]
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                SqlDataAdapter sda1 = new SqlDataAdapter("SELECT user_role FROM [user] WHERE username='"+log_username.Text+"'and password='"+log_password.Text+"'", con);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                if (dt1.Rows[0][0].ToString() == "admin") {
                    Form1 admin = new Form1(log_username.Text);// login to admin
                    admin.Show();
                    this.Hide();
                }
                else if(dt1.Rows[0][0].ToString() == "pharmacist"){
                    //pharmacist form
                    Pharmasist ph = new Pharmasist(log_username.Text);
                    ph.Show();
                    this.Hide();
                }
                else if(dt1.Rows[0][0].ToString() == "cashier"){
                    cashier cs = new cashier(log_username.Text); //login cashier
                    //wind.Sale sl = new wind.Sale(log_username.Text);
                    cs.Show();
                    this.Hide();
                    
                    
                }

                else if (dt1.Rows[0][0].ToString() == "store_keeper")
                {
                    Store_keeper st = new Store_keeper(log_username.Text);//login store keeper
                    st.Show();
                    this.Hide();
                }

                clearData_login();
            }
            else {
                MessageBox.Show("Invalid Login Please Check Login Details ");
                //clearData_login();
            }
        }

        private void clearLog_Click(object sender, EventArgs e)
        {

            clearData_login();
        }

        private void clearData_login() {
            log_username.Clear();
            log_password.Clear();
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //
            
            //
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    
                }
               
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
                DialogResult result = MessageBox.Show("Not connected Database", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Hand);
                if (result == DialogResult.Retry)
                {
                    Application.Restart();
                }
                else
                    Application.Exit();
            }
        

        
        }//close loading page

        private void passCharSh_hi_CheckedChanged(object sender, EventArgs e)
        {
            if (passCharSh_hi.Checked)
            {
                log_password.PasswordChar = '\0';
            }
            else {
                log_password.PasswordChar='.';
                //log_password.UseSystemPasswordChar = true;
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
