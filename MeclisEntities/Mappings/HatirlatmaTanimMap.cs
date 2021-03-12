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
    public class HatirlatmaTanimMap : BaseMap<HatirlatmaTanim>
    {
        public HatirlatmaTanimMap() {
            ToTable(@"hatirlatma_tanim", @"dbo");
            //HasKey(x => x.Id);
          //  Property(x => x.Id).HasColumnName("Id");
            Property(x => x.Baslik).HasColumnName("baslik");
            Property(x => x.Aciklama).HasColumnName("aciklama");
            Property(x => x.HatirlatmaTarihi).HasColumnName("hatirlatma_tarihi");
            Property(x => x.OlusturmaTarihi).HasColumnName("olusturma_tarihi");
            Property(x => x.VekilTanimId).HasColumnName("vekil_tanim_id");




        }
    }
}
