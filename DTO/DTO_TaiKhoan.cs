using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TaiKhoan
    {
        private int sMaTK;
        private string sTaiKhoan;
        private string sMatKhau;
        private int FK_iMaQuyen;

        public DTO_TaiKhoan(int sMaTK, string sTaiKhoan, string sMatKhau, int fK_iMaQuyen)
        {
            this.sMaTK = sMaTK;
            this.sTaiKhoan = sTaiKhoan;
            this.sMatKhau = sMatKhau;
            FK_iMaQuyen = fK_iMaQuyen;
        }

        public DTO_TaiKhoan()
        {
        }

        public int SMaTK { get => sMaTK; set => sMaTK = value; }
        public string STaiKhoan { get => sTaiKhoan; set => sTaiKhoan = value; }
        public string SMatKhau { get => sMatKhau; set => sMatKhau = value; }
        public int FK_iMaQuyen1 { get => FK_iMaQuyen; set => FK_iMaQuyen = value; }
    }
}
