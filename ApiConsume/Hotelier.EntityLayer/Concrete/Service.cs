﻿using Hotelier.EntityLayer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelier.EntityLayer.Concrete
{
    public class Service : BaseEntity
    {
        public string Icon { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

    }
}
