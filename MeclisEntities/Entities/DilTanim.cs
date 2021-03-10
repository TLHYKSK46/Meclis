using MeclisEntities.IEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeclisEntities.Entities
{
    public class DilTanim:Base
     
    {
        public int Id { get; set; }
        public string DilAdi { get; set; }
        public string DilSeviye { get; set; }
       

    }
} 
