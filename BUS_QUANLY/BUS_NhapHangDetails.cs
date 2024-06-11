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
    public class BUS_NhapHangDetails
    {
        DAL_NhapHangDetails dalCTNH = new DAL_NhapHangDetails();
        public DataTable getCTNH()
        {
            return dalCTNH.getNhapHangDetails();
        }
        public bool themCTNH(DTO_NhapHangDetails ctnh)
        {
            return dalCTNH.themCTNH(ctnh);
        }
        public bool suaCTNH(DTO_NhapHangDetails ctnh)
        {
            return dalCTNH.suaCTNH(ctnh);
        }
        public bool xoaCTNH(int NH_ID)
        {
            return dalCTNH.xoaCTNH(NH_ID);
        }
    }
}
