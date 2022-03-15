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
/*######## MEDICINE REPORT ##########*/
{
    public partial class medGenReport : Form
    {
        public medGenReport()
        {
            InitializeComponent();
        }
        //SqlConnection con = new SqlConnection("Data Source=OSHAN-PC\\SQLEXPRESS;Initial Catalog=Pharmacy_mgmt_system_DB;Integrated Security=True");
        static string connec = System.Configuration.ConfigurationManager.ConnectionStrings["connec"].ConnectionString;
        SqlConnection con = new SqlConnection(connec);

        private void medGenReport_Load(object sender, EventArgs e)
        {

            //########################
            //This For Load * Report In startup Time

            //this.reportViewer1.RefreshReport();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [medicine] ", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.ReportPath = @"C:\Users\Oshan\Documents\Visual Studio 2012\Pharmacy Mgmt System\admin\Report\medReport.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
            
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

            //
            //For Search Data
            //
            if (categBox.Text == "medicine_id")
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM [medicine] where medicine_id Like'%" + ValueBox.Text + "%'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                ReportDataSource rds = new ReportDataSource("DataSet1", dt);
                reportViewer1.LocalReport.ReportPath = @"C:\Users\Oshan\Documents\Visual Studio 2012\Pharmacy Mgmt System\admin\Report\medReport.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.RefreshReport();
            }
            else if (categBox.Text == "medicine_name")
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM [medicine] where medicine_name Like'%" + ValueBox.Text + "%'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                ReportDataSource rds = new ReportDataSource("DataSet1", dt);

                reportViewer1.LocalReport.ReportPath = @"C:\Users\Oshan\Documents\Visual Studio 2012\Pharmacy Mgmt System\admin\Report\medReport.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.RefreshReport();
            }
            else if (categBox.Text == "category")
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM [medicine] where category Like'%" + ValueBox.Text + "%'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                ReportDataSource rds = new ReportDataSource("DataSet1", dt);

                reportViewer1.LocalReport.ReportPath = @"C:\Users\Oshan\Documents\Visual Studio 2012\Pharmacy Mgmt System\admin\Report\medReport.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.RefreshReport();
            }
        }
    }
}
