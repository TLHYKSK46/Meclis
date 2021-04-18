using MeclisEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeclisDao.IDaoServis
{
   public interface IDilVekilTanimService
    {
        List<DilVekilTanim> ListeGetir();
        DilVekilTanim Getir(int id);
       // List<DilVekilTanim> AdGoreGetir(string data);
        void Ekle(DilVekilTanim data);
        void Guncelle(DilVekilTanim data);
        void Sil(int id);
    }
}
