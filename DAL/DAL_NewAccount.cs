using DAL_QUANLY;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_NewAccount : DBConnect
    {

        //get toàn bộ ncc
        public DataTable getTK()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbl_taikhoan", _conn);
            DataTable dtTK = new DataTable();
            da.Fill(dtTK);
            return dtTK;
        }

        public bool themTaiKhoan(DTO_NewAccount a)
        {
            try
            {
                // Ket noi
                _conn.Open();
                // Query string - vì KH_ID là identity (giá trị tự tăng dần) nên ko cần phải insert ID
                string SQL = string.Format("INSERT INTO tbl_taikhoan (sMaTK, sTaiKhoan, sMatKhau, FK_iMaQuyen) VALUES('{0}', '{1}', '{2}', '{3}')", a.SMaTK, a.STaiKhoan, a.SMatKhau, a.FK_iMaQuyen1);
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