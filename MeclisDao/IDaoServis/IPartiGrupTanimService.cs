using MeclisEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeclisDao.IDaoServis
{
   public interface IPartiGrupTanimService
    {
        List<PartiGrupTanim> ListeGetir();
       PartiGrupTanim Getir(int id);
        //List<CinsiyetTanim> AdGoreGetir(string productName);
        void Ekle(PartiGrupTanim partiTanim);
        void Guncelle(PartiGrupTanim partiTanim);
        void Sil(int id);
    }
}
