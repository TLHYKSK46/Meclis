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
    public class IlTanimMap : BaseMap<IlTanim>
    {
        public IlTanimMap() {
            ToTable(@"il_tanim", @"dbo");
            Property(x => x.IlKodu).HasColumnName("il_kodu");
            Property(x => x.IlAdi).HasColumnName("il_adi");
            Property(x => x.IlBolgesi).HasColumnName("il_bolgesi");
       
        




        }
    }
}
