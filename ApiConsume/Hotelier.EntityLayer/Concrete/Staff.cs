﻿using Hotelier.EntityLayer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelier.EntityLayer.Concrete
{
    public class Staff : BaseEntity
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string SocialMedia1 { get; set; }
        public string SocialMedia2 { get; set; }
        public string SocialMedia3 { get; set; }


    }
}
