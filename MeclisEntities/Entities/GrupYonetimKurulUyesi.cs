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
    public class GrupYonetimKurulUyesi : EntBase
     
    {
       
        public int VekilTanimId { get; set; }
        public int GrupBaskanTanimId { get; set; }
        public int GrupBaskanVekilTanimId { get; set; }


    }
} 
