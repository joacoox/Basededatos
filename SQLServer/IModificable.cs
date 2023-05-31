using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLServer
{
    public interface IModificable<T>
    {
        public List<T> Traer();
        public T Traer(int id);
        public bool Borrar(int id);
        public bool Agregar(T objeto);
        public bool Editar(T objeto);


    }
}
