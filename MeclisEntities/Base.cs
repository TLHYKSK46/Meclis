﻿using MeclisEntities.IEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeclisEntities
{
   public class Base:IEntity
    {
        public DateTime Silindi { get; set; }
        public DateTime SilinmeTarihi { get; set; }
        public DateTime EklenmeTarihi { get; set; }
        public DateTime GuncellemeTarihi { get; set; }


    }
}
