using MeclisEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeclisDao.IDaoServis
{
   public interface IDilTanimService
    {
        List<DilTanim> ListeGetir();
        DilTanim Getir(int id);
        //List<CinsiyetTanim> AdGoreGetir(string productName);
        void Ekle(DilTanim dilTanim);
        void Guncelle(DilTanim dilTanim);
        void Sil(int id);
    }
}
