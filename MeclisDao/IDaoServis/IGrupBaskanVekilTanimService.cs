using MeclisEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeclisDao.IDaoServis
{
   public interface IGrupBaskanVekilTanimService
    {
        List<GrupBaskanVekilTanim> ListeGetir();
        GrupBaskanVekilTanim Getir(int id);
        List<GrupBaskanVekilTanim> AdGoreGetir(string data);
        void Ekle(GrupBaskanVekilTanim data);
        void Guncelle(GrupBaskanVekilTanim data);
        void Sil(int id);
        void ExceleAktar(DataGridView dataGridView);

    }
}
