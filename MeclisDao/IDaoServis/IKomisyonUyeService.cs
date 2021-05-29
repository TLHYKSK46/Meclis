using MeclisEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeclisDao.IDaoServis
{
   public interface IKomisyonUyeService
    {
        List<KomisyonUye> ListeGetir();
        KomisyonUye Getir(int id);
        List<KomisyonUye> AdGoreGetir(string data);
        void Ekle(KomisyonUye data);
        void Guncelle(KomisyonUye data);
        void Sil(int id);
    }
}
