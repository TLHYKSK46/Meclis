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
    public class HatirlatmaTanim:EntBase
     
    {
        [MaxLength(500)]
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public int VekilTanimId { get; set; }
        public DateTime HatirlatmaTarihi { get; set; }
        public DateTime OlusturmaTarihi { get; set; }


    }
} 
