using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLChoThueXe;
using System.Data;

namespace BUS_QLChoThueXe
{
    public class BUS_ThanhToan
    {
        DAL_ThanhToan dalTT = new DAL_ThanhToan();
        public string getThongTin(string hovaten, string cmnd, string masoxe)
        {
            return dalTT.getThongTin(hovaten, cmnd, masoxe);
        }
        public bool insertHoaDon(string hovaten, string masoxe, string tgthue, string tgtra, string sophut, string tongtien, int kieuxe)
        {
            return dalTT.insertHoaDon(hovaten, masoxe, tgthue, tgtra, sophut, tongtien, kieuxe);
        }
        public bool updateDaThanhToan(string hovaten, string cmnd, string masoxe)
        {
            return dalTT.updateDaThanhToan(hovaten, cmnd, masoxe);
        }
    }
}
