using MeclisEntities.IEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeclisEntities.Entities
{
    public class MazeretKod:IEntity
     
    {
        public int Id { get; set; }
        public string MazeretKodu { get; set; }
       

    }
} 
