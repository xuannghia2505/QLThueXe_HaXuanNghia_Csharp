using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL_QLChoThueXe
{
    public class DAL_GiaThue : DBConnection
    {
        public DataTable getGiaThue()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from GiaThue", con);
            DataTable dtb = new DataTable();
            da.Fill(dtb);

            return dtb;
        }
        public bool updateGiaThue(string loaixe, string tienthue, int giamgia)
        {
            string str = string.Format("update GiaThue set TienThue = '{0}', GiamGia24h = '{1}' "
                        + "where LoaiXe ='{2}'", tienthue, giamgia, loaixe);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            con.Close();
            return true;
        }
    }
}
