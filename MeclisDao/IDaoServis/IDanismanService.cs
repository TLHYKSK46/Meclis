using MeclisEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeclisDao.IDaoServis
{
   public interface IDanismanService
    {
        List<DanismanTanim> ListeGetir();
        DanismanTanim Getir(int id);
        List<DanismanTanim> AdGoreGetir(string DanismanAdi);
        void Ekle(DanismanTanim danismanTanim);
        void Guncelle(DanismanTanim danismanTanim);
        void Sil(DanismanTanim danismanTanim);
    }
}
