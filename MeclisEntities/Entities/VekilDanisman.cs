using MeclisEntities.IEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeclisEntities.Entities
{
    public class VekilDanisman:IEntity
     
    {
        public int Id { get; set; }
        public int VekilTanimId { get; set; }
        public int DanismanTanimId { get; set; }
        public int Sira { get; set; }

    }
} 
