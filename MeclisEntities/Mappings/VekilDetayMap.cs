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
    public class VekilDetayMap : BaseMap<VekilDetay>
    {
        public VekilDetayMap() {
            ToTable(@"vekil_detay", @"dbo");
            //HasKey(x => x.Id);
          //  Property(x => x.Id).HasColumnName("Id");
            Property(x => x.VekilTanimId).HasColumnName("vekil_tanim_id");
            Property(x => x.OdaNoId).HasColumnName("oda_no_id");
            Property(x => x.CinsiyetTanimId).HasColumnName("cinsiyet_tanim_id");
            Property(x => x.GorevId).HasColumnName("gorev_id");
            Property(x => x.KomisyonDurumId).HasColumnName("komisyon_durum_id");
            Property(x => x.IlTanimId).HasColumnName("il_tanim_id");
            Property(x => x.PartiTanimId).HasColumnName("parti_tanim_id");
            Property(x=>x.PartiGrupTanimId).HasColumnName("parti_grup_tanim_id");
            Property(x => x.MazeretTanimId).HasColumnName("mazeret_tanim_id");
            Property(x => x.DilTanimId).HasColumnName("dil_tanim_id");
            Property(x => x.DonemTanimId).HasColumnName("donem_tanim_id");
            Property(x => x.HatirlatmaTanimId).HasColumnName("hatirlatma_tanim_id");
            Property(x => x.DostlukGrupTanimId).HasColumnName("dostluk_grup_tanim_id");
            Property(x => x.MeclisGorevTanimId).HasColumnName("meclis_gorev_tanim_id");
            Property(x => x.DanismanTanimId).HasColumnName("danisman_tanim_id");
            Property(x => x.VekilDanismanId).HasColumnName("vekil_danisman_id");
            Property(x => x.GrupPersonelTanimId).HasColumnName("grup_personel_tanim_id");
            Property(x=>x.MeslekTanimId).HasColumnName("meslek_tanim_id");


        }
    }
}
