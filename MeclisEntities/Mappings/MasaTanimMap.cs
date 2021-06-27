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
    public class MasaTanimMap : BaseMap<MasaTanim>
    {
        public MasaTanimMap() {
            ToTable(@"masa_tanim", @"dbo");
            Property(x => x.Tarih).HasColumnName("tarih");
            Property(x => x.KacKisilik).HasColumnName("kac_kisilik");
            Property(x => x.KisaKenar1).HasColumnName("kisa_kenar_1");
            Property(x => x.KisaKenar2).HasColumnName("kisa_kenar_2");
            Property(x => x.UzunKenar1).HasColumnName("uzun_kenar_1");
            Property(x => x.UzunKenar2).HasColumnName("uzun_kenar_2");
        }
    }
}
