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
        List<DoslukGrupTanim> ListeGetir();
        DoslukGrupTanim Getir(int id);
        //List<CinsiyetTanim> AdGoreGetir(string productName);
        void Ekle(DoslukGrupTanim doslukGrupTanim);
        void Guncelle(DoslukGrupTanim doslukGrupTanim);
        void Sil(int id);
    }
}
