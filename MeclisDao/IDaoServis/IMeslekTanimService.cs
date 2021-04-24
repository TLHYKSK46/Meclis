using MeclisEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeclisDao.IDaoServis
{
   public interface IMeslekTanimService
    {
        List<MeslekTanim> ListeGetir();
        MeslekTanim Getir(int id);
        List<MeslekTanim> MeslekAdiGetir(string data);
        void Ekle(MeslekTanim Data);
        void Guncelle(MeslekTanim Data);
        void Sil(int id);
        void ExceleAktar(DataGridView dataGridView);

    }
}
