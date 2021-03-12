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
    public class DilTanimMap : BaseMap<DilTanim>
    {
        public DilTanimMap() {
            ToTable(@"dil_tanim", @"dbo");
            //HasKey(x => x.Id);
          //  Property(x => x.Id).HasColumnName("Id");
            Property(x => x.DilAdi).HasColumnName("dil_adi");
            Property(x => x.DilSeviye).HasColumnName("dil_seviye");



        }
    }
}
