using MeclisEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeclisDao.IDaoServis
{
   public interface IMasaOturumDuzenService
    {
        List<MasaOturmaDuzen> ListeGetir();
        MasaOturmaDuzen Getir(int id);
        //List<BelgeNo> AdGoreGetir(string data);
        //List<BelgeNo> FiltreleGetir(string tur, string value);
        void Ekle(MasaOturmaDuzen data);
        void Guncelle(MasaOturmaDuzen data);
        void Sil(int id);
        //void ExceleAktar(DataGridView dataGridView);
    }
}
