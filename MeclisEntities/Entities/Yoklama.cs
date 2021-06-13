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
    public class Yoklama:EntBase
     
    {
        public int OturumId { get; set; }
        public string Il { get; set; }
        public string AdSoyad { get; set; }
        public bool Katildi { get; set; }
        public string Mazeret { get; set; }
        public bool Pusulali { get; set; }
    }
} 
