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
    public class VekilTanimMap : BaseMap<VekilTanim>
    {
        public VekilTanimMap() {
            ToTable(@"vekil_tanim", @"dbo");
            Property(x => x.Foto).HasColumnName("foto");
            Property(x => x.TcKimlikNo).HasColumnName("tc_kimlik_no");
            Property(x => x.Ad).HasColumnName("ad");
            Property(x => x.Soyad).HasColumnName("soyad");
            Property(x=>x.CinsiyetTanimId).HasColumnName("cinsiyet_tanim_id");
            Property(x => x.DogumTarihi).HasColumnName("dogum_tarihi");
            Property(x => x.DogumYeri).HasColumnName("dogum_yeri");
            Property(x => x.KurumsalTelNo).HasColumnName("kurumsal_tel_no");
            Property(x => x.KisiselTelNo).HasColumnName("kisisel_tel_no");
            Property(x => x.KurumsalMail).HasColumnName("kurumsal_mail");
            Property(x => x.Kisiselmail).HasColumnName("kisisel_mail");
            Property(x => x.Aciklama).HasColumnName("aciklama");
            Property(x => x.Ozgecmis).HasColumnName("ozgecmis");
            Property(x => x.Aktif).HasColumnName("aktif");
            Property(x => x.OdaNo).HasColumnName("oda_no");
            Property(x => x.IlTanimId).HasColumnName("il_tanim_id");
            Property(x => x.DostlukGrupTanimId).HasColumnName("dostluk_grup_tanim_id");
            Property(x => x.MeclisGorevId).HasColumnName("meclis_gorev_tanim_id");
            Property(x => x.DonemTanimId).HasColumnName("donem_tanim_id");
            Property(x => x.IlTanimId).HasColumnName("il_tanim_id");
            Property(x => x.PartiTanimId).HasColumnName("parti_tanim_id");
            Property(x => x.PartiGrupTanimId).HasColumnName("parti_grup_tanim_id");
            Property(x => x.MeslekTanimId).HasColumnName("meslek_tanim_id");
            Property(x => x.MeslekUzmanlikAlani).HasColumnName("meslek_uzmanlik_alani");
            Property(x=>x.GenelMerkezGorevId).HasColumnName("genel_merkez_gorev_id");






        }
    }
}
