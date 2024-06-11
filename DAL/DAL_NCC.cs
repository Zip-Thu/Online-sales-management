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
    public class DAL_NCC : DBConnect
    {
        //get toàn bộ ncc
        public DataTable getNCC()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NhaCungCap", _conn);
            DataTable dtNCC = new DataTable();
            da.Fill(dtNCC);
            return dtNCC;
        }

        //Thêm NCC
        public bool themNCC(DTO_NCC ncc)
        {
            try
            {
                // Ket noi
                _conn.Open();
                // Query string - vì NCC_ID là identity (giá trị tự tăng dần) nên ko cần phải insert ID
                string SQL = string.Format("INSERT INTO NhaCungCap(NCC_Name, NCC_Phone,NCC_Email, NCC_Address) VALUES('{0}', '{1}', '{2}', '{3}')", ncc.NCC_Name1, ncc.NCC_Phone1, ncc.NCC_Email1, ncc.NCC_Address1);
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

        //Sửa NCC
        public bool suaNCC(DTO_NCC ncc)
        {
            try
            {
                // Ket noi
                _conn.Open();
                // Query string
                string SQL = string.Format("UPDATE NhaCungCap SET NCC_Name = '{0}',NCC_Phone = '{1}', NCC_Email = '{2}', NCC_Address = '{3}' WHERE NCC_Id = {4}", ncc.NCC_Name1, ncc.NCC_Phone1, ncc.NCC_Email1, ncc.NCC_Address1, ncc.NCC_ID1);
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


        //Xóa NCC
        public bool xoaNCC(int NCC_Id)
        {
            try
            {
                // Ket noi
                _conn.Open();
                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM NhaCungCap WHERE NCC_ID = {0}", NCC_Id);

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
