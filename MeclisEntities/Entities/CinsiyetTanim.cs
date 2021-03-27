using MeclisEntities.Base;
using MeclisEntities.IEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeclisEntities.Entities
{
    public class CinsiyetTanim:EntBase
     
    {

       // [MaxLength(2)]
        public string CinsiyetAdi { get; set; } 
        

    }
} 
