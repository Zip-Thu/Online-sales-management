using DAL_QUANLY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class TaiKhoan : DatabaseAccess
    {
        public string CheckLogic(DTO_TaiKhoan taikhoan)
        {
            string info = CheckLogicDTO(taikhoan);
            return info;
        }
    }
}
