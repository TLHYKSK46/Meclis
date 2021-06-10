using MeclisEntities.IEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeclisEntities.Base;
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace MeclisEntities.Entities
{
    public class VekilTanim:EntBase
     
    {
        public Byte[] Foto { get; set; }
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
        public string OdaNo { get; set; }
        public int IlTanimId { get; set; }
        public int PartiTanimId { get; set; }
        public int PartiGrupTanimId { get; set; }
        public int DonemTanimId { get; set; }
        public int DostlukGrupTanimId { get; set; }
        public int MeclisGorevId { get; set; }
        public int MeslekTanimId { get; set; }
        public string MeslekUzmanlikAlani { get; set; }
        public int GenelMerkezGorevId { get; set; }



    }
} 
