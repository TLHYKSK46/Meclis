using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeclisDao.Enums
{
    public enum DilSeviye
    {
        [Description("Temel Seviye")]
        Temel = 0,
        [Description("Orta Seviye")]
        Orta = 1,
        [Description("İleri Seviye")]
        Ileri = 2
    }
}
