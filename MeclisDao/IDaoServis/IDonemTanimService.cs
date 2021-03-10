using MeclisEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeclisDao.IDaoServis
{
   public interface IDonemTanimService
    {
        List<DonemTanim> ListeGetir();
        DonemTanim Getir(int id);
        //List<CinsiyetTanim> AdGoreGetir(string productName);
        void Ekle(DonemTanim donemTanim);
        void Guncelle(DonemTanim donemTanim);
        void Sil(int id);
    }
}
