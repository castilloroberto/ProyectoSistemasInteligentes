using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Database
{
    public class Conexion
    {


        protected SqlConnection GetConnection()
        {
            string connection = @"Server=localhost\SQLEXPRESS;Database=northwind;Trusted_Connection=true";
            return new SqlConnection(connection);
        }
    }
}
