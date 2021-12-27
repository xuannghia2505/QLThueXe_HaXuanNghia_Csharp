using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLChoThueXe;
using System.Data;

namespace BUS_QLChoThueXe
{
    public class BUS_ThueXe
    {
        DAL_ThueXe dalTX = new DAL_ThueXe();    
        public DataTable getDSThueXeDap()
        {
            return dalTX.getDSThueXeDap();
        }
        public DataTable getDSThueXeMay()
        {
            return dalTX.getDSThueXeMay();
        }
        public bool insertKhachThueXe(string hovaten, string cmnd, string masoxe, string PTThue, int KieuXe)
        {
            return dalTX.insertKhachThueXe(hovaten, cmnd, masoxe, PTThue, KieuXe);
        }
        public DataTable getMaXeDapTonTai()
        {
            return dalTX.getMaXeDapTonTai();
        }
        public DataTable getMaXeMayTonTai()
        {
            return dalTX.getMaXeMayTonTai();
        }
        public string getLoaiXeMayTheoMaXe(string masoxe)
        {
            return dalTX.getLoaiXeMayTheoMaXe(masoxe);
        }
    }
}
