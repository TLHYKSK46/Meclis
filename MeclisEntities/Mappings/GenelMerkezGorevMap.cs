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
    public class GenelMerkezGorevMap : BaseMap<GenelMerkezGorev>
    {
        public GenelMerkezGorevMap() {
            ToTable(@"genel_merkez_gorev", @"dbo");
            //HasKey(x => x.Id);
          //  Property(x => x.Id).HasColumnName("Id");
            Property(x => x.GenelMerkezGorevAdi).HasColumnName("genel_merkez_gorev_adi");
            



        }
    }
}
