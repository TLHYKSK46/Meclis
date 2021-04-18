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
    public class DilVekilTanim:EntBase
     
    {

       [Required]
       [MaxLength(50)]
        public int VekilTanimId { get; set; }
        public int DilTanimId { get; set; }
        public int DilSeviyeId { get; set; }


    }
} 
