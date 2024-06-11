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
    public class DAL_HoaDon : DBConnect
    {
        //get
        public DataTable getHoaDon()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM OrderDetails", _conn);
            DataTable dtCTNH = new DataTable();
            da.Fill(dtCTNH);
            return dtCTNH;
        }

        //Thêm 
        public bool themHoaDon(DTO_HoaDon hd)
        {
            try
            {
                // Ket noi
                _conn.Open();
                // Query string - vì KH_ID là identity (giá trị tự tăng dần) nên ko cần phải insert ID
                string SQL = string.Format("INSERT INTO OrderDetails (OrderID, SP_ID, Price,Note, Quantity, SumTotal, SP_Name) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", hd.OrderID1, hd.SP_ID1, hd.Price1, hd.Note1, hd.Quantity1, hd.SumTotal1, hd.SP_Name1);
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                
                if (cmd.ExecuteNonQuery() > 0)
                {
                    SqlCommand updateCmd = new SqlCommand("UpdateSanPhamQuantityAfterOrder", _conn);
                    updateCmd.CommandType = CommandType.StoredProcedure;

                    // Thực thi thủ tục lưu trữ
                    updateCmd.ExecuteNonQuery();
                    return true;
                }

              
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

        //Sửa 
        public bool suaHoaDon (DTO_HoaDon hd)
        {
            try
            {
                // Ket noi
                _conn.Open();
                // Query string
                string SQL = string.Format("UPDATE OrderDetails SET SP_ID = '{0}', Price = '{1}', Note = '{2}', Quantity = '{3}', SumTotal = '{4}', SP_Name = '{5}' WHERE OrderID = '{6}'", hd.SP_ID1, hd.Price1, hd.Note1, hd.Quantity1, hd.SumTotal1, hd.SP_Name1, hd.OrderID1);
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
        public bool xoaHoaDon(int OrderID)
        {
            try
            {
                // Ket noi
                _conn.Open();
                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM OrderDetails WHERE OrderID = '{0}'", OrderID);

                SqlCommand cmd = new SqlCommand(SQL, _conn);
                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                

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
