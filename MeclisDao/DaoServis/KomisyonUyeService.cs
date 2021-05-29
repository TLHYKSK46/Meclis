using MeclisDal.BaseDb;
using MeclisDal.IDal;
using MeclisDao.Exceptions;
using MeclisDao.IDaoServis;
using MeclisEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MeclisDao.DaoServis
{
    public class KomisyonUyeService : IKomisyonUyeService
    {
        IKomisyonUyeDal _komisyonUye;
        MeclisContext _meclisContext;

        public KomisyonUyeService(IKomisyonUyeDal komisyonUye, MeclisContext meclisContext)
        {
            _komisyonUye = komisyonUye;
            _meclisContext = meclisContext;
        }

        public List<KomisyonUye> AdGoreGetir(string data)
        {
            throw new NotImplementedException();
        }

        public void Ekle(KomisyonUye data)
        {
            try
            {
                var aData = _meclisContext.KomisyonUyes.FirstOrDefault(p => p.VekilTanimId == data.VekilTanimId && p.KomisyonTanimId == data.KomisyonTanimId &&p.KomisyonUyeTuru==data.KomisyonUyeTuru && p.Silindi == 0);
                if (aData != null)
                    throw new DaoException("Zaten bu vekile tanımlı komisyon Sistemde Kayıtlıdır,Lütfen Kontrol Ederek Tekrar Deneyiniz..");
                _komisyonUye.Add(data);
            }
            catch (DaoException ex)
            {
                throw new DaoException(ex.Message.ToString());
            }
        }

        public KomisyonUye Getir(int id)
        {
            return _komisyonUye.Get(p=>p.Id==id);
        }

        public void Guncelle(KomisyonUye data)
        {
            try
            {
                var ldata = _meclisContext.KomisyonTanims.FirstOrDefault(p => p.Id == data.Id);
                if (ldata == null)
                    throw new DaoException("Bu Kayıt Silinmiş Yada Değiştirilmiş Olabilir.Lütfen Kontrol Ederek Tekrar Deneyiniz!");

                data.EklenmeTarihi = data.EklenmeTarihi;
                data.Id = data.Id;
                _komisyonUye.Update(data);
            }
            catch (DaoException ex)
            {

                throw new DaoException(ex.Message);
            }
        }

        public List<KomisyonUye> ListeGetir()
        {
            return _komisyonUye.GetAll(p => p.Silindi == 0);
        }
        public void Sil(int id)
        {
            var data = _meclisContext.KomisyonUyes.FirstOrDefault(p => p.Id == id);
            if (data != null && data.Silindi != 1)
            {
                data.Silindi = 1;
                _komisyonUye.Delete(data);
            }
            else
            {
                throw new DaoException("Bu Kayıt Silinmiş Yada Değiştirilmiş Olabilir.Lütfen Kontrol Ederek Tekrar Deneyiniz!");
            }
           // _komisyonTanim.Delete(new KomisyonTanim { Id=id});
        }
    }
}
