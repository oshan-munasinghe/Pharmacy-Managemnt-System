using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace admin.wind
{
    public partial class Sale : UserControl
    {
        public Sale(/*String user*/)
        {
            InitializeComponent();
            fillcombo_token();
            fillcombo_med();
           // CashierName.Text = user;
        }
        SqlConnection con = new SqlConnection("Data Source=OSHAN-MX\\SQLEXPRESS;Initial Catalog=Pharmacy_mgmt_system_DB;Integrated Security=True");

        private void fillcombo_med()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM [token] ", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    ItemIdbox.Items.Add(dr["medicine_id"].ToString());
                }
                con.Close();
            }
            catch { 
            
            }
        }
        private void fillcombo_token()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [token]", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                TokenId.Items.Add(dr["Token_Id"].ToString());
                
            }
            con.Close();
        }

        double  x,y,c,n = 0;
        int medqty = 0;
        int index;
        private void ItemIdbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [medicine] where medicine_id='" + ItemIdbox.SelectedItem.ToString() + "'", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                try
                {
                    SDate.Text = DateTime.Now.ToShortDateString();
                    Stime.Text = DateTime.Now.ToShortTimeString();
                    itemNameLbl.Text = dr["medicine_name"].ToString();
                    PriceLbl.Text = dr["unit_price"].ToString();
                     y = Convert.ToDouble(PriceLbl.Text);
                     x = Convert.ToDouble(Quantity_Box1.Text);
                    double total = x * y;
                    totatPrice.Text = "Rs. " + Convert.ToString(total);
                    isAvailablelbl.Text = dr["med_quantity"].ToString();
                    medqty = Convert.ToInt16(isAvailablelbl.Text);
                    Quantity_Box1.Text = dr["qty"].ToString();
                   
                    
                }
                catch (Exception) { 
                }
                
            }
            con.Close();
        }
        /*Variables for Billing*/

        double total = 0;
        double i = 0;
        double f_total = 0;
        double cash_balance = 0;

        /*#####################*/

        private void Quantity_Box1_TextChanged(object sender, EventArgs e)
        {
            /*Add bill values*/
           
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ItemIdbox.Text = "";
            itemNameLbl.Text = "N/A";
            PriceLbl.Text = "0.00";
            Quantity_Box1.Text = "0";
            totatPrice.Text = "Rs. 0.00";
            TokenId.Text = "";
            saleIDadd.Clear();
            Itemtotlbl.Text="N/A";
            pharmaIdlbl.Text="N/A";
            CashierName.Text="N/A";
            lastTotalValLbl.Text="Rs 0.00";
            paidValue.Clear();
            balanceLbl.Text = "Rs 0.00";
            SDate.Text = "N/A";

        }
       
       /*Create bill section*/
        private void AddToBillBtn_Click(object sender, EventArgs e)
        {
            int f = Convert.ToInt32(Quantity_Box1.Text); //condition for available quantity
            if (f <= medqty)
            {

                i = i + 1;
                Itemtotlbl.Text = Convert.ToString(i);

                f_total = f_total + total;
                lastTotalValLbl.Text = "Rs. " + Convert.ToString(f_total);
                /*###################  Update DB */

                /*int tt = medqty - f;
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE [medicine] SET [med_quantity] =  '" + tt + "'WHERE [medicine_id] =  '" + ItemIdbox.SelectedItem.ToString() + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();*/

                /*#############*/

                c = c + 1;
                DataGridViewRow nRow = new DataGridViewRow();
                nRow.CreateCells(sBilDgv);
                nRow.Cells[0].Value = c;
                nRow.Cells[1].Value = ItemIdbox.Text;
                nRow.Cells[2].Value = itemNameLbl.Text;
                nRow.Cells[3].Value = PriceLbl.Text;
                nRow.Cells[4].Value = Quantity_Box1.Text;
                nRow.Cells[5].Value = totatPrice.Text;
                sBilDgv.Rows.Add(nRow);
                n++;
            }
            else {
                MessageBox.Show("Not Enough Stock","warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                Quantity_Box1.Text = "0";
            }
            //bill table
            
        }
        
        private void paidValue_TextChanged(object sender, EventArgs e)
        {
            try
            {
                i = Convert.ToInt32(paidValue.Text);

                cash_balance = i - f_total;
                balanceLbl.Text = "Rs. " + Convert.ToString(cash_balance);
                
            }
            catch (Exception) { 
            
               }
        }

        private void TokenviewBtn_Click(object sender, EventArgs e)
        {
            AddingNew.token_sh tkns = new AddingNew.token_sh();
            tkns.Show();
        }

        private void balanceLbl_Click(object sender, EventArgs e)
        {

        }
        private void pharmaLblSh()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [token] where Token_Id='" + TokenId.SelectedItem.ToString() + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                pharmaIdlbl.Text = dr["userid"].ToString();
                
            }
            

        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
           // pharmaLblSh();
        }

        private void TokenId_SelectedIndexChanged(object sender, EventArgs e)
        {
            pharmaLblSh();
        }

        private void Quantity_Box1_TextChanged_1(object sender, EventArgs e)
        {
            /*Add bill values*/
            try
            {
                y = Convert.ToDouble(PriceLbl.Text);
                x = Convert.ToDouble(Quantity_Box1.Text);
                total = x * y;
                totatPrice.Text = "Rs. " + Convert.ToString(total);
            }
            catch (Exception)
            {

            }
        }

        private void totatPrice_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {

            try{
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO [sale] Values('" + saleIDadd.Text + "','" + TokenId.SelectedItem.ToString() + "','" + ItemIdbox.SelectedItem.ToString() + "','" + Itemtotlbl.Text + "','" + CashierName.Text + "','" + pharmaIdlbl.Text + "','" + lastTotalValLbl.Text + "','" + SDate.Text + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                //INSERT INTO [sale] Values('"++"','"++"')
                DialogResult result = MessageBox.Show("Successfully Create Bill PRESS 'OK' to Print Bill", "Notice", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    printb();
                }
                
            }
            catch (Exception) {
                MessageBox.Show("check sale ID","warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                con.Close();
            }
            
               
        }
        
        private void deleteTD_Click(object sender, EventArgs e)
        {
            try
            {
                index = sBilDgv.CurrentCell.RowIndex;
                sBilDgv.Rows.RemoveAt(index);
            }
            catch { 
            
            }
        }

        private void sBilDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                index = e.RowIndex;
                DataGridViewRow row = sBilDgv.Rows[index];
                ItemIdbox.Text = row.Cells[1].Value.ToString();
                itemNameLbl.Text = row.Cells[2].Value.ToString();
                PriceLbl.Text = row.Cells[3].Value.ToString();
                Quantity_Box1.Text = row.Cells[4].Value.ToString();
                totatPrice.Text = row.Cells[5].Value.ToString();
            }
            catch (Exception) { 
            
            }
        }

        private void UpdateBilBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow newdt = sBilDgv.Rows[index];
                newdt.Cells[1].Value = ItemIdbox.Text;
                newdt.Cells[2].Value = itemNameLbl.Text;
                newdt.Cells[3].Value = PriceLbl.Text;
                newdt.Cells[4].Value = Quantity_Box1.Text;
                newdt.Cells[5].Value = totatPrice.Text;
            }
            catch(Exception) { 
            
            }
        }

        //
        //Print Bill \/
        //

        private void printb() {
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 550, 700);
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
        private void PrintBillBtn_Click(object sender, EventArgs e)
        {
            printb();
        }
        string medName, itemNo, uPrice,qty1, totPrice;
        int pos=80;
        
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Pharmacy Management System",new Font("Consolas",16,FontStyle.Bold),Brushes.ForestGreen,new Point(100));
            e.Graphics.DrawString("No   Medicine Name    qty   price    Total ", new Font("Consolas", 14, FontStyle.Bold), Brushes.Black, new Point(26, 40));
            e.Graphics.DrawString("--   -------- ----    ---   -----    -----", new Font("Consolas", 14, FontStyle.Bold), Brushes.Black, new Point(26, 60));
            foreach (DataGridViewRow row in sBilDgv.Rows) {
                itemNo = "" + row.Cells["Column1"].Value;
                medName = "" + row.Cells["Column2"].Value;
                qty1 = "" + row.Cells["Column4"].Value;
                uPrice = "" + row.Cells["Column3"].Value;
                totPrice = "" + row.Cells["Column5"].Value;
                e.Graphics.DrawString("" + itemNo, new Font("Consolas", 10, FontStyle.Bold), Brushes.Black, new Point(26, pos));
                e.Graphics.DrawString("" + medName, new Font("Consolas", 10, FontStyle.Bold), Brushes.Black, new Point(110, pos));
                e.Graphics.DrawString("" + qty1, new Font("Consolas", 10, FontStyle.Bold), Brushes.Black, new Point(275, pos));
                e.Graphics.DrawString("" + uPrice, new Font("Consolas", 10, FontStyle.Bold), Brushes.Black, new Point(350, pos));
                e.Graphics.DrawString("" + totPrice, new Font("Consolas", 10, FontStyle.Bold), Brushes.Black, new Point(435, pos));
                pos = pos + 20;
            }
           //Lprice=
            e.Graphics.DrawString("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++", new Font("Consolas", 9, FontStyle.Bold), Brushes.Black, new Point(26, pos + 30));
            e.Graphics.DrawString("sale Date  : "+SDate.Text, new Font("Consolas", 9, FontStyle.Bold), Brushes.Black, new Point(26, pos + 60));
            e.Graphics.DrawString("sale Time  : " + Stime.Text, new Font("Consolas", 9, FontStyle.Bold), Brushes.Black, new Point(26, pos + 80));
            e.Graphics.DrawString("Pharmasist : " + pharmaIdlbl.Text, new Font("Consolas", 9, FontStyle.Bold), Brushes.Black, new Point(26, pos + 100));
            e.Graphics.DrawString("   Cashier : " + CashierName.Text, new Font("Consolas", 9, FontStyle.Bold), Brushes.Black, new Point(26, pos + 120));
            e.Graphics.DrawString("Total Price(Rs) : " + f_total, new Font("Consolas", 10, FontStyle.Bold), Brushes.Black, new Point(330, pos + 60));
            e.Graphics.DrawString("       Paid(Rs) : " + paidValue.Text, new Font("Consolas", 10, FontStyle.Bold), Brushes.Black, new Point(330, pos + 80));
            e.Graphics.DrawString("       Discount : " + "N/A", new Font("Consolas", 10, FontStyle.Bold), Brushes.Black, new Point(330, pos + 100));
            e.Graphics.DrawString("    Balance(Rs) : " + cash_balance, new Font("Consolas", 10, FontStyle.Bold), Brushes.Black, new Point(330, pos + 120));
            e.Graphics.DrawString("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++", new Font("Consolas", 9, FontStyle.Bold), Brushes.Black, new Point(26, pos + 145));
            e.Graphics.DrawString("+++++++ Thank You Come Again ! ++++++++", new Font("Consolas", 9, FontStyle.Bold), Brushes.Black, new Point(145, pos + 170));
            e.Graphics.DrawString("  - Developed By -", new Font("Consolas", 9, FontStyle.Bold), Brushes.Black, new Point(200, pos + 185));
            e.Graphics.DrawString("- HNDIT Part Time 2019 -", new Font("Consolas", 9, FontStyle.Bold), Brushes.Black, new Point(185, pos + 200));
            e.Graphics.DrawString("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++", new Font("Consolas", 9, FontStyle.Bold), Brushes.Black, new Point(26, pos + 230));
        }

        private void SDate_Click(object sender, EventArgs e)
        {

        }

        private void Sale_Load(object sender, EventArgs e)
        {

        }
        
        private void cashierlblSh()
        {
           

        }

        private void ViewBillBtn_Click(object sender, EventArgs e)
        {

            viewSale vBtn = new viewSale();
            vBtn.Show();
        }

        private void SupportBtn_Click(object sender, EventArgs e)
        {
            AddingNew.TechSupport Ts = new AddingNew.TechSupport();
            Ts.Show();
        }
    }
}
