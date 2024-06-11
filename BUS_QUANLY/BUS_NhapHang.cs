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
    public class BUS_NhapHang
    {
        DAL_NhapHang dalNhapHang = new DAL_NhapHang();
        public DataTable getNhapHang()
        {
            return dalNhapHang.getNhapHang();
        }
        public bool themNhapHang(DTO_NhapHang nh)
        {
            return dalNhapHang.themNhapHang(nh);
        }
        public bool suaNhapHang(DTO_NhapHang nh)
        {
            return dalNhapHang.suaNhapHang(nh);
        }
        public bool xoaNhapHang(int NH_ID)
        {
            return dalNhapHang.xoaNhapHang(NH_ID);
        }
    }
}
