﻿using MeclisEntities.IEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeclisEntities.Base;
using System.ComponentModel.DataAnnotations;

namespace MeclisEntities.Entities
{
    public class DilTanim:EntBase
     
    {

       [Required]
       [MaxLength(50)]
        public string DilAdi { get; set; }
        [MaxLength(50)]
        public string DilSeviye { get; set; }
       

    }
} 
