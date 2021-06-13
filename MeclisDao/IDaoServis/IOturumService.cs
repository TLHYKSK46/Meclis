using MeclisEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeclisDao.IDaoServis
{
   public interface IOturumService
    {
        List<Oturum> ListeGetir();
        Oturum Getir(int id);
        //List<BelgeNo> AdGoreGetir(string data);
        //List<BelgeNo> FiltreleGetir(string tur, string value);
        void Ekle(Oturum data);
        void Guncelle(Oturum data);
        void Sil(int id);
        int SonKayitId();
        //void ExceleAktar(DataGridView dataGridView);
    }
}
