using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL_QLChoThueXe
{
    public class DBConnection
    {
        public static SqlConnection con = new SqlConnection(@"server=DESKTOP-GN3V8MM\SQLEXPRESS;uid=sa;pwd=123;database=QLChoThueXe");
    }
}
