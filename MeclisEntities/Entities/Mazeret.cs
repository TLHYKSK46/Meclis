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
    public class Mazeret:EntBase
     
    {

        public string Il { get; set; }
        public string AdSoyad { get; set; }
        public string MazeretNedeni { get; set; }


    }
} 
