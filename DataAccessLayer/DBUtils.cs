using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DBUtils
    {
        protected static SqlConnection con = new SqlConnection("Data Source=LAPTOP-9JUVIDVM\\SQLEXPRESS;Initial Catalog=FUMiniHotelManagement;Persist Security Info=True;User ID=sa;Password=123;Encrypt=True;Trust Server Certificate=True");
    }
}
