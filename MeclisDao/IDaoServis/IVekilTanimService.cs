using MeclisEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeclisDao.IDaoServis
{
   public interface IVekilTanimService
    {
        List<VekilTanim> ListeGetir();
        List<VekilTanim> TcNoyeGöreGetir(int tcNo  );
        List<VekilTanim> AdGoreGetir(string vekilAdi);
        void Ekle(VekilTanim vekilTanim);
        void Guncelle(VekilTanim vekilTanim);
        void Sil(VekilTanim vekilTanim);
    }
}
