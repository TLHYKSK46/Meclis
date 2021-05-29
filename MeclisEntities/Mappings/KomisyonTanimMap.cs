﻿using MeclisEntities.Entities;
using MeclisEntities.Mappings.BaseMap;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeclisEntities.Mappings
{
    public class KomisyonTanimMap : BaseMap<KomisyonTanim>
    {
        public KomisyonTanimMap() {
            ToTable(@"komisyon_tanim", @"dbo");
            //HasKey(x => x.Id);
          //  Property(x => x.Id).HasColumnName("Id");
            Property(x => x.KomisyonAdi).HasColumnName("komisyon_adi");
            Property(x => x.KomisyonTuru).HasColumnName("komisyon_turu");
            
       
        




        }
    }
}
