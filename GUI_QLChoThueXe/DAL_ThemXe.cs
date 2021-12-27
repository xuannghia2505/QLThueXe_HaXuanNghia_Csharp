using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;

namespace GUI_QLChoThueXe.DAL
{
    class DAL_ThemXe
    {
        public bool ThemXeMay(string masoxe, Image anh, string bienso, string loaixe)
        {

            Connection con = new Connection(); // connection class created in Data Access Layer (DAL)
            if (ConnectionState.Closed == con.con.State) //check if connection state is closed.
            {
                con.con.Open(); //open connection.
            }

            //parametrized query to insert title, subtitle and image in table -> (Table_Items)
            string query = "Insert into XeMay(MaSoXe,Anh,BienSo,LoaiXe,TinhTrang)values(@masoxe,@anh,@bienso,@loaixe,0)";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, con.con))
                {
                    cmd.Parameters.AddWithValue("@masoxe", masoxe.Trim());
                    cmd.Parameters.AddWithValue("@bienso", bienso.Trim());
                    cmd.Parameters.AddWithValue("@loaixe", loaixe.Trim());

                    //converting image to binary format to store in sql database.
                    MemoryStream ms = new MemoryStream();
                    anh.Save(ms, anh.RawFormat);
                    cmd.Parameters.AddWithValue("@anh", ms.ToArray()); //set binary formatted image to parameter.

                    cmd.ExecuteNonQuery(); //save to table
                }
                return true;
            }
            catch
            {
                throw;
            }
        }
        public bool ThemXeDap(string masoxe, Image anh)
        {

            Connection con = new Connection(); // connection class created in Data Access Layer (DAL)
            if (ConnectionState.Closed == con.con.State) //check if connection state is closed.
            {
                con.con.Open(); //open connection.
            }

            //parametrized query to insert title, subtitle and image in table -> (Table_Items)
            string query = "Insert into XeDap(MaSoXe,Anh,TinhTrang)values(@masoxe,@anh,0)";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, con.con))
                {
                    cmd.Parameters.AddWithValue("@masoxe", masoxe.Trim());

                    //converting image to binary format to store in sql database.
                    MemoryStream ms = new MemoryStream();
                    anh.Save(ms, anh.RawFormat);
                    cmd.Parameters.AddWithValue("@anh", ms.ToArray()); //set binary formatted image to parameter.

                    cmd.ExecuteNonQuery(); //save to table
                }
                return true;
            }
            catch
            {
                throw;
            }
        }
    }
}
