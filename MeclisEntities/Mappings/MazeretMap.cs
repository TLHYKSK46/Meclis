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
    public class MazeretMap : BaseMap<Mazeret>
    {
        public MazeretMap() {
            ToTable(@"mazeret", @"dbo");
            //HasKey(x => x.Id);
          //  Property(x => x.Id).HasColumnName("Id");
            Property(x => x.AdSoyad).HasColumnName("adsoyad");
            Property(x => x.Il).HasColumnName("il");
            Property(x => x.MazeretNedeni).HasColumnName("mazeret");





        }
    }
}
