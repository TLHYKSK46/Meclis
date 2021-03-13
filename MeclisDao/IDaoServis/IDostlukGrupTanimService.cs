using MeclisEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeclisDao.IDaoServis
{
   public interface IDostlukGrupTanimService
    {
        List<DostlukGrupTanim> ListeGetir();
        DostlukGrupTanim Getir(int id);
        //List<CinsiyetTanim> AdGoreGetir(string productName);
        void Ekle(DostlukGrupTanim doslukGrupTanim);
        void Guncelle(DostlukGrupTanim doslukGrupTanim);
        void Sil(int id);
    }
}
