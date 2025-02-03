using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelier.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void TInsert(T entity);
        void TUpdate(T entity);
        void TSoftDelete(Guid id);
        void THardDelete(Guid id);
        List<T> TGetAll();
        List<T> TGetAllDeleted();
        T TGetById(Guid id);
    }
}
