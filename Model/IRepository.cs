using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IRepository<T> where T: IDomainObject, new()
    {
        IEnumerable<T> GetAll();

        void Delete(int id);

        void Add(T Obj);

    }
}
