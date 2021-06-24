using MeclisEntities.Entities;
using MeclisEntities.Mappings;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeclisDal.BaseDb
{
   public  class MeclisContext:DbContext
    {

        public MeclisContext()
        {
            
            Database.SetInitializer<MeclisContext>(null);//Bu satır Kodlar ile veritabanındaki tabloları oluşturulmasını engeller kapatırsan kendisi otomatik olarak tabloları oluşturur..
        }
        #region DbSet
        public DbSet<Mazeret> Mazerets { get; set; }

        public DbSet<VekilTanim> VekilTanims { get; set; }
       
        public DbSet<DilTanim> DilTanims { get; set; }
        public DbSet<DanismanTanim> DanismanTanims { get; set; }
        public DbSet<DonemTanim> DonemTanims { get; set; }
        public DbSet<DostlukGrupTanim> DostlukGrupTanims { get; set; }
        public DbSet<GenelMerkezGorev> GenelMerkezGorevs { get; set; }
        public DbSet<GrupPersonelTanim> GrupPersonelTanims { get; set; }
        public DbSet<HatirlatmaTanim> HatirlatmaTanims { get; set; }
        public DbSet<KomisyonDurum> KomisyonDurums { get; set; }
        public DbSet<KomisyonTanim> KomisyonTanims { get; set; }
        public DbSet<MazeretKod> MazeretKods { get; set; }
        public DbSet<MazeretTanim> MazeretTanims { get; set; }
        public DbSet<MeclisGorevTanim> MeclisGorevTanims { get; set; }
        public DbSet<PartiGrupTanim> PartiGrupTanims { get; set; }
        public DbSet<PartiTanim> PartiTanims { get; set; }
        public DbSet<VekilDanisman> VekilDanismans { get; set; }
  
        public DbSet<IlTanim> IlTanims { get; set; }
        public DbSet<MeslekTanim> MeslekTanims { get; set; }
        public DbSet<VekilDilTanim> VekilDilTanims { get; set; }
        public DbSet<KomisyonUye> KomisyonUyes { get; set; }
        public DbSet<GrupBaskanTanim> GrupBaskanTanims { get; set; }
        public DbSet<GrupBaskanVekilTanim> GrupBaskanVekilTanims { get; set; }
        public DbSet<GrupYonetimKurulUyesi> GrupYonetimKurulUyesis { get; set; }
        public DbSet<BelgeNo> BelgeNos { get; set; }
        public DbSet<Oturum> Oturums { get; set; }
        public DbSet<Yoklama> Yoklamas { get; set; }
        public DbSet<VekilYoklama> VekilYoklamas { get; set; }




        // public DbSet<Category> Categories { get; set; }
        #endregion
        #region Mapping
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new VekilTanimMap());
            modelBuilder.Configurations.Add(new DanismanTanimMap());
            modelBuilder.Configurations.Add(new DilTanimMap());
            modelBuilder.Configurations.Add(new DostlukGrupTanimMap());
            modelBuilder.Configurations.Add(new DonemTanimMap());
            modelBuilder.Configurations.Add(new GenelMerkezGorevMap());
            modelBuilder.Configurations.Add(new GrupPersonelTanimMap());
            modelBuilder.Configurations.Add(new HatirlatmaTanimMap());
            modelBuilder.Configurations.Add(new KomisyonDurumMap());
            modelBuilder.Configurations.Add(new KomisyonTanimMap());
            modelBuilder.Configurations.Add(new MazeretKodMap());
            modelBuilder.Configurations.Add(new MazeretTanimMap());
            modelBuilder.Configurations.Add(new MeclisGorevTanimMap());
            modelBuilder.Configurations.Add(new PartiGrupTanimMap());
            modelBuilder.Configurations.Add(new PartiTanimMap());
            modelBuilder.Configurations.Add(new IlTanimMap());
            modelBuilder.Configurations.Add(new VekilDanismanMap());
            modelBuilder.Configurations.Add(new MeslekTanimMap());
            modelBuilder.Configurations.Add(new VekilDilTanimMap());
            modelBuilder.Configurations.Add(new KomisyonUyeMap());
            modelBuilder.Configurations.Add(new GrupBaskanTanimMap());
            modelBuilder.Configurations.Add(new GrupBaskanVekilTanimMap());
            modelBuilder.Configurations.Add(new GrupYonetimKurulUyesiMap());
            modelBuilder.Configurations.Add(new BelgeNoMap());
            modelBuilder.Configurations.Add(new OturumMap());
            modelBuilder.Configurations.Add(new YoklamaMap());
            modelBuilder.Configurations.Add(new MazeretMap());
            modelBuilder.Configurations.Add(new VekilYoklamaMap());





            //modelBuilder.Configurations.Add(new VekilTanimMap());
            #endregion
        }

    }
}
