using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLServer
{   
    public class AlumnoDB : Consulta, IModificable<Alumno>
    {

        public AlumnoDB() : base() 
        {


        }

        public bool Agregar(Alumno objeto)
        {
            throw new NotImplementedException();
        }

        public bool Borrar(int id)
        {
            throw new NotImplementedException();
        }

        public bool Editar(Alumno objeto)
        {
            throw new NotImplementedException();
        }

        public List<Alumno>Traer()
        {
            var alumnos = new List<Alumno>();


          var dataTable = EjecutarQuery("SELECT * FROM alumnos2");

            foreach (DataRow item in dataTable.Rows)
            {
                var nombre = item["nombre"].ToString();
                var apellido = item["apellido"].ToString();
                var id = Convert.ToInt32(item["id"]);

                alumnos.Add(new(id,nombre,apellido));
            }

            return alumnos;
        }

        public Alumno Traer(int id)
        {
            throw new NotImplementedException();
        }
    }
}
