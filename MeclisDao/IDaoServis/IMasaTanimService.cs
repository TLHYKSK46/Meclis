using MeclisEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeclisDao.IDaoServis
{
   public interface IMasaTanimService
    {
        List<MasaTanim> ListeGetir();
        MasaTanim Getir(int id);
        //List<BelgeNo> AdGoreGetir(string data);
        //List<BelgeNo> FiltreleGetir(string tur, string value);
        void Ekle(MasaTanim data);
        void Guncelle(MasaTanim data);
        void Sil(int id);
        //void ExceleAktar(DataGridView dataGridView);
    }
}
