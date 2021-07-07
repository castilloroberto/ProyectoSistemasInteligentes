using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Database
{
    public class Productos:Conexion
    {


        public DataTable Obtener()
        {



            using (var Conexion = GetConnection())
            {
                Conexion.Open();
                DataTable dataTable = new DataTable();
                
                SqlCommand command = new SqlCommand("sp_VistaProductos", Conexion);
                command.CommandType = CommandType.StoredProcedure;
                
                SqlDataReader dataReader  = command.ExecuteReader();

                dataTable.Load(dataReader);

                dataReader.Close();
                Conexion.Close();

                return dataTable;


            }




        } 

    }
}
