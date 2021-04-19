using MeclisDal.BaseDb;
using MeclisDal.IDal;
using MeclisDao.Exceptions;
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
        MeclisContext _context;
        public GenelMerkezGorevService(IGenelMerkezGorevDal genelMerkez, MeclisContext context)
        {
            _genelMerkez = genelMerkez;
            _context = context;
        }

        public List<GenelMerkezGorev> AdGoreGetir(string data)
        {
            return _genelMerkez.GetAll(p=>p.GenelMerkezGorevAdi.ToLower().Contains(data.ToLower()) && p.Silindi==0);
        }

        public void Ekle(GenelMerkezGorev genelMerkezGorev)
        {
            try
            {
                var aData = _context.GenelMerkezGorevs.FirstOrDefault(p => p.GenelMerkezGorevAdi == genelMerkezGorev.GenelMerkezGorevAdi && p.Silindi == 0);
                if (aData != null)
                    throw new DaoException(genelMerkezGorev.GenelMerkezGorevAdi + "Bu Görev Sistemde Kayıtlıdır,Lütfen Kontrol Ederek Tekrar Deneyiniz..");
                _genelMerkez.Add(genelMerkezGorev);
            }
            catch (Exception ex)
            {

                throw new DaoException(ex.Message.ToString());
            }
        
        }

        public GenelMerkezGorev Getir(int id)
        {
            return _genelMerkez.Get(p=>p.Id==id);
        }

        public void Guncelle(GenelMerkezGorev genelMerkezGorev)
        {
            try
            {
                var data = _context.VekilDilTanims.FirstOrDefault(p => p.Id == genelMerkezGorev.Id);
                if (data == null)
                    throw new DaoException("Bu Kayıt Silinmiş Yada Değiştirilmiş Olabilir.Lütfen Kontrol Ederek Tekrar Deneyiniz!");


                genelMerkezGorev.EklenmeTarihi = data.EklenmeTarihi;
                genelMerkezGorev.Id = data.Id;

                _genelMerkez.Update(genelMerkezGorev);
            }
            catch (DaoException ex)
            {

                throw new DaoException(ex.Message);
            }
          
        }

        public List<GenelMerkezGorev> ListeGetir()
        {
            return _genelMerkez.GetAll(p=>p.Silindi==0);
        }

        public void Sil(int id)
        {
            var data = _context.GenelMerkezGorevs.SingleOrDefault(p => p.Id == id);
            if (data != null && data.Silindi != 1)
            {
                data.Silindi = 1;
                _genelMerkez.Delete(data);


            }
            else
            {
                throw new DaoException("Bu Kayıt Silinmiş Yada Değiştirilmiş Olabilir.Lütfen Kontrol Ederek Tekrar Deneyiniz!");
            }
           // _genelMerkez.Delete(new GenelMerkezGorev { Id=id});
        }
    }
}
