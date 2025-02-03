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
    public class StaffManager : IStaffService
    {
        private readonly IStaffDal _staffDal;

        public StaffManager(IStaffDal staffDal)
        {
            _staffDal = staffDal;
        }

        public List<Staff> TGetAll()
        {
            return _staffDal.GetAll();
        }

        public List<Staff> TGetAllDeleted()
        {
            return _staffDal.GetAllDeleted();
        }

        public Staff TGetById(Guid id)
        {
            return _staffDal.GetById(id);
        }

        public void THardDelete(Guid id)
        {
            _staffDal.HardDelete(id);
        }

        public void TInsert(Staff entity)
        {
            _staffDal.Insert(entity);
        }

        public void TSoftDelete(Guid id)
        {
            _staffDal.SoftDelete(id);
        }

        public void TUpdate(Staff entity)
        {
            _staffDal.Update(entity);
        }
    }
}
