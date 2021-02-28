using MeclisEntities.Entities;
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
        public DbSet<Product> Products { get; set; }
        public DbSet<VekilTanim> VekilTanims { get; set; }
        // public DbSet<Category> Categories { get; set; }

    }
}
