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
    public class PartiGrupTanimMap : BaseMap<PartiGrupTanim>
    {
        public PartiTanimMap() {
            ToTable(@"parti_grup_tanim", @"dbo");
            //HasKey(x => x.Id);
          //  Property(x => x.Id).HasColumnName("Id");
            Property(x => x.PartiAdi).HasColumnName("parti_grup_adi");
           


        }
    }
}
