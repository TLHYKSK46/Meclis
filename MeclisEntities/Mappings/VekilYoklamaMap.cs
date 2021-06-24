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
    public class VekilYoklamaMap : BaseMap<VekilYoklama>
    {
        public VekilYoklamaMap() {
            ToTable(@"vekil_yoklama", @"dbo");
            //HasKey(x => x.Id);
          //  Property(x => x.Id).HasColumnName("Id");
            Property(x => x.OturumId).HasColumnName("oturum_id");
            Property(x => x.VekilTanimId).HasColumnName("vekil_tanim_id");
            Property(x => x.Pusulali).HasColumnName("pusulali");
            Property(x => x.Katildimi).HasColumnName("katildimi");
            Property(x => x.Pusulali).HasColumnName("pusulali");





        }
    }
}
