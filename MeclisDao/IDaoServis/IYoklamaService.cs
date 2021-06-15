using MeclisEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeclisDao.IDaoServis
{
   public interface IYoklamaService
    {
        List<Yoklama> ListeGetir();
        Yoklama Getir(int id);
        //List<BelgeNo> AdGoreGetir(string data);
        //List<BelgeNo> FiltreleGetir(string tur, string value);
        void Ekle(Yoklama data);
        void Guncelle(Yoklama data);
        void Sil(int id);
        int BugunListele();
        //void ExceleAktar(DataGridView dataGridView);
    }
}
