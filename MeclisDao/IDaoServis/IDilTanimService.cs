using MeclisEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeclisDao.IDaoServis
{
   public interface IDilTanimService
    {
        List<DilTanim> ListeGetir();
        DilTanim Getir(int id);
        List<DilTanim> AdGoreGetir(string data);
        List<DilTanim> FiltreleGetir(string tur, string value);
        void Ekle(DilTanim dilTanim);
        void Guncelle(DilTanim dilTanim);
        void Sil(int id);
        void ExceleAktar(DataGridView dataGridView);
    }
}
