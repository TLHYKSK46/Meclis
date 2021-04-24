using MeclisEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeclisDao.IDaoServis
{
   public interface IGrupPersonelTanimService
    {
        List<GrupPersonelTanim> ListeGetir();
        GrupPersonelTanim Getir(int id);
        List<GrupPersonelTanim> AdGoreGetir(string data);
        void Ekle(GrupPersonelTanim grupPersonelTanim);
        void Guncelle(GrupPersonelTanim grupPersonelTanim);
        void Sil(int id);
        void ExceleAktar(DataGridView dataGridView);

    }
}
