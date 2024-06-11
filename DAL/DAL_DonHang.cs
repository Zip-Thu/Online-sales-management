using DAL_QUANLY;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_DonHang : DBConnect
    {

        //get toàn bộ DonHang
        public DataTable getDonHang()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Orders", _conn);
            DataTable dtDonHang = new DataTable();
            da.Fill(dtDonHang);
            return dtDonHang;
        }

        //Thêm đơn hàng
        public bool themDonHang(DTO_DonHang dh)
        {
            try
            {
                // Ket noi
                _conn.Open();
                // Query string - vì NH_ID là identity (giá trị tự tăng dần) nên ko cần phải insert ID
                string SQL = string.Format("INSERT INTO Orders (O_Delivered, O_NgayNhanDon, KH_ID, KH_Name) VALUES('{0}', '{1}', '{2}','{3}')", dh.O_Delivered1, dh.O_NgayNhanDon1, dh.KH_ID1, dh.KH_Name1);
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception)
            {
            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }
            return false;
        }


        //Sửa đơn hàng
        public bool suaDonHang(DTO_DonHang dh)
        {
            try
            {
                // Ket noi
                _conn.Open();
                // Query string
                string SQL = string.Format("UPDATE Orders SET O_Delivered = '{0}', O_NgayNhanDon = '{1}', KH_ID = '{2}', KH_Name = '{3}' WHERE OrderID ='{4}'",dh.O_Delivered1, dh.O_NgayNhanDon1, dh.KH_ID1, dh.KH_Name1, dh.OrderID1 );
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception)
            {
            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }
            return false;
        }

        //Xóa
        public bool xoaDonHang(int OrderID)
        {
            try
            {
                // Ket noi
                _conn.Open();
                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM Orders WHERE OrderID = {0}", OrderID);

                SqlCommand cmd = new SqlCommand(SQL, _conn);
                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception)
            {
            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }
            return false;
        }

    }
}
