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
    public class MasaTanim:EntBase
     
    {
   
       
        public DateTime Tarih { get; set; }
        public int KacKisilik { get; set; }
        public int KisaKenar1 { get; set; }
        public int KisaKenar2 { get; set; }
        public int UzunKenar1 { get; set; }
        public int UzunKenar2 { get; set; }


    }
} 
