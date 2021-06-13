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
    public class OturumMap : BaseMap<Oturum>
    {
        public OturumMap() {
            ToTable(@"oturum", @"dbo");
            //HasKey(x => x.Id);
          //  Property(x => x.Id).HasColumnName("Id");
            Property(x => x.OturumAdi).HasColumnName("oturum_adi");
            Property(x => x.OturumZamani).HasColumnName("oturum_zamani");
     





        }
    }
}
