using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_SanPham
    {
        private int SP_ID;
        private string SP_Name;
        private string SP_Note;
        private int SP_Price;
        private int SP_Quantity;

        public DTO_SanPham(int sP_ID, string sP_Name, string sP_Note, int sP_Price, int sP_Quantity)
        {
            SP_ID = sP_ID;
            SP_Name = sP_Name;
            SP_Note = sP_Note;
            SP_Price = sP_Price;
            SP_Quantity = sP_Quantity;
        }

        public DTO_SanPham()
        {
           
        }

        public int SP_ID1 { get => SP_ID; set => SP_ID = value; }
        public string SP_Name1 { get => SP_Name; set => SP_Name = value; }
        public string SP_Note1 { get => SP_Note; set => SP_Note = value; }
        public int SP_Price1 { get => SP_Price; set => SP_Price = value; }
        public int SP_Quantity1 { get => SP_Quantity; set => SP_Quantity = value; }
    }
}
