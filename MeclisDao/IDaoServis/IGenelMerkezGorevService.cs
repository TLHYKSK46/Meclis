using MeclisEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeclisDao.IDaoServis
{
   public interface IGenelMerkezGorevService
    {
        List<GenelMerkezGorev> ListeGetir();
        GenelMerkezGorev Getir(int id);
        List<GenelMerkezGorev> AdGoreGetir(string data);
        void Ekle(GenelMerkezGorev genelMerkezGorev);
        void Guncelle(GenelMerkezGorev genelMerkezGorev);
        void Sil(int id);
    }
}
