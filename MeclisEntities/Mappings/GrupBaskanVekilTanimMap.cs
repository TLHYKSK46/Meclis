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
    public class GrupBaskanVekilTanimMap : BaseMap<GrupBaskanVekilTanim>
    {
        public GrupBaskanVekilTanimMap() {
            ToTable(@"grup_baskan_vekil_tanim", @"dbo");
        
            Property(x => x.VekilTanimId).HasColumnName("vekil_tanim_id");
            Property(x => x.GrupBaskanTanimId).HasColumnName("grup_baskan_tanim_id");


        }
    }
}
