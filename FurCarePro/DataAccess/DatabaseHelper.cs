using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FurCarePro.DataAccess
{
    public static class DatabaseHelper
    {
        private static string connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;
              Initial Catalog=FurCareProDB;
              Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
