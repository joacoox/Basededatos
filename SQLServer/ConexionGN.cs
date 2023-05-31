using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLServer
{
    public abstract class ConexionGN
    {
        protected SqlConnection _connection;
        private string _connectionString;

        public ConexionGN(string connecString) 
        { 
        this._connectionString = connecString;
        }

        protected void Conectar() 
        {
            _connection = new SqlConnection(_connectionString);
            _connection.Open();
        }

        protected void Cerrar() 
        {
            _connection.Close();
        }
    }
}
