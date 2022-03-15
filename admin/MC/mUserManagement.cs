using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace admin.MC
{
    class mUserManagement
    {
        static string connec = System.Configuration.ConfigurationManager.ConnectionStrings["connec"].ConnectionString;
        SqlConnection con = new SqlConnection(connec);
        public string error;
        public string empNo { get; set; }
        public string eName { get; set; }
        public string eNIC { get; set; }
        public string eContactNo { get; set; }
        public string eAddress { get; set; }
        public string eEmail { get; set; }
        public string eUrole { get; set; }
        private string username { get; set; }
        private string password { get; set; }

        public void add(string empno, string name, string nic, string cno, string addr, string email, string urole, string uname, string pwd)
        {
            try
            {
                String sql = "INSERT INTO  [user](emp_no,name,nic,contact_num,address,email,user_role,username,password) values('" + empno + "','" + name + "','" + nic + "','" + cno + "','" + addr + "','" + email + "','" + urole + "','" + uname + "','" + pwd + "')";
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                error = e.ToString();
            }
        }

        public void delete(string dEmpno)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM [user] WHERE [emp_no]='" + dEmpno + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                error = e.ToString();
            }
        }
        //update
        public string updteEr;
        public void update(string name, string nic, string cno, string addr, string email, string urole, string empno)
        {
            string sql = "UPDATE [user] SET [name]='" + name + "',nic='" + nic + "',contact_num='" + cno + "',address='" + addr + "',email='" + email + "', [user_role]='" + urole + "' WHERE [emp_no] = '" + empno + "' ";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                updteEr = e.ToString();
            }
        }//end update

        // data pass for gridview
        public List<mUserManagement> get_user_data()
        {
            List<mUserManagement> userD = new List<mUserManagement>();
            string sql = "SELECT * FROM [user]";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                mUserManagement cUser = new mUserManagement();
                cUser.empNo = dr["emp_no"].ToString();
                cUser.eName = dr["name"].ToString();
                cUser.eNIC = dr["nic"].ToString();
                cUser.eContactNo = dr["contact_num"].ToString();
                cUser.eAddress = dr["address"].ToString();
                cUser.eEmail = dr["email"].ToString();
                cUser.eUrole = dr["user_role"].ToString();

                userD.Add(cUser);
            }
            con.Close();
            return userD;
        }//end display


        public  int detectDt = 1;
        string sqlq;
        public List<mUserManagement> get_search(string key, string search_word) {
            
            List<mUserManagement> search = new List<mUserManagement>();
            
            string sqle ="SELECT * FROM [user] WHERE emp_no LIKE '%" + search_word + "%'";//empno
            string sqln = "SELECT * FROM [user] WHERE name LIKE '%" + search_word + "%'";//name
            string sqlr = "SELECT * FROM [user] WHERE user_role LIKE '%" + search_word + "%'";//user role
  
            if (key == "Emp Number") { sqlq = sqle; }
            else if (key == "Name") { sqlq = sqln; }
            else if (key == "User Role") { sqlq = sqlr; }

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sqlq, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    mUserManagement cUser = new mUserManagement();
                    cUser.empNo = dr["emp_no"].ToString();
                    cUser.eName = dr["name"].ToString();
                    cUser.eNIC = dr["nic"].ToString();
                    cUser.eContactNo = dr["contact_num"].ToString();
                    cUser.eAddress = dr["address"].ToString();
                    cUser.eEmail = dr["email"].ToString();
                    cUser.eUrole = dr["user_role"].ToString();

                    search.Add(cUser);
                }
                con.Close();
            }
            catch (Exception e) { error = e.ToString(); }

            if (search.Count <= 0)
            {
                detectDt = 0;
            }
            return search;
           
        }
    }   

}
