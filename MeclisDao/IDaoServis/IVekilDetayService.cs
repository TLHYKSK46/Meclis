using MeclisEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeclisDao.IDaoServis
{
   public interface IVekilDetayService
    {
        List<VekilDetay> ListeGetir();
  
        VekilDetay Getir(int id);
        List<VekilDetay> TcNoyeGöreGetir(int tcNo);
        List<VekilDetay> AdGoreGetir(string vekilAdi);
        void Ekle(VekilDetay vekilDetay);
        void Guncelle(VekilDetay vekilDetay);
        void Sil(int id);
    }
}
