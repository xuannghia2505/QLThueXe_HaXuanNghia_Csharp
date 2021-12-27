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
    public class DAL_ThueXe : DBConnection
    {
        public bool setTinhTrangXeDap(string masoxe, int tinhtrang)
        {
            string str = string.Format("update XeDap set TinhTrang= '{0}' where MaSoXe= '{1}'", tinhtrang, masoxe);
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
        public bool setTinhTrangXeMay(string masoxe, int tinhtrang)
        {
            string str = string.Format("update XeMay set TinhTrang= '{0}' where MaSoXe= '{1}'", tinhtrang, masoxe);
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
        public DataTable getDSThueXeDap()
        {
            SqlDataAdapter da = new SqlDataAdapter("select id, HoVaTen, CMND, MaSoXe, PTThue, TGThue, KieuXe "
                                                    + "from KhachThue where KieuXe = 0 and DaThanhToan = 0", con);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            dtb.Columns.Add("STT");
            dtb.Columns.Add("NgayThue");
            dtb.Columns.Add("GioThue");
            for (int i = 1; i <= dtb.Rows.Count; i++)
            {
                DateTime ngay = DateTime.Parse(dtb.Rows[i - 1]["TGThue"].ToString());
                dtb.Rows[i - 1]["STT"] = i.ToString();
                dtb.Rows[i - 1]["NgayThue"] = ngay.ToString(@"dd/MM/yyyy", new CultureInfo("en-US"));
                dtb.Rows[i - 1]["GioThue"] = ngay.ToString(@"hh:mm tt", new CultureInfo("en-US"));
            }
            return dtb;
        }
        public DataTable getDSThueXeMay()
        {
            SqlDataAdapter da = new SqlDataAdapter("select id, HoVaTen, CMND, kt.MaSoXe, PTThue, TGThue, kt.KieuXe "
                                                    + "from KhachThue kt inner join XeMay xm on xm.MaSoXe = kt.MaSoXe "
                                                    + "where kt.KieuXe = 1 and DaThanhToan = 0", con);
            DataTable dtb = new DataTable();    
            da.Fill(dtb);
            dtb.Columns.Add("STT");
            dtb.Columns.Add("NgayThue");
            dtb.Columns.Add("GioThue");
            for (int i = 1; i <= dtb.Rows.Count; i++)
            {
                DateTime ngay = DateTime.Parse(dtb.Rows[i - 1]["TGThue"].ToString());
                dtb.Rows[i - 1]["STT"] = i.ToString();
                dtb.Rows[i - 1]["NgayThue"] = ngay.ToString(@"dd/MM/yyyy", new CultureInfo("en-US"));
                dtb.Rows[i - 1]["GioThue"] = ngay.ToString(@"hh:mm tt", new CultureInfo("en-US"));
            }
            return dtb;
        }
        public bool insertKhachThueXe(string hovaten, string cmnd, string masoxe, string PTThue, int KieuXe)
        {
            if (KieuXe == 1)
            {
                setTinhTrangXeMay(masoxe, 1);
            }
            else
            {
                setTinhTrangXeDap(masoxe, 1);
            }
            string str = string.Format("insert into KhachThue(HoVaTen, CMND, MaSoXe, PTThue, KieuXe, DaThanhToan) "
                        + "values (N'{0}','{1}','{2}',N'{3}','{4}', 0)", hovaten, cmnd, masoxe, PTThue, KieuXe);
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
        public DataTable getMaXeDapTonTai()
        {
            string str = string.Format("select MaSoXe from XeDap where TinhTrang = 0");
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            DataTable dtb = new DataTable();
            da.Fill(dtb);

            return dtb;
        }
        public DataTable getMaXeMayTonTai()
        {
            string str = string.Format("select MaSoXe from XeMay where TinhTrang = 0");
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            DataTable dtb = new DataTable();
            da.Fill(dtb);

            return dtb;
        }
        public string getLoaiXeMayTheoMaXe(string masoxe)
        {
            string str = string.Format("select LoaiXe from XeMay where MaSoXe = '{0}'", masoxe);
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            DataTable dtb = new DataTable();
            da.Fill(dtb);

            return dtb.Rows[0]["LoaiXe"].ToString();
        }
    }
}
