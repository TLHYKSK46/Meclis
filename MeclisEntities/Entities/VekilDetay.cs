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
        public int OdaNoId { get; set; }
        //public int CinsiyetTanimId { get; set; }
       // public int GorevId { get; set; }
        public int KomisyonDurumId { get; set; }
        public int IlTanimId { get; set; }
        public int PartiTanimId { get; set; }
        public int PartiGrupTanimId { get; set; }
      //  public int MazeretTanimId { get; set; } 
       // public int DilTanimId { get; set; }
        public int DonemTanimId { get; set; }
       // public int HatirlatmaTanimId { get; set; }
        public int DostlukGrupTanimId { get; set; }
        public int MeclisGorevTanimId { get; set; }
        //public int DanismanTanimId { get; set; }
        //public int VekilDanismanId { get; set; }
       // public int GrupPersonelTanimId { get; set; }
        public int MeslekTanimId { get; set; }



    }
} 
