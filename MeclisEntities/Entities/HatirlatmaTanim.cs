using MeclisEntities.IEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeclisEntities.Base;

namespace MeclisEntities.Entities
{
    public class HatirlatmaTanim:EntBase
     
    {
       
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public int VekilTanimId { get; set; }
        public int HatirlatmaTarihi { get; set; }
        public int OlusturmaTarihi { get; set; }


    }
} 
