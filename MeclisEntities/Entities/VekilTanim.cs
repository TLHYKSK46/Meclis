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
    public class VekilTanim:EntBase
     
    {
      
        [MaxLength(11)]
        public string TcKimlikNo { get; set; }
        [MaxLength(100)]
        public string Ad { get; set; }
        [MaxLength(100)]
        public string Soyad { get; set; }
        public int CinsiyetTanimId { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string DogumYeri { get; set; }
        [MaxLength(11)]
        public string KurumsalTelNo { get; set; }
        [MaxLength(11)]
        public string KisiselTelNo { get; set; }
        [MaxLength(100)]
        public string KurumsalMail { get; set; }
        [MaxLength(100)]
        public string Kisiselmail { get; set; }
        public string Aciklama { get; set; }
        public string Ozgecmis { get; set; }
        public bool Aktif { get; set; }


    }
} 
