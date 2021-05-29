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
    public class MeslekTanimMap : BaseMap<MeslekTanim>
    {
        public MeslekTanimMap() {
            ToTable(@"meslek_tanim", @"dbo");
            Property(x => x.MeslekAdi).HasColumnName("meslek_adi");
            Property(x=>x.UzmanlikAlani).HasColumnName("uzmanlik_alani");
          
        }
    }
}
