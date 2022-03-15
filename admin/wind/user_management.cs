using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using admin.MC; //- fom MC folder

//Re-Stuctured 2022.02.07
namespace admin.wind
{
    public partial class user_management : UserControl
    {
        public user_management()
        {
            InitializeComponent();
        }

        MC.mUserManagement usm = new MC.mUserManagement();
        
        private void user_management_Load(object sender, EventArgs e)
        {
            //table header color change
            User_DGV.ColumnHeadersDefaultCellStyle.BackColor = Color.Purple;
            User_DGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            User_DGV.EnableHeadersVisualStyles = false;
           // display_d();
        }

        private void U_Refresh_Click(object sender, EventArgs e)
        {
            display_d(); 
            
        }

        //function for table data display
        private void display_d() {
            MC.mUserManagement usm = new MC.mUserManagement();// create object from mUserManagement Class
            List<mUserManagement> ul = usm.get_user_data();
            User_DGV.AutoGenerateColumns = false;
            User_DGV.DataSource = ul;
        }

        private void U_clearBtn_Click(object sender, EventArgs e)
        {
            clear_data();
        }
        private void clear_data()
        {
            U_EmpNo.Clear();
            U_Name.Clear();
            U_Nic.Clear();
            U_contactNo.Clear();
            U_address.Clear();
            U_email.Clear();
            U_usrRole.Text = "";
           
        }
      
        private void User_DGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //table data populate to text boxes
            try
            {
                U_EmpNo.Text = User_DGV.SelectedRows[0].Cells[0].Value.ToString();
                U_Name.Text = User_DGV.SelectedRows[0].Cells[1].Value.ToString();
                U_Nic.Text = User_DGV.SelectedRows[0].Cells[2].Value.ToString();
                U_contactNo.Text = User_DGV.SelectedRows[0].Cells[3].Value.ToString();
                U_address.Text = User_DGV.SelectedRows[0].Cells[4].Value.ToString();
                U_email.Text = User_DGV.SelectedRows[0].Cells[5].Value.ToString();
                U_usrRole.Text = User_DGV.SelectedRows[0].Cells[6].Value.ToString();
            }
            catch (Exception) { 
                
            }
        }
        //delete
        private void U_DeleteBtn_Click(object sender, EventArgs e)
        {
            string empNo = U_EmpNo.Text.ToString();
            if (empNo == "")
            {
                MessageBox.Show("Check Emp No  ", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are You sure Delete this ?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                /*                                       message body                    mesagebox header           buttons              icon*/
                if (result == DialogResult.Yes)
                {

                    MC.mUserManagement usm = new MC.mUserManagement();
                    usm.delete(U_EmpNo.Text);
                    MessageBox.Show("Succesfully Deleted user ", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    display_d();
                    clear_data();
                }
            }
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            AddingNew.addNewUser adn_user = new AddingNew.addNewUser();
            adn_user.Show();
        }

        //update
        private void U_updateBtn_Click(object sender, EventArgs e)
        {
            MC.mUserManagement usm = new MC.mUserManagement();

         
            
            
                if (U_EmpNo.Text != "" && U_Name.Text != "")
                {

                    usm.update(U_Name.Text, U_Nic.Text, U_contactNo.Text, U_address.Text, U_email.Text, U_usrRole.SelectedItem.ToString(), U_EmpNo.Text);
                    string err = usm.error;
                    if (err != ""){
                        MessageBox.Show("Succesfully updated\nUser -> '" + U_Name.Text + "'", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        display_d();
                        clear_data();
                    }
                    else{
                        MessageBox.Show("SQL ERROR Please Contact Developer Team", "SQL ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        MessageBox.Show(usm.error);
                    }
                }
                else {
                    MessageBox.Show("Not Accept Empty Value ", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        //search
        private void searchBtn1_Click(object sender, EventArgs e)
        {
         
            MC.mUserManagement usm = new MC.mUserManagement();

                string key=catSaleBox.SelectedItem.ToString(); // key -> search category
                List<mUserManagement> se = usm.get_search(key, SearchBox.Text);
                User_DGV.AutoGenerateColumns = false;
                User_DGV.DataSource = se;

                if (usm.detectDt == 0) {
                    MessageBox.Show("Not Matched Selected Data'\nCheck data and Try again", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }
        //Report generator btn
        private void U_genReport_Click(object sender, EventArgs e)
        {
            Report.UserReport userRE = new Report.UserReport();
            userRE.Show();
        }
    }
}
