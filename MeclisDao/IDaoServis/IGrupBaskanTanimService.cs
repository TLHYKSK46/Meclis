using MeclisEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeclisDao.IDaoServis
{
   public interface IGrupBaskanTanimService
    {
        List<GrupBaskanTanim> ListeGetir();
        GrupBaskanTanim Getir(int id);
        List<GrupBaskanTanim> AdGoreGetir(string data);
        void Ekle(GrupBaskanTanim data);
        void Guncelle(GrupBaskanTanim data);
        void Sil(int id);
        void ExceleAktar(DataGridView dataGridView);

    }
}
