using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLChoThueXe;
using System.Data;

namespace BUS_QLChoThueXe
{
    public class BUS_TTXe
    {
        DAL_TTXe dalTT = new DAL_TTXe();
        public DataTable getXeDap()
        {
            return dalTT.getXeDap();
        }
        public DataTable getXeMay()
        {
            return dalTT.getXeMay();
        }
    }
}
