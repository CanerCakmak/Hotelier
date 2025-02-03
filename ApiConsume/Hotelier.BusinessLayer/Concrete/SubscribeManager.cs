using Hotelier.BusinessLayer.Abstract;
using Hotelier.DataAccessLayer.Abstract;
using Hotelier.DataAccessLayer.EntityFramework;
using Hotelier.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelier.BusinessLayer.Concrete
{
    public class SubscribeManager : ISubscribeService
    {
        private readonly ISubscribeDal _subscribeDal;

        public SubscribeManager(ISubscribeDal subscribeDal)
        {
            _subscribeDal = subscribeDal;
        }

        public List<Subscribe> TGetAll()
        {
            return _subscribeDal.GetAll();
        }

        public List<Subscribe> TGetAllDeleted()
        {
            return _subscribeDal.GetAllDeleted();
        }

        public Subscribe TGetById(Guid id)
        {
            return _subscribeDal.GetById(id);
        }

        public void THardDelete(Guid id)
        {
            _subscribeDal.HardDelete(id);
        }

        public void TInsert(Subscribe entity)
        {
            _subscribeDal.Insert(entity);
        }

        public void TSoftDelete(Guid id)
        {
            _subscribeDal.SoftDelete(id);
        }

        public void TUpdate(Subscribe entity)
        {
            _subscribeDal.Update(entity);
        }
    }
}
