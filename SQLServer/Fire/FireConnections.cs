using Google.Cloud.Firestore;
using Google.Cloud.Firestore.V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLServer.Fire
{
    public  class FireConnections
    {
        public static async Task<DocumentReference> Agregar(string nombre, string apellido) 
        {

            var projectId = "prog-2-e0bdd";

            FirestoreDb db = FirestoreDb.Create(projectId);

            var colRef = db.Collection("alumnos");

            //colRef.Document("0MsyCmMqVROcJLIQoXkT");

            var alumno = new AlumnoFire(nombre, apellido);

            var rta = await colRef.AddAsync(alumno);

            Thread hilo = Thread.CurrentThread;

           int  hiloId = hilo.ManagedThreadId; 

            Console.WriteLine($"hilo; {hiloId}");

            return rta;
        }

        public static async Task<List<AlumnoFire>> Leer() 
        {
            var listaAlumnos = new List<AlumnoFire>();

            var projectId = "prog-2-e0bdd";

            FirestoreDb db = FirestoreDb.Create(projectId);

            var colRef = db.Collection("alumnos2");

            var query = colRef.Limit(20);

            var snapsShot = await query.GetSnapshotAsync();

            var lista = snapsShot.ToList();

            foreach (var item in lista)
            {
                var alumno = item.ConvertTo<AlumnoFire>();

                listaAlumnos.Add(alumno);
            }

            return listaAlumnos;
        }

        public static FirestoreChangeListener TraerRealTime()
        {
            var listaAlumnos = new List<AlumnoFire>();

            var projectId = "prog-2-e0bdd";

            FirestoreDb db = FirestoreDb.Create(projectId);

            var colRef = db.Collection("alumnos2");

            var query = colRef.Limit(20);
          
            FirestoreChangeListener listener = query.Listen(snapshot => {

                foreach (var item in snapshot)
                {
                    AlumnoFire alumno = item.ConvertTo<AlumnoFire>();
                    alumno.Id = item.Id;

                    Console.WriteLine(alumno.Nombre + " " + alumno.Apellido);
                }

            });  

            return listener;
        }
    }
}
