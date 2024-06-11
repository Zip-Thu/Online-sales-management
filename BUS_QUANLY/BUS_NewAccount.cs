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
    public class BUS_NewAccount
    {
        DAL_NewAccount dalTK = new DAL_NewAccount();
        public DataTable getTK()
        {
            return dalTK.getTK();
        }
        public bool themTK(DTO_NewAccount tk)
        {
            return dalTK.themTaiKhoan(tk);
        }

    }
}
