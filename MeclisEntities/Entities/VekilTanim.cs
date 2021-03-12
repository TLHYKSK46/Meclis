using MeclisEntities.IEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeclisEntities.Base;
namespace MeclisEntities.Entities
{
    public class VekilTanim:EntBase
     
    {
        public int Id { get; set; }
        public int TcKimlikNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string KurumsalTelNo { get; set; }
        public string KisiselTelNo { get; set; }
        public string KurumsalMail { get; set; }
        public string Kisiselmail { get; set; }
        public string Aciklama { get; set; }
        public string Ozgecmis { get; set; }
        public int CinsiyetTanim { get; set; }
        public int IlTanim { get; set; }
        public int Aktif { get; set; }


    }
} 
