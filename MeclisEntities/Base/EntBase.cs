using MeclisEntities.Base;
using MeclisEntities.IEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeclisEntities.Base
{
    [Serializable]
    public class EntBase : EntBaseId, IEntity
    {
        public short Silindi { get; set; }
        public DateTime? SilinmeTarihi { get; set; }
        public DateTime EklenmeTarihi { get; set; } 
        public DateTime? GuncellemeTarihi { get; set; } = DateTime.Now;
        public int? SilenPersonelId { get; set; }
        public int? GuncelleyenPersonelId { get; set; }
    }
}
