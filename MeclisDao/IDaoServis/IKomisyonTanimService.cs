using MeclisEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeclisDao.IDaoServis
{
   public interface IKomisyonTanimService
    {
        List<KomisyonTanim> ListeGetir();
       KomisyonTanim Getir(int id);
        List<KomisyonTanim> AdGoreGetir(string data);
        void Ekle(KomisyonTanim komisyonTanim);
        void Guncelle(KomisyonTanim komisyonTanim);
        void Sil(int id);
    }
}
