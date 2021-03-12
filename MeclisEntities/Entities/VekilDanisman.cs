using MeclisEntities.IEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeclisEntities.Base;

namespace MeclisEntities.Entities
{
    public class VekilDanisman:EntBase
     
    {
      
        public int VekilTanimId { get; set; }
        public int DanismanTanimId { get; set; }
        public int Sira { get; set; }

    }
} 
