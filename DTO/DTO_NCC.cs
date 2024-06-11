using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NCC
    {
        private int NCC_ID;
        private string NCC_Name;
        private string NCC_Phone;
        private string NCC_Email;
        private string NCC_Address;

        public DTO_NCC(int nCC_ID, string nCC_Name, string nCC_Phone, string nCC_Email, string nCC_Address)
        {
            NCC_ID = nCC_ID;
            NCC_Name = nCC_Name;
            NCC_Phone = nCC_Phone;
            NCC_Email = nCC_Email;
            NCC_Address = nCC_Address;
        }

        public DTO_NCC()
        {
        }

        public int NCC_ID1 { get => NCC_ID; set => NCC_ID = value; }
        public string NCC_Name1 { get => NCC_Name; set => NCC_Name = value; }
        public string NCC_Phone1 { get => NCC_Phone; set => NCC_Phone = value; }
        public string NCC_Email1 { get => NCC_Email; set => NCC_Email = value; }
        public string NCC_Address1 { get => NCC_Address; set => NCC_Address = value; }
    }
}
