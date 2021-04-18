using MeclisEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeclisDao.IDaoServis
{
   public interface IVekilDilTanimService
    {
        List<VekilDilTanim> ListeGetir();
        VekilDilTanim Getir(int id);
        //List<VekilDilTanim> AdGoreGetir(string lData);
        void Ekle(VekilDilTanim lData);
        void Guncelle(VekilDilTanim lData);
        void Sil(int id);
    }
}
