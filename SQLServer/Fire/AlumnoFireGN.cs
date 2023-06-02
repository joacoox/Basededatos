using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLServer.Fire
{
    [FirestoreData]
    public class AlumnoFireGN : ConexionGN, IModificable<AlumnoFire>
    {     

        public AlumnoFireGN(string projectId, string collectionPath) base : (projectId, collectionPath) 
            { 

            }


        public List<AlumnoFire> Traer()
        {
            throw new NotImplementedException();
        }

        public AlumnoFire Traer(int id)
        {
            throw new NotImplementedException();
        }

        public bool Borrar(int id)
        {
            throw new NotImplementedException();
        }

        public bool Agregar(AlumnoFire objeto)
        {
            throw new NotImplementedException();
        }

        public bool Editar(AlumnoFire objeto)
        {
            throw new NotImplementedException();
        }
    }
}
