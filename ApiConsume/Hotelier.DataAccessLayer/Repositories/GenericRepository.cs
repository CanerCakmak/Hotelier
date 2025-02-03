using Hotelier.DataAccessLayer.Abstract;
using Hotelier.DataAccessLayer.Context;
using Hotelier.EntityLayer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelier.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : BaseEntity
    {
        private readonly AppDbContext _context;

        public GenericRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public List<T> GetAllDeleted()
        {
            return _context.Set<T>().Where(x=>x.IsDeleted).ToList();
        }

        public T GetById(Guid id)
        {
            return _context.Set<T>().Find(id);
        }

        public void HardDelete(Guid id)
        {
            var value = _context.Set<T>().Find(id);

            if (value != null)
            {
                _context.Remove(value);
            }
        }

        public void Insert(T entity)
        {
            _context.Add(entity);
        }

        public void SoftDelete(Guid id)
        {
            var value = _context.Set<T>().Find(id);
            if (value != null)
            {
                value.IsDeleted = true;
                value.DeletedDate = DateTime.Now;

                _context.Update(value);
            }
        }

        public void Update(T entity)
        {
            entity.LastModifiedDate = DateTime.Now;

            _context.Update(entity);
        }
    }
}
