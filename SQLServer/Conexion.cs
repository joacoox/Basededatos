using System.Data.SqlClient;

namespace SQLServer
{      
        public static class Conexion
        {
            private static SqlConnection _connection;
            private static SqlCommand _command;
            private static string _connectionString;

            static Conexion()
            {
                _connectionString = "Server=.;Database=abcd;Trusted_Connection=True;";
                _connection = new SqlConnection(_connectionString);

                _command = _connection.CreateCommand();
                // _command = new SqlCommand();
                _command.CommandType = System.Data.CommandType.Text;

            }


            public static List<Alumno> Leer()
            {
                try
                {
                    var alumnos = new List<Alumno>();

                    _connection.Open();

                    var query = "SELECT * FROM alumnos2";

                    _command.CommandText = query;

                    using (var sqlReader = _command.ExecuteReader())
                    {
                        while (sqlReader.Read())
                        {
                            var nombre = (sqlReader["nombre"].ToString() ?? "").Trim();

                            var apellido = (sqlReader["apellido"].ToString() ?? "").Trim();

                            var id = Convert.ToInt32(sqlReader["id"]);

                            alumnos.Add(new Alumno(id, nombre, apellido));
                        }
                    }

                    return alumnos;
                }
                catch
                {
                    throw;
                }
                finally
                {
                    _connection.Close();
                }
            }

            public static Alumno Leer(string id)
            {
                try
                {
                    Alumno al = null;

                    _connection.Open();

                    var query = $"SELECT * FROM alumnos2 WHERE id = @id";

                    _command.CommandText = query;
                    _command.Parameters.AddWithValue("@id",id);

                    using (var sqlReader = _command.ExecuteReader())
                    {
                        while (sqlReader.Read())
                        {
                            var nombre = (sqlReader["nombre"].ToString() ?? "").Trim();

                            var apellido = (sqlReader["apellido"].ToString() ?? "").Trim();

                            var ciudadId = Convert.ToInt32(sqlReader["ciudad_id"]);

                            var _id = Convert.ToInt32(sqlReader["id"]);

                            al = new Alumno(_id, nombre, apellido);
                        }
                    }

                    return al;
                }
                catch
                {
                    throw;
                }
                finally
                {
                _command.Parameters.Clear();
                _connection.Close();
                }
            }

            public static void Agregar(string nombre, string apellido)
            {
                try
                {
                    _connection.Open();

                    var query = $"INSERT INTO alumnos2 (nombre, apellido) VALUES ('@nombre', '@apellido')";

                    _command.CommandText = query;
                    _command.Parameters.AddWithValue("@nombre", nombre);
                     _command.Parameters.AddWithValue("@apellido", apellido);

                var affected_rows = _command.ExecuteNonQuery();

                    Console.WriteLine($"affected_rows {affected_rows}");
                }
                catch
                {
                    throw;
                }
                finally
                {
                    _command.Parameters.Clear();
                    _connection.Close();
                }
            }
        }
}