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
    public class GrupPersonelTanim:EntBase
     
    {

        [MaxLength(11)]
        public string TcKimlikNo { get; set; }
        [MaxLength(100)]
        public string Ad { get; set; }
        [MaxLength(100)]
        public string Soyad { get; set; }
        [MaxLength(11)]
        public string TelNo { get; set; }
        [MaxLength(100)]
        public string Mail { get; set; }
        public bool Aktif { get; set; }
        public int CinsiyetTanimId { get; set; }
        public int IlTanimId{ get; set; }
        public int MeclisGorevId { get; set; }
        public string Sifre { get; set; }
    }
} 
