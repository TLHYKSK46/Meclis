using MeclisEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeclisDao.IDaoServis
{
   public interface IMazeretService
    {
        List<Mazeret> ListeGetir();
        Mazeret Getir(int id);
        //List<BelgeNo> AdGoreGetir(string data);
        //List<BelgeNo> FiltreleGetir(string tur, string value);
        void Ekle(Mazeret data);
        void Guncelle(Mazeret data);
        void Sil(int id);
        //void ExceleAktar(DataGridView dataGridView);
    }
}
