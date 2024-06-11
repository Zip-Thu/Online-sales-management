using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;


namespace BUS_QUANLY
{
    public class BUS_KhachHang
    {
        DAL_KhachHang dalKhachHang = new DAL_KhachHang();
        public DataTable getKhachHang()
        {
            return dalKhachHang.getKhachHang();
        }
        public bool themKhachHang(DTO_KhachHang kh)
        {
            return dalKhachHang.themKhachHang(kh);
        }
        public bool suaKhachHang(DTO_KhachHang kh)
        {
            return dalKhachHang.suaKhachHang(kh);
        }
        public bool xoaKhachHang(int KH_Id)
        {
            return dalKhachHang.xoaKhachHang(KH_Id);
        }

    }
}
