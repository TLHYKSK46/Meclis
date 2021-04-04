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
            //HasKey(x => x.Id);
            //  Property(x => x.Id).HasColumnName("Id");
            Property(x => x.TcKimlikNo).HasColumnName("tc_kimlik_no");
            Property(x => x.Ad).HasColumnName("ad");
            Property(x => x.Soyad).HasColumnName("soyad");
            Property(x => x.Dogum_Tarihi).HasColumnName("dogum_tarihi");
            Property(x => x.Dogum_Yeri).HasColumnName("dogum_yeri");
            Property(x => x.KurumsalTelNo).HasColumnName("kurumsal_tel_no");
            Property(x => x.KisiselTelNo).HasColumnName("kisisel_tel_no");
            Property(x => x.KurumsalMail).HasColumnName("kurumsal_mail");
            Property(x => x.Kisiselmail).HasColumnName("kisisel_mail");
            Property(x => x.Aciklama).HasColumnName("aciklama");
            Property(x => x.Ozgecmis).HasColumnName("ozgecmis");
            Property(x => x.Aktif).HasColumnName("aktif");
            



        }
    }
}
