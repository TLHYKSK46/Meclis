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
    public class DilVekilTanimMap : BaseMap<DilVekilTanim>
    {
        public DilVekilTanimMap() {
            ToTable(@"dil_vekil_tanim", @"dbo");
            Property(x => x.VekilTanimId).HasColumnName("vekil_tanim_id");
            Property(x => x.DilSeviyeId).HasColumnName("dil_seviye_id");
            Property(x => x.DilTanimId).HasColumnName("dil_tanim_id");



        }
    }
}
