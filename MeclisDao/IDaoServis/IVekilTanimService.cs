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
         VekilTanim Getir(int id);
        List<VekilTanim> TcNoyeGoreGetir(int tcNo);
        List<VekilTanim> AdGoreGetir(string vekilAdi);
        VekilTanim AdveSoyadGoreGetir(string vekilAdi, string soyad);

        List<VekilTanim> FiltreleGetir(string tur, string value);
        void Ekle(VekilTanim vekilTanim);
        void Guncelle(VekilTanim vekilTanim);
        void Sil(int id);
    }
}
