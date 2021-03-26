using MeclisEntities.Base;
using MeclisEntities.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeclisEntities.IEntities
{
  public  interface IEntity:IEntBaseId
    {
         short Silindi { get; set; }
         DateTime? SilinmeTarihi { get; set; }
         DateTime EklenmeTarihi { get; set; }
         DateTime? GuncellemeTarihi { get; set; }
         int? SilenPersonelId { get; set; }
         int? GuncelleyenPersonelId { get; set; }

    }
}
