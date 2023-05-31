using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLServer
{
    public class Consulta : ConexionGN
    {
        private static SqlCommand _command;
        public Consulta(string _connection) : base(_connection)// string de conexion 
        {
            _command = new SqlCommand();
            _command.CommandType = CommandType.Text;
        }

        protected DataTable EjecutarQuery(string query) 
        {
            try
            {
                Conectar();

                _command.Connection = _connection;
                _command.CommandText = query;

                var sqlReader = _command.ExecuteReader();

                var dataTable = new DataTable();

                dataTable.Load(sqlReader);

                sqlReader.Close();
                return dataTable;   
            }
            catch
            {
                throw;
            }
            finally
            {
                Cerrar();
            }

        }

        protected void EjecutarNonQuery(string query)
        {


        }
    }
}
