using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_QLChoThueXe;

namespace BUS_QLChoThueXe
{
    public class BUS_DSThue
    {
        DAL_DSThue dalDS = new DAL_DSThue();
        public DataTable getDSThueXeDap()
        {
            return dalDS.getDSThueXeDap();
        }
        public DataTable getDSThueXeMay()
        {
            return dalDS.getDSThueXeMay();
        }
    }
}
