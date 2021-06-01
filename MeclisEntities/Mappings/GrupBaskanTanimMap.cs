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
    public class GrupBaskanTanimMap : BaseMap<GrupBaskanTanim>
    {
        public GrupBaskanTanimMap() {
            ToTable(@"grup_baskan_tanim", @"dbo");
        
            Property(x => x.VekilTanimId).HasColumnName("vekil_tanim_id");
    
        }
    }
}
