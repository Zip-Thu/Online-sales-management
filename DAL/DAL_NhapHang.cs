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
    public class DAL_NhapHang : DBConnect
    {
        //get toàn bộ nhu cầu nhập hàng
        public DataTable getNhapHang()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NhapHang", _conn);
            DataTable dtNhapHang = new DataTable();
            da.Fill(dtNhapHang);
            return dtNhapHang;
        }

        //Thêm nhu cầu nhập hàng
        public bool themNhapHang(DTO_NhapHang nh)
        {
            try
            {
                // Ket noi
                _conn.Open();
                // Query string - vì NH_ID là identity (giá trị tự tăng dần) nên ko cần phải insert ID
                string SQL = string.Format("INSERT INTO NhapHang(NCC_ID,NH_NgayNhap,NH_Delivered,NCC_Name) VALUES('{0}', '{1}', '{2}','{3}')", nh.NCC_ID1, nh.NH_NgayNhap1, nh.NH_Delivered1, nh.NCC_Name1 );
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

        //Sửa nhu cầu nhập hàng
        public bool suaNhapHang(DTO_NhapHang nh)
        {
            try
            {
                // Ket noi
                _conn.Open();
                // Query string
                string SQL = string.Format("UPDATE NhapHang SET NCC_ID = '{0}',NH_NgayNhap = '{1}', NH_Delivered = '{2}', NCC_Name = '{3}' WHERE NH_ID ='{4}'", nh.NCC_ID1, nh.NH_NgayNhap1, nh.NH_Delivered1,nh.NCC_Name1, nh.NH_ID1);
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
        public bool xoaNhapHang(int NH_ID)
        {
            try
            {
                // Ket noi
                _conn.Open();
                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM NhapHang WHERE NH_ID = {0}", NH_ID);

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
