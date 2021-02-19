using MeclisEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeclisDao.IDaoServis
{
   public interface IProductService
    {
        List<Product> ListeGetir();
        List<Product> KategoriyeGöreGetir(int pategoryId);
        List<Product> AdGoreGetir(string productName);
        void Ekle(Product product);
        void Guncelle(Product product);
        void Sil(Product product);
    }
}
