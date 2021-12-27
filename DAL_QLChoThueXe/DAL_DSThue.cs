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
    public class DAL_DSThue : DBConnection
    {
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
            SqlDataAdapter da = new SqlDataAdapter("select id, HoVaTen, CMND, kt.MaSoXe, PTThue, TGThue, KieuXe, xm.LoaiXe, xm.BienSo "
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
    }
}
