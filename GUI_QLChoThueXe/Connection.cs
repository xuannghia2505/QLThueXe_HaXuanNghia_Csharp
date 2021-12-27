using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace GUI_QLChoThueXe
{
    class Connection
    {
        public SqlConnection con = new SqlConnection(@"server=ADMIN\SQLHACK;uid=sa;pwd=123;database=QLChoThueXe");
    }
}
