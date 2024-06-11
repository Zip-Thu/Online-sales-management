using DAL_QUANLY;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_NhapHangDetails : DBConnect
    {
        //get toàn CHiTIETNHAPHANG

        public DataTable getNhapHangDetails()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ChiTietNhapHang", _conn);
            DataTable dtCTNH = new DataTable();
            da.Fill(dtCTNH);
            return dtCTNH;
        }

        //Thêm CTNH
        public bool themCTNH (DTO_NhapHangDetails ctnh)
        {
            try
            {
                // Ket noi
                _conn.Open();
                // Query string - vì KH_ID là identity (giá trị tự tăng dần) nên ko cần phải insert ID
                string SQL = string.Format("INSERT INTO ChiTietNhapHang (NH_ID, SP_ID, Price,Note, Quantity, SumTotal, SP_Name) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", ctnh.NH_ID1, ctnh.SP_ID1,ctnh.Price1, ctnh.Note1, ctnh.Quantity1, ctnh.SumTotal1, ctnh.SP_Name1);
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    SqlCommand updateCmd = new SqlCommand("UpdateSanPhamQuantity", _conn);
                    updateCmd.CommandType = CommandType.StoredProcedure;

                    // Thực thi thủ tục lưu trữ
                    updateCmd.ExecuteNonQuery();
                    return true;
                }    

                // Query và kiểm tra
                //if (cmd.ExecuteNonQuery() > 0 )
                //{
                //string updateQuery = string.Format("UPDATE SanPham SET SP_Quantity = SP_Quantity + '{0}' WHERE SP_ID = '{1}'", ctnh.Quantity1, ctnh.SP_ID1);
                //SqlCommand updateCmd = new SqlCommand(updateQuery, _conn);

                    //if (updateCmd.ExecuteNonQuery() > 0)
                    //{
                    //return true;
                    //}
                    //}
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

       

        //Sửa CTDH
        public bool suaCTNH(DTO_NhapHangDetails ctnh)
        {
            try
            {
                // Ket noi
                _conn.Open();
                // Query string
                string SQL = string.Format("UPDATE ChiTietNhapHang SET SP_ID = '{0}', Price = '{1}', Note = '{2}', Quantity = '{3}', SumTotal = '{4}', SP_Name = '{5}' WHERE NH_ID = '{6}'", ctnh.SP_ID1, ctnh.Price1, ctnh.Note1, ctnh.Quantity1, ctnh.SumTotal1, ctnh.SP_Name1, ctnh.NH_ID1);
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

        //Xóa CTDH
        public bool xoaCTNH(int NH_ID)
        {
            try
            {
                // Ket noi
                _conn.Open();
                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM ChiTietNhapHang WHERE NH_ID = '{0}'", NH_ID);

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
