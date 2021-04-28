using MeclisEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeclisDao.IDaoServis
{
   public interface IDanismanTanimService
    {
        List<DanismanTanim> ListeGetir();
        DanismanTanim Getir(int id);
        List<DanismanTanim> FiltreleGetir(string tur, string value);
        void Ekle(DanismanTanim danismanTanim);
        void Guncelle(DanismanTanim danismanTanim);
        void Sil(int id);
        void ExceleAktar(DataGridView dataGridView);
    }
}
