using MeclisEntities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeclisEntities.Entities
{
   public class VekilDilTanim: EntBase
    {
        public int VekilTanimId { get; set; }
        public int DilTanimId { get; set; }
        public int DilSeviyeId { get; set; }
    }
}
