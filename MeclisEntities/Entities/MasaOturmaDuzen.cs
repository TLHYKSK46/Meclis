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
    public class MasaOturmaDuzen : EntBase
     
    {
   
       
        public DateTime Tarih { get; set; }
        public int VekilTanimId { get; set; }
        public int MasaTanimId { get; set; }


    }
} 
