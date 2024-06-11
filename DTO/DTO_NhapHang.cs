using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NhapHang
    {
        private int NH_ID;
        private int NCC_ID;
        private string NCC_Name;
        private string NH_NgayNhap;
        private string NH_Delivered;

        public DTO_NhapHang(int nH_ID, int nCC_ID, string nCC_Name, string nH_NgayNhap, string nH_Delivered)
        {
            NH_ID = nH_ID;
            NCC_ID = nCC_ID;
            NCC_Name = nCC_Name;
            NH_NgayNhap = nH_NgayNhap;
            NH_Delivered = nH_Delivered;
        }

        public DTO_NhapHang()
        {
           
        }

        public int NH_ID1 { get => NH_ID; set => NH_ID = value; }
        public int NCC_ID1 { get => NCC_ID; set => NCC_ID = value; }
        public string NCC_Name1 { get => NCC_Name; set => NCC_Name = value; }
        public string NH_NgayNhap1 { get => NH_NgayNhap; set => NH_NgayNhap = value; }
        public string NH_Delivered1 { get => NH_Delivered; set => NH_Delivered = value; }
    }
}
