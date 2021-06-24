using MeclisEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeclisDao.IDaoServis
{
   public interface IVekilYoklamaService
    {
        List<VekilYoklama> ListeGetir();
        VekilYoklama Getir(int id);
        //List<BelgeNo> AdGoreGetir(string data);
        List<VekilYoklama> FiltreleGetir(int id);
        void Ekle(VekilYoklama data);
        void Guncelle(VekilYoklama data);
        void Sil(int id);
        int BugunListele();
        //void ExceleAktar(DataGridView dataGridView);
    }
}
