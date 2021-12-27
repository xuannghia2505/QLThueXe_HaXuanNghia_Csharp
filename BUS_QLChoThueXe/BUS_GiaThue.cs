using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLChoThueXe;
using System.Data;

namespace BUS_QLChoThueXe
{
    public class BUS_GiaThue
    {
        DAL_GiaThue dalGT = new DAL_GiaThue();
        public DataTable getGiaThue()
        {
            return dalGT.getGiaThue();
        }
        public bool updateGiaThue(string loaixe, string tienthue, int giamgia)
        {
            return dalGT.updateGiaThue(loaixe, tienthue, giamgia);
        }
    }
}
