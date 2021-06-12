using MeclisEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeclisDao.IDaoServis
{
   public interface IBelgeNoService
    {
        List<BelgeNo> ListeGetir();
        BelgeNo Getir(int id);
        //List<BelgeNo> AdGoreGetir(string data);
        //List<BelgeNo> FiltreleGetir(string tur, string value);
        void Ekle(BelgeNo no);
        void Guncelle(BelgeNo no);
        void Sil(int id);
        //void ExceleAktar(DataGridView dataGridView);
    }
}
