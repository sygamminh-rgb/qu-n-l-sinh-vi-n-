using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlsv.QLSV.DAL
{
    using System.Data.SqlClient;

    namespace DAL
    {
        public class DBConnect
        {
            protected SqlConnection conn =
                new SqlConnection(@"Data Source=.;Initial Catalog=QLSINHVIEN;Integrated Security=True");
        }
    }
    internal class DBConnect
    {
    }
}
