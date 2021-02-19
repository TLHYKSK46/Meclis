using MeclisDao.IDaoServis;
using MeclisEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeclisDal.IDal;

namespace MeclisDao.DaoServis
{
    public class ProductServis : IProductService
    {
        IProductDal _productDal;

        public ProductServis(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> AdGoreGetir(string productName)
        {
            // return _productDal.GetAll(p => p.ProductName.ToLower().Contains(productName.ToLower()));
            return _productDal.GetAll();
        }

        public void Ekle(Product product)
        {
            _productDal.Add(product);
        }

        public void Guncelle(Product product)
        {

            _productDal.Update(product);
        }

        public List<Product> KategoriyeGöreGetir(int pategoryId)
        {
            // return _productDal.GetAll(p => p.CategoryId == categoryId);
            return _productDal.GetAll();
        }

        public List<Product> ListeGetir()
        {
            return _productDal.GetAll();
        }

        public void Sil(Product product)
        {
            _productDal.Delete(product);
        }
    }
}
