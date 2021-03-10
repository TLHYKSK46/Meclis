using MeclisEntities.IEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeclisEntities.Entities
{
    public class DanismanTanim:Base
     
    {
        public int Id { get; set; }
        public int TcKimlikNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TelNo { get; set; }
        public string Mail { get; set; }
        public int Aktif { get; set; }
        public int CinsiyetTanimId { get; set; }
        public int lTanim{ get; set; }

    }
} 
