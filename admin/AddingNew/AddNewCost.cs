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
    public partial class AddNewCost : Form
    {
        public AddNewCost()
        {
            InitializeComponent();
            fillcombo_user();
            fillcombo_costType();
        }
       // SqlConnection con = new SqlConnection("Data Source=OSHAN-PC\\SQLEXPRESS;Initial Catalog=Pharmacy_mgmt_system_DB;Integrated Security=True");
        static string connec = System.Configuration.ConfigurationManager.ConnectionStrings["connec"].ConnectionString;
        SqlConnection con = new SqlConnection(connec);

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
                UserBox.Items.Add(dr["username"].ToString());
            }
            con.Close();

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO [cost] VALUES('" + costTypeBox.Text + "','" + AmountBox.Text +"','" + DiscriptionBox.Text +"','" +UserBox.Text +"')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Succesfully Added Data ", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clear_cost();
        }
        private void clear_cost() {
            costTypeBox.Text = "";
            AmountBox.Clear();
            DiscriptionBox.Clear();
            UserBox.Text = "";
        }

        private void addCostCat__Click(object sender, EventArgs e)
        {
            AddingNew.AddcostCat adcost = new AddingNew.AddcostCat();
            adcost.Show();
        }

        private void fillcombo_costType()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [ref]", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                costTypeBox.Items.Add(dr["cost_type"].ToString());
            }
            con.Close();

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            clear_cost();
        }

       
    }
}
