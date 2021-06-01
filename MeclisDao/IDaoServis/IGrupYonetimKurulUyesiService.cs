using MeclisEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeclisDao.IDaoServis
{
   public interface IGrupYonetimKurulUyesiService
    {
        List<GrupYonetimKurulUyesi> ListeGetir();
        GrupYonetimKurulUyesi Getir(int id);
       // List<GrupYonetimKurulUyesi> AdGoreGetir(string data);
        void Ekle(GrupYonetimKurulUyesi data);
        void Guncelle(GrupYonetimKurulUyesi data);
        void Sil(int id);
        void ExceleAktar(DataGridView dataGridView);

    }
}
