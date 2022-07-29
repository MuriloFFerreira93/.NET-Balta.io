using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleBlog_DapperContrib
{
    public static class Database
    {
        private const string CONNECTION_STRING = @"Server=localhost,1433;Database=Blog;User ID = sa; Password=1q2w3e4r@#$;Trusted_Connection=False; TrustServerCertificate=True;";

        public static SqlConnection Connection = new SqlConnection(CONNECTION_STRING);

    }
}
