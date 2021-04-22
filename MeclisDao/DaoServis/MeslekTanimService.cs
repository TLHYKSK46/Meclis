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
    public class MeslekTanimService : IMeslekTanimService
    {
        IMeslekTanimDal _meslekTanim;
        MeclisContext _meclisContext;
        public MeslekTanimService(IMeslekTanimDal meslekTanim, MeclisContext meclisContext)
        {
            _meslekTanim = meslekTanim;
            _meclisContext = meclisContext;
        }

        public void Ekle(MeslekTanim Data)
        {
            try
            {
                var aData = _meclisContext.MeslekTanims.FirstOrDefault(p => p.MeslekAdi == Data.MeslekAdi && p.Silindi == 0);
                if (aData != null)
                    throw new DaoException("Zaten '" + Data.MeslekAdi + "' Adın da  Tanımlama Yapılmıştır! ,Lütfen Kontrol Ederek Tekrar Deneyiniz..");

                _meslekTanim.Add(Data);
            }
            catch (DaoException ex)
            {

                throw new DaoException(ex.Message.ToString());
            }
         
        }

        public MeslekTanim Getir(int id)
        {
            return _meslekTanim.Get(p=>p.Id==id);
        }

        public void Guncelle(MeslekTanim Data)
        {
            try
            {
                var ldata = _meclisContext.MeslekTanims.FirstOrDefault(p => p.Id == Data.Id);
                if (ldata == null)
                    throw new DaoException("Bu Kayıt Silinmiş Yada Değiştirilmiş Olabilir.Lütfen Kontrol Ederek Tekrar Deneyiniz!");

                Data.EklenmeTarihi = ldata.EklenmeTarihi;
                Data.Id = ldata.Id;
                _meslekTanim.Update(Data);
            }
            catch (DaoException ex)
            {

                throw new DaoException(ex.Message);
            }
        
        }

        public List<MeslekTanim> ListeGetir()
        {
            return _meslekTanim.GetAll(p=>p.Silindi==0);
        }

        public List<MeslekTanim> MeslekAdiGetir(string data)
        {
            return _meslekTanim.GetAll(p => p.MeslekAdi.ToLower().Contains(data.ToLower()) && p.Silindi==0);
        }

        public void Sil(int id)
        {
            var data = _meclisContext.MeslekTanims.FirstOrDefault(p => p.Id == id);
            if (data != null && data.Silindi != 1)
            {
                data.Silindi = 1;
                _meslekTanim.Delete(data);
            }
            else
            {
                throw new DaoException("Bu Kayıt Silinmiş Yada Değiştirilmiş Olabilir.Lütfen Kontrol Ederek Tekrar Deneyiniz!");
            }
           // _meslekTanim.Delete(new MeslekTanim {Id=id});
        }
    }
}
