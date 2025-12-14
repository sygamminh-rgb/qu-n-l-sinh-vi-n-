using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlsv.QLSV.DAL
{
    using MODEL;
    using qlsv.QLSV.MODEL.MODEL;
    using System.Data;
    using System.Data.SqlClient;

    namespace DAL
    {
        public class SinhVienDAL : DBConnect
        {
            public DataTable GetAll()
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM SinhVien", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }

            public void Insert(SinhVien sv)
            {
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO SinhVien VALUES (@MaSV,@HoTen,@NgaySinh,@GioiTinh,@MaLop)", conn);
                cmd.Parameters.AddWithValue("@MaSV", sv.MaSV);
                cmd.Parameters.AddWithValue("@HoTen", sv.HoTen);
                cmd.Parameters.AddWithValue("@NgaySinh", sv.NgaySinh);
                cmd.Parameters.AddWithValue("@GioiTinh", sv.GioiTinh);
                cmd.Parameters.AddWithValue("@MaLop", sv.MaLop);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
     
    
}
