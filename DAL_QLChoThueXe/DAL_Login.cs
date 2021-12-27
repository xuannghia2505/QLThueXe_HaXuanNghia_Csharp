using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL_QLChoThueXe;

namespace DAL_QLChoThueXe
{
    public class DAL_Login : DBConnection
    {
        public bool getUser(string username, string password)
        {

            string str = string.Format("select * from TaiKhoan where user_name = '{0}' and pass_word = '{1}' ", username, password);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                SqlDataReader data = cmd.ExecuteReader();
                if (data.Read() == true)
                {
                    con.Close();
                    return true;
                }
                else
                {
                    con.Close();
                    return false;
                }
            }
            catch
            {
                con.Close();
                return false;
            }

        }
    }
}
