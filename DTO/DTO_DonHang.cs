using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DonHang
    {
        private int OrderID;
        private string O_Delivered;
        private string O_NgayNhanDon;
        private int KH_ID;
        private string KH_Name;

        public DTO_DonHang(int orderID, string o_Delivered, string o_NgayNhanDon, int kH_ID, string kH_Name)
        {
            OrderID = orderID;
            O_Delivered = o_Delivered;
            O_NgayNhanDon = o_NgayNhanDon;
            KH_ID = kH_ID;
            KH_Name = kH_Name;
        }

        public DTO_DonHang()
        {
        }

        public int OrderID1 { get => OrderID; set => OrderID = value; }
        public string O_Delivered1 { get => O_Delivered; set => O_Delivered = value; }
        public string O_NgayNhanDon1 { get => O_NgayNhanDon; set => O_NgayNhanDon = value; }
        public int KH_ID1 { get => KH_ID; set => KH_ID = value; }
        public string KH_Name1 { get => KH_Name; set => KH_Name = value; }
    }
}
