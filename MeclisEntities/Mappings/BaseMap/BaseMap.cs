using MeclisEntities.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeclisEntities.Mappings.BaseMap
{
    [Serializable]
    public abstract class BaseMap<TEntityType> : BaseIdMap<TEntityType> where TEntityType : EntBase
    {

        protected BaseMap()
        {
            Property(p => p.Silindi).HasColumnName("silindi");
            Property(p => p.EklenmeTarihi).HasColumnName("eklenme_tarihi");
            Property(p => p.SilinmeTarihi).HasColumnName("silinme_tarihi");
            Property(p => p.GuncellemeTarihi).HasColumnName("guncelleme_tarihi");
            Property(p => p.GuncelleyenPersonelId).HasColumnName("guncelleyen_personel_id");
            Property(p => p.SilenPersonelId).HasColumnName("silen_personel_id");
          
        }



    }
}
