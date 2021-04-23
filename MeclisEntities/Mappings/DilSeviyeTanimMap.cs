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
    public class DilSeviyeTanimMap : BaseMap<DilSeviyeTanim>
    {
        public DilSeviyeTanimMap() {
            ToTable(@"dil_seviye_tanim", @"dbo");
            Property(x => x.DilSeviye).HasColumnName("dil_seviye");
            //Property(x => x.DilSeviye).HasColumnName("dil_seviye");



        }
    }
}
