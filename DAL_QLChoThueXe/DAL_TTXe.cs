using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace DAL_QLChoThueXe
{
    public class DAL_TTXe : DBConnection
    {
        public DataTable getXeDap()
        {
            string str = string.Format("select * from XeDap");
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            DataTable dtb = new DataTable();
            da.Fill(dtb);

            return dtb;
        }
        public DataTable getXeMay()
        {
            string str = string.Format("select * from XeMay");
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            DataTable dtb = new DataTable();
            da.Fill(dtb);

            return dtb;
        }
    }

}
