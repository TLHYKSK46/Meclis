using MeclisEntities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeclisEntities.Mappings.BaseMap
{
   public class BaseIdMap<TEntityType>:EntityTypeConfiguration<TEntityType> where TEntityType:EntBaseId
    {
        protected BaseIdMap()
        {
            HasKey(x => x.Id);
            Property(p => p.Id).HasColumnName("id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);


        }
    }
}
