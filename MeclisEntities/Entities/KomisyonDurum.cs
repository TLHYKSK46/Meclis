using MeclisEntities.IEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeclisEntities.Base;

namespace MeclisEntities.Entities
{
    public class KomisyonDurum:EntBase
     
    {
        
        public int KomisyonTanimId { get; set; }
        public int VekilTanimId { get; set; }
        public DateTime BaslamaTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }


    }
} 
