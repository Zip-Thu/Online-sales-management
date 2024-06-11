using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using DAL_QUANLY;


namespace DAL
{
    public class DAL_KhachHang : DBConnect
    {
        //get toàn bộ khách hàng
        public DataTable getKhachHang()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM KhachHang", _conn);
            DataTable dtKhachHang = new DataTable();
            da.Fill(dtKhachHang);
            return dtKhachHang;
        }

        //Thêm khách hàng
        public bool themKhachHang(DTO_KhachHang kh)
        {
            try
            {
                // Ket noi
                _conn.Open();
                // Query string - vì KH_ID là identity (giá trị tự tăng dần) nên ko cần phải insert ID
                string SQL = string.Format("INSERT INTO KhachHang(KH_Name, KH_Phone,KH_Email, KH_Address) VALUES('{0}', '{1}', '{2}', '{3}')",kh.KH_Name1, kh.KH_Phone1, kh.KH_Email1, kh.KH_Address1);
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

        //Sửa khách hàng
        public bool suaKhachHang(DTO_KhachHang kh)
        {
            try
            {
                // Ket noi
                _conn.Open();
                // Query string
                string SQL = string.Format("UPDATE KhachHang SET KH_Name = '{0}',KH_Phone = '{1}', KH_Email = '{2}', KH_Address = '{3}' WHERE KH_Id = {4}", kh.KH_Name1, kh.KH_Phone1, kh.KH_Email1, kh.KH_Address1,kh.KH_ID1);
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

        //Xóa khách hàng
        public bool xoaKhachHang(int KH_Id)
        {
            try
            {
                // Ket noi
                _conn.Open();
                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM KhachHang WHERE KH_ID = {0}", KH_Id);
           
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
