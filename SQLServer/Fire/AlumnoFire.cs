using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLServer.Fire
{
    [FirestoreData]
    public class AlumnoFire
    {
        string nombre;
        string apellido;
        string id;

        public AlumnoFire(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public AlumnoFire(string nombre, string apellido, string id) : this(nombre, apellido)
        {
            this.id = id;
        }

        public AlumnoFire() : this("", "") { }

        [FirestoreProperty]
        public string Nombre { get => nombre; set => nombre = value; }

        [FirestoreProperty]
        public string Apellido { get => apellido; set => apellido = value; }

        [FirestoreProperty]
        public string Id { get => id; set => id = value; }
    }
}
