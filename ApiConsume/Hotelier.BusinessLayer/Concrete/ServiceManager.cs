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
    public class ServiceManager : IServiceService
    {
        private readonly IServiceDal _serviceDal;

        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public List<Service> TGetAll()
        {
            return _serviceDal.GetAll();
        }

        public List<Service> TGetAllDeleted()
        {
            return _serviceDal.GetAllDeleted();
        }

        public Service TGetById(Guid id)
        {
            return _serviceDal.GetById(id);
        }

        public void THardDelete(Guid id)
        {
            _serviceDal.HardDelete(id);
        }

        public void TInsert(Service entity)
        {
            _serviceDal.Insert(entity);
        }

        public void TSoftDelete(Guid id)
        {
            _serviceDal.SoftDelete(id);
        }

        public void TUpdate(Service entity)
        {
            _serviceDal.Update(entity);
        }
    }
}
