using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Database
{
    public class Consultas
    {
 

        private static string cadena => $"Data Source=localhost\\sqlExpress;Initial Catalog=northwind;Integrated Security=True";
        SqlConnection conexion = new SqlConnection(cadena);

        public bool Modificaciones( string sql)
        {
           
            
            conexion.Open();

            SqlCommand command = new SqlCommand(sql,conexion);

            int filasAfectadas = command.ExecuteNonQuery();
            conexion.Close();

            return filasAfectadas > 0;
            
        }

        public DataTable Consulta(string sql)
        {
           
            conexion.Open();

            SqlCommand command = new SqlCommand(sql, conexion);

            SqlDataReader reader = command.ExecuteReader();
            DataTable resultado = new DataTable();
                
            resultado.Load(reader);
               

            conexion.Close();
            reader.Close();

            return resultado;
            
        }
        public DataTable Procedimiento(string NombreProc, List<Parametro> parametros)
        {
           
            conexion.Open();

            SqlCommand command = new SqlCommand(NombreProc, conexion);
            command.CommandType = CommandType.StoredProcedure;

            foreach (Parametro parametro in parametros)
            {

                command.Parameters.AddWithValue(parametro.NombreParametro,parametro.Valorparametro);

            }

            SqlDataReader reader = command.ExecuteReader();
            DataTable resultado = new DataTable();

            resultado.Load(reader);


            conexion.Close();
            reader.Close();

            return resultado;
            
        }
        

    }
}
