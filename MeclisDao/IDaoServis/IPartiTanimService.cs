using MeclisEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeclisDao.IDaoServis
{
   public interface IPartiTanimService
    {
        List<PartiTanim> ListeGetir();
       PartiTanim Getir(int id);
        //List<CinsiyetTanim> AdGoreGetir(string productName);
        void Ekle(PartiTanim partiTanim);
        void Guncelle(PartiTanim partiTanim);
        void Sil(int id);
    }
}
