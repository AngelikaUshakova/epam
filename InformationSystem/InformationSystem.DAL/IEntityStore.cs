using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSystem.DAL
{
    public interface IEntityStore<T>
    {
        List<T> Get();
        void Add(T entity);
        void Update(T entity);
        void Delete(int entityId);
    }
}
