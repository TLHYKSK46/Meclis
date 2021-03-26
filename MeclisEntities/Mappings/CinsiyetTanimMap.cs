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
    public class CinsiyetTanimMap : BaseMap<CinsiyetTanim>
    {
        public CinsiyetTanimMap() {
            ToTable(@"cinsiyet_tanim", @"dbo");
            //HasKey(x => x.Id);
          //  Property(x => x.Id).HasColumnName("Id");
            Property(x => x.CinsiyetAdi).HasColumnName("cinsiyet");
            
        }
    }
}
