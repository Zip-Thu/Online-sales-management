using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;
using DAL_QUANLY;

namespace DAL
{
    public class DatabaseAccess : DBConnect
    {
        public  string CheckLogicDTO(DTO_TaiKhoan taikhoan)
        {
            string user = null;
            // Hàm connect tới CSDL
            _conn.Open();
            SqlCommand cmd = new SqlCommand("proc_logic", _conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@user", taikhoan.STaiKhoan);
            cmd.Parameters.AddWithValue("@pass", taikhoan.SMatKhau);
            // Kiểm tra quyền các bạn thêm 1 cái parameter...
            cmd.Connection = _conn;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    user = reader.GetString(0);
                }
                reader.Close();
                _conn.Close();
            }
            else
            {
                return "Tài khoản hoặc mật khẩu không chính xác!";
            }

            return user;
        }
    }
}

