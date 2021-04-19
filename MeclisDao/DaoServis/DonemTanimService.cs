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
    public class DonemTanimService : IDonemTanimService
    {
        IDonemTanimDal _donemTanimDal;
        MeclisContext _context;

        public DonemTanimService(IDonemTanimDal donemTanimDal, MeclisContext context)
        {
            _donemTanimDal = donemTanimDal;
            _context = context;
        }

        public void Ekle(DonemTanim donemTanim)
        {
            var aData = _context.DonemTanims.SingleOrDefault(p => p.Id == donemTanim.Id);
            if(aData!=null)
                throw new DaoException(donemTanim.DonemAdi + "Dönemi Sistemde Kayıtlıdır,Lütfen Kontrol Ederek Tekrar Deneyiniz..");

            _donemTanimDal.Add(donemTanim);
        }

        public DonemTanim Getir(int id)
        {
            return _donemTanimDal.Get(p=>p.Id==id);
        }

        public void Guncelle(DonemTanim donemTanim)
        {
            try
            {
                var data = _context.VekilDilTanims.FirstOrDefault(p => p.Id == donemTanim.Id);
                if (data == null)
                    throw new DaoException("Bu Kayıt Silinmiş Yada Değiştirilmiş Olabilir.Lütfen Kontrol Ederek Tekrar Deneyiniz!");


                donemTanim.EklenmeTarihi = data.EklenmeTarihi;
                donemTanim.Id = data.Id;

                _donemTanimDal.Update(donemTanim);
            }
            catch (DaoException ex)
            {

                throw new DaoException(ex.Message);
            }
           
        }

        public List<DonemTanim> ListeGetir()
        {
            return _donemTanimDal.GetAll(p=>p.Silindi==0);
        }

        public void Sil(int id)
        {
            var data = _context.DonemTanims.SingleOrDefault(p => p.Id == id);
            if (data != null && data.Silindi != 1)
            {
                data.Silindi = 1;
                _donemTanimDal.Delete(data);


            }
            else
            {
                throw new DaoException("Bu Kayıt Silinmiş Yada Değiştirilmiş Olabilir.Lütfen Kontrol Ederek Tekrar Deneyiniz!");
            }
           // _donemTanimDal.Delete(new DonemTanim { Id=id});
        }
    }
}
