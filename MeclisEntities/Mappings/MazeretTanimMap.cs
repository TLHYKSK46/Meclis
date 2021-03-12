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
    public class MazeretTanimMap : BaseMap<MazeretTanim>
    {
        public MazeretTanimMap() {
            ToTable(@"mazeret_tanim", @"dbo");
            //HasKey(x => x.Id);
          //  Property(x => x.Id).HasColumnName("Id");
            Property(x => x.VekilTanimId).HasColumnName("vekil_tanim_id");
            Property(x => x.MazeretKodId).HasColumnName("mazeret_kod_id");
            Property(x => x.MazeretNedeni).HasColumnName("mazeret_nedeni");
            Property(x => x.BaslamaTarihi).HasColumnName("baslama_tarihi");
            Property(x => x.BitisTarihi).HasColumnName("bitis_tarihi");


        }
    }
}
