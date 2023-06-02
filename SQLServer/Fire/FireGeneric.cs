using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLServer.Fire
{
    public class FireGeneric
    {
        string projectId;
        string collectionPath;

        public FireGeneric(string projectId, string collectionPath)
        {
            this.projectId = projectId;
            this.collectionPath = collectionPath;
        }

        public string ProjectId { get => projectId; set => projectId = value; }
        public string CollectionPath { get => collectionPath; set => collectionPath = value; }

        public CollectionReference ConseguircolRef() 
        {
           
            FirestoreDb db = FirestoreDb.Create(projectId);
            var colRef = db.Collection(collectionPath);

            return colRef;  
        }
    }
}
