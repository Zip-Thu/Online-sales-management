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
    public class BUS_SanPham
    {
        DAL_SanPham dalSanPham = new DAL_SanPham();
        public DataTable getSanPham()
        {
            return dalSanPham.getSanPham();
        }
        public bool themSanPham(DTO_SanPham sp)
        {
            return dalSanPham.themSanPham(sp);
        }
        public bool suaSanPham(DTO_SanPham sp)
        {
            return dalSanPham.suaSanPham(sp);
        }
        public bool xoaSanPham(int SP_Id)
        {
            return dalSanPham.xoaSanPham(SP_Id);
        }
        
       
    }
}
