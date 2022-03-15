using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using admin.AddingNew;

namespace admin.wind
{
    public partial class userManagement : UserControl
    {
        string con = System.Configuration.ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        public userManagement()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            addNewUser adduser = new addNewUser();
            adduser.Show();
        }
    }
}
