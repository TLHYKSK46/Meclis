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
    public class IlTanim:EntBase
     
    {
      
        public int IlKodu { get; set; }
        [MaxLength(50)]
        public string IlAdi { get; set; }
        [MaxLength(200)]
        public string IlBolgesi { get; set; }


    }
} 
