using MeclisEntities.IEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeclisEntities.Base;
namespace MeclisEntities.Entities
{
    public class VekilDetay:EntBase
     
    {
    
        public int VekilTanimId { get; set; }
        public string OdaNoId { get; set; }
        public string CinsiyetTanimId { get; set; }
        public string GorevId { get; set; }
        public string KomisyonTanimId { get; set; }
        public string IlTanimId { get; set; }
        public string PartiTanimId { get; set; }
        public string MazeretTanimId { get; set; }
        public string DilTanimId { get; set; }
        public int DonemTanimId { get; set; }
        public int HatirlatmaTanimId { get; set; }
        public int DostlukGrupTanimId { get; set; }
        public int MeclisGorevTanimId { get; set; }
        public int DanismanTanimId { get; set; }
        public int VekilDanismanId { get; set; }
        public int GrupPersonelTanimId { get; set; }



    }
} 
