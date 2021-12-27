using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI_QLChoThueXe.DAL;

namespace GUI_QLChoThueXe.BUS
{
    public class BUS_ThemXe
    {
        DAL_ThemXe dalTX = new DAL_ThemXe();
        public bool ThemXeMay(string masoxe, Image anh, string bienso, string loaixe)
        {
            try
            {
                return dalTX.ThemXeMay(masoxe, anh, bienso, loaixe); // pass values to data access layer function
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return false;
            }

        }
        public bool ThemXeDap(string masoxe, Image anh)
        {
            try
            {
                return dalTX.ThemXeDap(masoxe, anh); // pass values to data access layer function
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return false;
            }

        }
    }
}
