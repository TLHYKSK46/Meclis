using MeclisEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeclisDao.IDaoServis
{
   public interface ICinsiyetTanimService
    {
        List<CinsiyetTanim> ListeGetir();
        CinsiyetTanim Getir(int id);
        //List<CinsiyetTanim> AdGoreGetir(string productName);
        void Ekle(CinsiyetTanim cinsiyetTanim);
        void Guncelle(CinsiyetTanim cinsiyetTanim);
        void Sil(int id);
    }
}
