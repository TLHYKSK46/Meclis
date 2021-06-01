using MeclisEntities.Entities;
using MeclisEntities.Mappings.BaseMap;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeclisEntities.Mappings
{
    public class KomisyonUyeMap : BaseMap<KomisyonUye>
    {
        public KomisyonUyeMap() {
            ToTable(@"komisyon_uye", @"dbo");
          
            Property(x => x.KomisyonTanimId).HasColumnName("komisyon_tanim_id");
            Property(x => x.KomisyonUyeTuru).HasColumnName("komisyon_uye_turu");
            Property(x => x.VekilTanimId).HasColumnName("vekil_tanim_id");
            Property(x => x.BaslamaTarihi).HasColumnName("baslama_tarihi");
            Property(x => x.BitisTarih).HasColumnName("bitis_tarihi");







        }
    }
}
