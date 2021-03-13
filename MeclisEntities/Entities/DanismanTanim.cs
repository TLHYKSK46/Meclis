using MeclisEntities.IEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeclisEntities.Base;

namespace MeclisEntities.Entities
{
    public class DanismanTanim:EntBase
     
    {
       
        public int TcKimlikNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TelNo { get; set; }
        public string Mail { get; set; }
        public int Aktif { get; set; }
        public int CinsiyetTanimId { get; set; }
        public int IlTanimId { get; set; }
        public int VekilTanimId { get; set; }
 


    }
} 
