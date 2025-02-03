using Hotelier.EntityLayer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelier.DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : BaseEntity
    {
        void Insert(T entity);
        void Update(T entity);
        void SoftDelete(Guid id);
        void HardDelete(Guid id);
        List<T> GetAll();
        List<T> GetAllDeleted();
        T GetById(Guid id);

    }
}
