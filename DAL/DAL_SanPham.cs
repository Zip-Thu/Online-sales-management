using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QUANLY;
using DTO;

namespace DAL
{
    public class DAL_SanPham : DBConnect
    {


        //get toàn bộ sản phẩm
        public DataTable getSanPham()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM SanPham", _conn);
            DataTable dtSanPham = new DataTable();
            da.Fill(dtSanPham);
            return dtSanPham;
        }

        //Thêm sản phẩm
        public bool themSanPham(DTO_SanPham sp)
        {
            try
            {
                // Ket noi
                _conn.Open();
                // Query string - vì SP_ID là identity (giá trị tự tăng dần) nên ko cần phải insert ID
                string SQL = string.Format("INSERT INTO SanPham(SP_Name,SP_Note, SP_Price, SP_Quantity) VALUES('{0}', '{1}', '{2}', '{3}')", sp.SP_Name1, sp.SP_Note1, sp.SP_Price1,sp.SP_Quantity1);
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

        //Sửa sản phẩm
        public bool suaSanPham(DTO_SanPham sp)
        {
            try
            {
                // Ket noi
                _conn.Open();
                // Query string
                string SQL = string.Format("UPDATE SanPham SET SP_Name = '{0}',SP_Note = '{1}', SP_Price = '{2}', SP_Quantity = '{3}' WHERE SP_ID = '{4}'", sp.SP_Name1, sp.SP_Note1, sp.SP_Price1,sp.SP_Quantity1, sp.SP_ID1);
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

        //Xóa sản phẩm
        public bool xoaSanPham(int SP_Id)
        {
            try
            {
                // Ket noi
                _conn.Open();
                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM SanPham WHERE SP_ID = {0}", SP_Id);

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
