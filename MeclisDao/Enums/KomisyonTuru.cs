using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeclisDao.Enums
{
    public enum KomisyonTuru
    {
        [Description("UluslarasıKomisyonları")]
        Uluslararasi=1,
        [Description("İhtisasKomisyonları")]
        Ihtisas=2,
        [Description("AraştırmaKomisyon")]
        Arastirma=3,
        [Description("DostlukGrup")]
        DostlukGrup = 4,

    }
}
