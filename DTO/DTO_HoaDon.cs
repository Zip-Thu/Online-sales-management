
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HoaDon
    {
        private int OrderID;
        private int SP_ID;
        private int Price;
        private string Note;
        private int Quantity;
        private int SumTotal;
        private string SP_Name;

        public DTO_HoaDon(int orderID, int sP_ID, int price, string note, int quantity, int sumTotal, string sP_Name)
        {
            OrderID = orderID;
            SP_ID = sP_ID;
            Price = price;
            Note = note;
            Quantity = quantity;
            SumTotal = sumTotal;
            SP_Name = sP_Name;
        }

        public DTO_HoaDon()
        {
            
        }

        public int OrderID1 { get => OrderID; set => OrderID = value; }
        public int SP_ID1 { get => SP_ID; set => SP_ID = value; }
        public int Price1 { get => Price; set => Price = value; }
        public string Note1 { get => Note; set => Note = value; }
        public int Quantity1 { get => Quantity; set => Quantity = value; }
        public int SumTotal1 { get => SumTotal; set => SumTotal = value; }
        public string SP_Name1 { get => SP_Name; set => SP_Name = value; }
    }
}
