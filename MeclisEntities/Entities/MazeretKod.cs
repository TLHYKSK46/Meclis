using MeclisEntities.IEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeclisEntities.Base;
using System.ComponentModel.DataAnnotations;

namespace MeclisEntities.Entities
{
    public class MazeretKod:EntBase
     
    {
        [MaxLength(5)]
        public string MazeretKodu { get; set; }
       

    }
} 
