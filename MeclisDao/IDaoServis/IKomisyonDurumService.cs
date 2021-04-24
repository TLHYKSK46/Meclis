using MeclisEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeclisDao.IDaoServis
{
   public interface IKomisyonDurumService
    {
        List<KomisyonDurum> ListeGetir();
       KomisyonDurum Getir(int id);
        //List<CinsiyetTanim> AdGoreGetir(string productName);
        void Ekle(KomisyonDurum komisyonDurum);
        void Guncelle(KomisyonDurum komisyonDurum);
        void Sil(int id);
        void ExceleAktar(DataGridView dataGridView);

    }
}
