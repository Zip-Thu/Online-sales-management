using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BUS_QUANLY
{
    public class BUS_TaiKhoan
    {
        TaiKhoan tkAccess = new TaiKhoan();
        public string CheckLogic(DTO_TaiKhoan taikhoan)
        {
            // Kiểm tra nghiệp vụ
            if (taikhoan.STaiKhoan == "")
            {
                return "requeid_taikhoan";
            }

            if (taikhoan.SMatKhau == "")
            {
                return "requeid_password";
            }

            string info = tkAccess.CheckLogic(taikhoan);
            return info;
        }
    }
}
