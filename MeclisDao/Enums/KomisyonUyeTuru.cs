using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeclisDao.Enums
{
    public enum KomisyonUyeTuru
    {
        [Description("Başkan")]
        Baskan=1,
        [Description("BaşkanVekili")]
        BaskanVekili = 2,
        [Description("Katip")]
        Katip = 3,
        [Description("Sözcü")]
        Sozcu = 4,
        [Description("Uye")]
        Uye = 5,


    }
}
