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
    public partial class addNewUser : Form
    {
        
        public addNewUser()
        {
            InitializeComponent();
        }

        static string connec = System.Configuration.ConfigurationManager.ConnectionStrings["connec"].ConnectionString;
        SqlConnection con = new SqlConnection(connec);

     
        private void addNewUser_Load(object sender, EventArgs e)
        {

        }

        private void N_submitBtn_Click(object sender, EventArgs e)
        {
            if (N_EmpBox.Text != "" && N_UserName.Text != "" && N_Password.Text != "" && N_Name.Text != "")
            {
                MC.mUserManagement usm = new MC.mUserManagement();
                usm.add(N_EmpBox.Text, N_Name.Text, N_Nic.Text, N_contNo.Text, N_Address.Text, N_Email.Text, N_userRole.Text, N_UserName.Text, N_Password.Text);
                string err = usm.error;
                if (err == null)
                {
                    MessageBox.Show("Succesfully Added Data ", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (err != null)
                {
                   // MessageBox.Show("Check Details :  \n1. Duplicate details \n2. Unfilled TextField \n  Retry ", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    MessageBox.Show("System goes to bad behaviour😒☹️\nRetry or Restart System\n If will not success contact Developer Team\n...  ", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else {
                MessageBox.Show("Not Accept Empty Value ", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void N_cler_btn_Click(object sender, EventArgs e)
        {
            N_EmpBox.Clear();
            N_Name.Clear();
            N_Nic.Clear();
            N_contNo.Clear();
            N_Email.Clear();
            N_Address.Clear();
            N_Password.Clear();
            N_UserName.Clear();
            N_userRole.SelectedItem = "";
        }
    }
}
