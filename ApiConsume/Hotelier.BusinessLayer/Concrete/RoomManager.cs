using Hotelier.BusinessLayer.Abstract;
using Hotelier.DataAccessLayer.Abstract;
using Hotelier.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelier.BusinessLayer.Concrete
{
    public class RoomManager : IRoomService
    {
        private readonly IRoomDal _roomDal;

        public RoomManager(IRoomDal roomDal)
        {
            _roomDal = roomDal;
        }

        public List<Room> TGetAll()
        {
            return _roomDal.GetAll();
        }

        public List<Room> TGetAllDeleted()
        {
            return _roomDal.GetAllDeleted();
        }

        public Room TGetById(Guid id)
        {
            return _roomDal.GetById(id);
        }

        public void THardDelete(Guid id)
        {
            _roomDal.HardDelete(id);
        }

        public void TInsert(Room entity)
        {
            _roomDal.Insert(entity);
        }

        public void TSoftDelete(Guid id)
        {
            _roomDal.SoftDelete(id);
        }

        public void TUpdate(Room entity)
        {
            _roomDal.Update(entity);
        }
    }
}
