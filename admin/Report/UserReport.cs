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
using Microsoft.Reporting.WinForms;

namespace admin.Report
/*######## Users REPORT ##########*/

{
    public partial class UserReport : Form
    {
        public UserReport()
        {
            InitializeComponent();
        }
        //SqlConnection con = new SqlConnection("Data Source=OSHAN-PC\\SQLEXPRESS;Initial Catalog=Pharmacy_mgmt_system_DB;Integrated Security=True");
        static string connec = System.Configuration.ConfigurationManager.ConnectionStrings["connec"].ConnectionString;
        SqlConnection con = new SqlConnection(connec);
        
        private void UserReport_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [user]",con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            ReportDataSource rds = new ReportDataSource("DataSet1",dt);
            reportViewer1.LocalReport.ReportPath = @"C:\Users\Oshan\Documents\Visual Studio 2012\Pharmacy Mgmt System\admin\Report\userRep.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "name")
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM [user] where name Like'%" + textBox1.Text + "%'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                ReportDataSource rds = new ReportDataSource("DataSet1", dt);

                reportViewer1.LocalReport.ReportPath = @"C:\Users\Oshan\Documents\Visual Studio 2012\Pharmacy Mgmt System\admin\Report\userRep.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.RefreshReport();
            }
            else if (comboBox1.Text == "user_role")
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM [user] where user_role Like'%" + textBox1.Text + "%'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                ReportDataSource rds = new ReportDataSource("DataSet1", dt);

                reportViewer1.LocalReport.ReportPath = @"C:\Users\Oshan\Documents\Visual Studio 2012\Pharmacy Mgmt System\admin\Report\userRep.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.RefreshReport();
            }
        }
    }
}
