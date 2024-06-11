using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QUANLY
{

    public class DBConnect
    {
        //tạo chuỗi kết nối
        protected SqlConnection _conn = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QLBANHANG;Integrated Security=True");

    }
   
}
