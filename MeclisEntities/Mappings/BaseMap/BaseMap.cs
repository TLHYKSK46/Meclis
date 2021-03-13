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
            //Property(p => p.SysGuncelleyenOturum).HasColumnName("SYS_GUNCELLEYEN_OTURUM");
            //Property(p => p.SysSilenOturum).HasColumnName("SYS_SILEN_OTURUM");
            //Property(p => p.SysSilmeTarihi).HasColumnName("SYS_SILME_TARIHI");
            //Property(p => p.SysVersiyon).HasColumnName("SYS_VERSIYON");
        }



    }
}
