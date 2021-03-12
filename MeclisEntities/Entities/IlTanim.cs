using MeclisEntities.IEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeclisEntities.Base;

namespace MeclisEntities.Entities
{
    public class IlTanim:EntBase
     
    {
        public int Id { get; set; }
        public int IlKodu { get; set; }
        public string IlAdi { get; set; }
        public string IlBolgesi { get; set; }


    }
} 
