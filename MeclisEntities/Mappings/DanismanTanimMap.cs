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
    public class DanismanTanimMap : BaseMap<DanismanTanim>
    {
        public DanismanTanimMap() {
            ToTable(@"danisman_tanim", @"dbo");
        
            Property(x => x.Ad).HasColumnName("ad");
            Property(x => x.Soyad).HasColumnName("soyad");
            Property(x => x.TcKimlikNo).HasColumnName("tc_kimlik_no");
            Property(x => x.TelNo).HasColumnName("tel_no");
            Property(x => x.Mail).HasColumnName("mail");
            Property(x => x.CinsiyetTanimId).HasColumnName("cinsiyet_tanim_id");
            Property(x => x.IlTanimId ).HasColumnName("il_tanim_id");
            Property(x => x.VekilTanimId).HasColumnName("vekil_tanim_id");
            Property(x => x.Aktif).HasColumnName("aktif");
            
            
            
            
            
            
        



        }
    }
}
