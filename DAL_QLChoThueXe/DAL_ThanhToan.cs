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
    public class DAL_ThanhToan : DBConnection
    {
        public string getThongTin(string hovaten, string cmnd, string masoxe)
        {
            string str = string.Format("select * from KhachThue where HoVaTen = N'{0}' and CMND ='{1}' and MaSoXe ='{2}' ", hovaten, cmnd, masoxe);
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            dtb.Columns.Add("NgayThue");
            for (int i = 1; i <= dtb.Rows.Count; i++)
            {
                DateTime ngay = DateTime.Parse(dtb.Rows[i - 1]["TGThue"].ToString());
                dtb.Rows[i - 1]["NgayThue"] = ngay.ToString(@"hh:mm tt - dd/MM/yyyy", new CultureInfo("en-US"));
            }

            return dtb.Rows[0]["NgayThue"].ToString();
        }
        public bool insertHoaDon(string hovaten, string masoxe, string tgthue, string tgtra, string sophut, string tongtien, int kieuxe)
        {
            DAL_ThueXe dalTX = new DAL_ThueXe();
            if (kieuxe == 1)
            {
                dalTX.setTinhTrangXeMay(masoxe, 0);
            }
            else
            {
                dalTX.setTinhTrangXeDap(masoxe, 0);
            }
            string str = string.Format("insert into HoaDon(HoVaTen, MaSoXe, TGThue, TGTra, SoPhut, TongTien) "
                        + "values (N'{0}','{1}','{2}','{3}','{4}','{5}')", hovaten, masoxe, tgthue, tgtra, sophut, tongtien);
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
        public bool updateDaThanhToan(string hovaten, string cmnd, string masoxe)
        {
            string str = string.Format("update KhachThue set DaThanhToan = 1 "
                        + "where HoVaTen = N'{0}' and CMND ='{1}' and MaSoXe ='{2}'", hovaten, cmnd, masoxe);
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
