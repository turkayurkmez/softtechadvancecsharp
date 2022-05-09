using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes
{
    public interface IRepository<T> where T : class, IEntity, new()
    {
        void Add(T entity);
        T GetT(int id);
    }
}
