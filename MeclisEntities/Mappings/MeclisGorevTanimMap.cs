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
    public class MeclisGorevTanimMap : BaseMap<MeclisGorevTanim>
    {
        public MeclisGorevTanimMap() {
            ToTable(@"meclis_gorev_tanim", @"dbo");
            //HasKey(x => x.Id);
          //  Property(x => x.Id).HasColumnName("Id");
            Property(x => x.MeclisGorevAdi).HasColumnName("meclis_gorev_Adi");
           


        }
    }
}
