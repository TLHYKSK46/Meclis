using MeclisEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeclisDao.IDaoServis
{
   public interface IDilSeviyeTanimService
    {
        List<DilSeviyeTanim> ListeGetir();
        DilSeviyeTanim Getir(int id);
        List<DilSeviyeTanim> AdGoreGetir(string data);
        void Ekle(DilSeviyeTanim data);
        void Guncelle(DilSeviyeTanim data);
        void Sil(int id);
        
    }
}
