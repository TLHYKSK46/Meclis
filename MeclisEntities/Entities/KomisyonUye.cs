using MeclisEntities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeclisEntities.Entities
{
    public class KomisyonUye : EntBase
    {
        public int KomisyonTanimId { get; set; }
        public int VekilTanimId { get; set; }
        public int KomisyonUyeTuru { get; set; }
        public DateTime BaslamaTarihi { get; set; }
        public DateTime BitisTarih { get; set; }

    }
}
