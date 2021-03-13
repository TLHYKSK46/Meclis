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
    public class KomisyonDurumMap : BaseMap<KomisyonDurum>
    {
        public KomisyonDurumMap() {
            ToTable(@"komisyon_durum", @"dbo");
            //HasKey(x => x.Id);
          //  Property(x => x.Id).HasColumnName("Id");
            Property(x => x.KomisyonTanimId).HasColumnName("komisyon_tanim_id");
            Property(x => x.VekilTanimId).HasColumnName("vekil_tanim_id");
            Property(x => x.BaslamaTarihi).HasColumnName("baslama_tarihi");
            Property(x => x.BitisTarihi).HasColumnName("bitis_tarihi");







        }
    }
}
