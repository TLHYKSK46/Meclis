using MeclisEntities.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeclisEntities.Base
{
   public class EntBaseId:IEntBaseId
    {
        public int Id { get; set; }

        public override string ToString()
        {
            return base.ToString() + ";" + Id;
        }


    }
}
