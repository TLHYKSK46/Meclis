using MeclisEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeclisDao.IDaoServis
{
   public interface IMeclisGorevTanimService
    {
        List<MeclisGorevTanim> ListeGetir();
     MeclisGorevTanim Getir(int id);
        //List<CinsiyetTanim> AdGoreGetir(string productName);
        void Ekle(MeclisGorevTanim meclisGorevTanim);
        void Guncelle(MeclisGorevTanim meclisGorevTanim);
        void Sil(MeclisGorevTanim meclisGorevTanim);
    }
}
