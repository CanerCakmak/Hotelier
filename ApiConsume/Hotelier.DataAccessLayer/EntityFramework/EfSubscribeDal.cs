﻿using Hotelier.DataAccessLayer.Abstract;
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
    public class EfSubscribeDal : GenericRepository<Subscribe>, ISubscribeDal
    {
        private readonly AppDbContext _context;
        public EfSubscribeDal(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
