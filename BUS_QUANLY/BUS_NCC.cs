using DAL;
using DAL_QUANLY;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QUANLY
{
    public class BUS_NCC
    {
        DAL_NCC dalNCC = new DAL_NCC();
        public DataTable getNCC()
        {
            return dalNCC.getNCC();
        }
        public bool themNCC(DTO_NCC ncc)
        {
            return dalNCC.themNCC(ncc);
        }
        public bool suaNCC(DTO_NCC ncc)
        {
            return dalNCC.suaNCC(ncc);
        }
        public bool xoaNCC(int NCC_ID)
        {
            return dalNCC.xoaNCC(NCC_ID);
        }
    }
}
