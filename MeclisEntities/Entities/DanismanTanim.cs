using MeclisEntities.IEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeclisEntities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeclisEntities.Entities
{
    public class DanismanTanim:EntBase
     
    {

        [MaxLength(11)]
        public string TcKimlikNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        [MaxLength(11)]
        public string TelNo { get; set; }
        public string Mail { get; set; }

        public bool Aktif { get; set; }
        public int CinsiyetTanimId { get; set; }
        public int IlTanimId { get; set; }
        public int VekilTanimId { get; set; }
 


    }
} 
