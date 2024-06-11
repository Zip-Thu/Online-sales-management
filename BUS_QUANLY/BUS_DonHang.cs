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
    public class BUS_DonHang
    {
        DAL_DonHang dalDonHang = new DAL_DonHang();
        public DataTable getDonHang()
        {
            return dalDonHang.getDonHang();
        }
        public bool themDonHang(DTO_DonHang dh)
        {
            return dalDonHang.themDonHang(dh);
        }
        public bool suaDonHang(DTO_DonHang dh)
        {
            return dalDonHang.suaDonHang(dh);
        }
        public bool xoaDonHang(int OrderID)
        {
            return dalDonHang.xoaDonHang(OrderID);
        }
    }
}
