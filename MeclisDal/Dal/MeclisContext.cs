using MeclisEntities.Entities;
using MeclisEntities.Mappings;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeclisDal.Dal
{
   public  class MeclisContext:DbContext
    {
       // public DbSet<Product> Products { get; set; }
        public DbSet<VekilTanim> VekilTanims { get; set; }
        public DbSet<CinsiyetTanim> CinsiyetTanims { get; set; }
        public DbSet<DilTanim> DilTanims { get; set; }
        public DbSet<DonemTanim> DonemTanims { get; set; }
        public DbSet<DostlukGrupTanim> DostlukGrupTanims { get; set; }
        public DbSet<GenelMerkezGorev> GenelMerkezGorevs { get; set; }
        public DbSet<GrupPersonelTanim> GrupPersonelTanims { get; set; }
        public DbSet<HatirlatmaTanim> HatirlatmaTanims { get; set; }
        public DbSet<KomisyonTanim> KomisyonTanims { get; set; }
        public DbSet<MazeretKod> MazeretKods { get; set; }
        public DbSet<MazeretTanim> MazeretTanims { get; set; }
        public DbSet<MeclisGorevTanim> MeclisGorevTanims { get; set; }
        public DbSet<PartiTanim> PartiTanims { get; set; }
        public DbSet<VekilDanisman> VekilDanismans { get; set; }
        public DbSet<VekilDetay> VekilDetays { get; set; }
        // public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new VekilTanimMap());
            modelBuilder.Configurations.Add(new CinsiyetTanimMap());
            modelBuilder.Configurations.Add(new DilTanimMap());
            modelBuilder.Configurations.Add(new DostlukGrupTanimMap());
            modelBuilder.Configurations.Add(new DonemTanimMap());
            modelBuilder.Configurations.Add(new GenelMerkezGorevMap());
            modelBuilder.Configurations.Add(new GrupPersonelTanimMap());
            modelBuilder.Configurations.Add(new HatirlatmaTanimMap());
            modelBuilder.Configurations.Add(new KomisyonTanimMap());
            modelBuilder.Configurations.Add(new MazeretKodMap());
            modelBuilder.Configurations.Add(new MazeretTanimMap());
            modelBuilder.Configurations.Add(new MeclisGorevTanimMap());
            modelBuilder.Configurations.Add(new PartiTanimMap());
            modelBuilder.Configurations.Add(new VekilDanismanMap());
            modelBuilder.Configurations.Add(new VekilDetayMap());
            //modelBuilder.Configurations.Add(new VekilTanimMap());

        }

    }
}
