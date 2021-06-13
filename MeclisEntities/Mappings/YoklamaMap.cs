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
    public class YoklamaMap : BaseMap<Yoklama>
    {
        public YoklamaMap() {
            ToTable(@"yoklama", @"dbo");
            //HasKey(x => x.Id);
          //  Property(x => x.Id).HasColumnName("Id");
            Property(x => x.OturumId).HasColumnName("oturum_id");
            Property(x => x.Il).HasColumnName("il");
            Property(x => x.AdSoyad).HasColumnName("ad_soyad");
            Property(x => x.Katildi).HasColumnName("katildi");
            Property(x => x.Mazeret).HasColumnName("mazeret");
            Property(x => x.Pusulali).HasColumnName("pusulali");





        }
    }
}
