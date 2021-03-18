using MeclisEntities.IEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeclisEntities.Base;
using System.ComponentModel.DataAnnotations;

namespace MeclisEntities.Entities
{
    public class PartiTanim:EntBase
     
    {
   
        [MaxLength(200)]
        public string PartiAdi { get; set; }


    }
} 
