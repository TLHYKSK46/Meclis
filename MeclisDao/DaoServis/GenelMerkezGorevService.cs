using MeclisDal.IDal;
using MeclisDao.IDaoServis;
using MeclisEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeclisDao.DaoServis
{
    public class GenelMerkezGorevService : IGenelMerkezGorevService
    {
        IGenelMerkezGorevDal _genelMerkez;

        public GenelMerkezGorevService(IGenelMerkezGorevDal genelMerkez)
        {
            _genelMerkez = genelMerkez;
        }

        public void Ekle(GenelMerkezGorev genelMerkezGorev)
        {
            _genelMerkez.Add(genelMerkezGorev);
        }

        public GenelMerkezGorev Getir(int id)
        {
            return _genelMerkez.Get(p=>p.Id==id);
        }

        public void Guncelle(GenelMerkezGorev genelMerkezGorev)
        {
            _genelMerkez.Update(genelMerkezGorev);
        }

        public List<GenelMerkezGorev> ListeGetir()
        {
            return _genelMerkez.GetAll();
        }

        public void Sil(int id)
        {
            _genelMerkez.Delete(new GenelMerkezGorev { Id=id});
        }
    }
}
