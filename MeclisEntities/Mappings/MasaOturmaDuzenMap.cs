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
    public class MasaOturmaDuzenMap : BaseMap<MasaOturmaDuzen>
    {
        public MasaOturmaDuzenMap() {
            ToTable(@"masa_oturma_duzen", @"dbo");
            Property(x => x.Tarih).HasColumnName("tarih");
            Property(x => x.VekilTanimId).HasColumnName("vekil_tanim_id");
            Property(x => x.MasaTanimId).HasColumnName("masa_tanim_id");
        }
    }
}
