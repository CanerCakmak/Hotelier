using Hotelier.DataAccessLayer.Abstract;
using Hotelier.DataAccessLayer.Context;
using Hotelier.DataAccessLayer.Repositories;
using Hotelier.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelier.DataAccessLayer.EntityFramework
{
    public class EfServiceDal : GenericRepository<Service>, IServiceDal
    {
        private readonly AppDbContext _context;
        public EfServiceDal(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
