using MeclisEntities.IEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeclisEntities.Base;

namespace MeclisEntities.Entities
{
    public class KomisyonTanim:EntBase
     
    {
        public int Id { get; set; }
        public int IhtisasId { get; set; }
        public string UluslararasıId { get; set; }
        


    }
} 
