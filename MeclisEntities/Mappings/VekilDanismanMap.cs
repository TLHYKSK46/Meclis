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
    public class VekilDanismanMap : BaseMap<VekilDanisman>
    {
        public VekilDanismanMap() {
            ToTable(@"vekil_danisman", @"dbo");
            //HasKey(x => x.Id);
          //  Property(x => x.Id).HasColumnName("Id");
            Property(x => x.VekilTanimId).HasColumnName("vekil_tanim_id");
            Property(x => x.DanismanTanimId).HasColumnName("danisman_tanim_id");
            Property(x => x.Sira).HasColumnName("sira");



        }
    }
}
