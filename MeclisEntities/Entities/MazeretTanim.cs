using MeclisEntities.IEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeclisEntities.Base;

namespace MeclisEntities.Entities
{
    public class MazeretTanim:EntBase
     
    {
      
        public int VekilTanimId { get; set; }
        public int MazeretKodId { get; set; }
        public string MazeretNedeni { get; set; }
        public DateTime BaslamaTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }

    }
} 
