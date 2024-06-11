using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KhachHang
    {
        private int KH_ID;
        private string KH_Name;
        private string KH_Phone;
        private string KH_Email;
        private string KH_Address;

        public DTO_KhachHang(int kH_ID, string kH_Name, string kH_Phone, string kH_Email, string kH_Address)
        {
            KH_ID = kH_ID;
            KH_Name = kH_Name;
            KH_Phone = kH_Phone;
            KH_Email = kH_Email;
            KH_Address = kH_Address;
        }
        public DTO_KhachHang()
        {
          
        }

        public int KH_ID1 { get => KH_ID; set => KH_ID = value; }
        public string KH_Name1 { get => KH_Name; set => KH_Name = value; }
        public string KH_Phone1 { get => KH_Phone; set => KH_Phone = value; }
        public string KH_Email1 { get => KH_Email; set => KH_Email = value; }
        public string KH_Address1 { get => KH_Address; set => KH_Address = value; }
    }
}
