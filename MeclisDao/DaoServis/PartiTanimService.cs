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
    public class PartiTanimService : IPartiTanimService
    {
        IPartiTanimDal _partiTanimDal;
        MeclisContext _meclisContext;
        public PartiTanimService(IPartiTanimDal partiTanimDal, MeclisContext meclisContext)
        {
            _partiTanimDal = partiTanimDal;
            _meclisContext = meclisContext;
        }

        public void Ekle(PartiTanim partiTanim)
        {
            try
            {
                var aData = _meclisContext.PartiTanims.FirstOrDefault(p => p.PartiAdi == partiTanim.PartiAdi && p.Silindi == 0);
                if (aData != null)
                    throw new DaoException("Zaten '" + partiTanim.PartiAdi + "' Adın da  Tanımlama Yapılmıştır! ,Lütfen Kontrol Ederek Tekrar Deneyiniz..");

                _partiTanimDal.Add(partiTanim);
            }
            catch (DaoException ex)
            {

                throw new DaoException(ex.Message.ToString());
            }
           
        }

        public PartiTanim Getir(int id)
        {
            return _partiTanimDal.Get(p => p.Id == id);
        }

        public void Guncelle(PartiTanim partiTanim)
        {
            try
            {
                var data = _meclisContext.PartiTanims.FirstOrDefault(p => p.Id == partiTanim.Id);
                if (data == null)
                    throw new DaoException("Bu Kayıt Silinmiş Yada Değiştirilmiş Olabilir.Lütfen Kontrol Ederek Tekrar Deneyiniz!");

                partiTanim.EklenmeTarihi = data.EklenmeTarihi;
                partiTanim.Id = data.Id;
                _partiTanimDal.Update(partiTanim);

            }
            catch (DaoException ex)
            {

                throw new DaoException(ex.Message);
            }
        }

        public List<PartiTanim> ListeGetir()
        {
            return _partiTanimDal.GetAll(p=>p.Silindi==0);
        }

        public void Sil(int id)
        {
            var data = _meclisContext.PartiTanims.FirstOrDefault(p => p.Id == id);
            if (data != null && data.Silindi != 1)
            {
                data.Silindi = 1;
                _partiTanimDal.Delete(data);
            }
            else
            {
                throw new DaoException("Bu Kayıt Silinmiş Yada Değiştirilmiş Olabilir.Lütfen Kontrol Ederek Tekrar Deneyiniz!");
            }
            //_partiTanimDal.Delete(new PartiTanim { Id = id });
        }
    }
}
