using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QUANLY
{
    public class BUS_HoaDon
    {
        DAL_HoaDon dalHD = new DAL_HoaDon();
        public DataTable getHD()
        {
            return dalHD.getHoaDon();
        }
        public bool themHoaDon(DTO_HoaDon hd)
        {
            return dalHD.themHoaDon(hd);
        }
        public bool suaHoaDon(DTO_HoaDon hd)
        {
            return dalHD.suaHoaDon(hd);
        }
        public bool xoaHoaDon(int OrderID)
        {
            return dalHD.xoaHoaDon(OrderID);
        }
    }
}
