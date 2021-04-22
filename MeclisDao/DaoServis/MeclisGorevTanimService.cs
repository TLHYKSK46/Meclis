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
    public class MeclisGorevTanimService : IMeclisGorevTanimService
    {
        IMeclisGorevTanimDal _meclisGorevTanimDal;
        MeclisContext _meclisContext;
        public MeclisGorevTanimService(IMeclisGorevTanimDal meclisGorevTanimDal, MeclisContext meclisContext)
        {
            _meclisGorevTanimDal = meclisGorevTanimDal;
            _meclisContext = meclisContext;
        }

        public List<MeclisGorevTanim> AdGoreGetir(string data)
        {
            return _meclisGorevTanimDal.GetAll(p=>p.MeclisGorevAdi.ToLower().Contains(data.ToLower()) && p.Silindi==0);

        }

        public void Ekle(MeclisGorevTanim meclisGorevTanim)
        {
            try
            {
                var aData = _meclisContext.MeclisGorevTanims.FirstOrDefault(p => p.MeclisGorevAdi==meclisGorevTanim.MeclisGorevAdi && p.Silindi == 0);
                if (aData != null)
                    throw new DaoException("Zaten " + meclisGorevTanim.MeclisGorevAdi+ " Adın da  Tanımlama Yapılmıştır! ,Lütfen Kontrol Ederek Tekrar Deneyiniz..");

                _meclisGorevTanimDal.Add(meclisGorevTanim);
            }
            catch (DaoException ex)
            {

                throw new DaoException(ex.Message.ToString());
            }
  
        }

        public MeclisGorevTanim Getir(int id)
        {
         return   _meclisGorevTanimDal.Get(p=>p.Id==id);
        }

        public void Guncelle(MeclisGorevTanim meclisGorevTanim)
        {
            try
            {
                var data = _meclisContext.GrupPersonelTanims.FirstOrDefault(p => p.Id == meclisGorevTanim.Id);
                if (data == null)
                    throw new DaoException("Bu Kayıt Silinmiş Yada Değiştirilmiş Olabilir.Lütfen Kontrol Ederek Tekrar Deneyiniz!");

                meclisGorevTanim.EklenmeTarihi = data.EklenmeTarihi;
                meclisGorevTanim.Id = data.Id;
                _meclisGorevTanimDal.Update(meclisGorevTanim);

            }
            catch (DaoException ex)
            {

                throw new DaoException(ex.Message);
            }
        }

        public List<MeclisGorevTanim> ListeGetir()
        {
            return _meclisGorevTanimDal.GetAll(p=>p.Silindi==0);
        }

        public void Sil(int id)
        {
            var data = _meclisContext.MeclisGorevTanims.SingleOrDefault(p => p.Id == id);
            if (data != null && data.Silindi != 1)
            {
                data.Silindi = 1;
                _meclisGorevTanimDal.Delete(data);


            }
            else
            {
                throw new DaoException("Bu Kayıt Silinmiş Yada Değiştirilmiş Olabilir.Lütfen Kontrol Ederek Tekrar Deneyiniz!");
            }
           // _meclisGorevTanimDal.Delete(new MeclisGorevTanim {Id=id });
        }
    }
}
