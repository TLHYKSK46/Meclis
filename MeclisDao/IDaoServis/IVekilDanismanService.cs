using MeclisEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeclisDao.IDaoServis
{
   public interface IVekilDanismanService
    {
        List<VekilDanisman> ListeGetir();
        VekilDanisman Getir(int id);
        //List<CinsiyetTanim> AdGoreGetir(string productName);
        void Ekle(VekilDanisman vekilDanisman);
        void Guncelle(VekilDanisman vekilDanisman);
        void Sil(VekilDanisman vekilDanisman);
    }
}
