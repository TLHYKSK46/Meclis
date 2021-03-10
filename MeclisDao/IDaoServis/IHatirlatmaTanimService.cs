using MeclisEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeclisDao.IDaoServis
{
   public interface IHatirlatmaTanimService
    {
        List<HatirlatmaTanim> ListeGetir();
        HatirlatmaTanim Getir(int id);
        //List<CinsiyetTanim> AdGoreGetir(string productName);
        void Ekle(HatirlatmaTanim hatirlatmaTanim);
        void Guncelle(HatirlatmaTanim hatirlatmaTanim);
        void Sil(HatirlatmaTanim hatirlatmaTanim);
    }
}
