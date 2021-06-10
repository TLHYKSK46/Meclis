using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeclisDao.Enums
{
  public enum MazeretKod
    {
        [Description("Yurt Dışı")]
        YurtDisi=0,
        [Description("Mazeret")]
        Mazeret=1,
        [Description("Raporlu")]
        Raporlu = 2,
        [Description("Komisyon")]
        Komisyon = 3,
        [Description("G")]
        G = 4

    }
}
