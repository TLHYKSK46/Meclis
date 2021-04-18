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
    public class DanismanTanimService : IDanismanTanimService
    {
        IDanismanTanimDal _danismanTanimDal;
        MeclisContext _meclisContext;

        public DanismanTanimService(IDanismanTanimDal danismanTanimDal, MeclisContext meclisContext)
        {
            _danismanTanimDal = danismanTanimDal;
            _meclisContext = meclisContext;
        }

        public List<DanismanTanim> AdGoreGetir(string DanismanAdi)
        {
            //return _danismanTanimDal.GetAll(p => p.Ad == DanismanAdi);
            return _danismanTanimDal.GetAll(p => p.Ad.ToLower().Contains(DanismanAdi.ToLower()) || p.Soyad.ToLower().Contains(DanismanAdi.ToLower()) && p.Silindi == 0);
        }

        public void Ekle(DanismanTanim danismanTanim)
        {
            try
            {
                var data = _meclisContext.DanismanTanims.FirstOrDefault(p=>p.TcKimlikNo==danismanTanim.TcKimlikNo && p.Silindi==0);
                if (data != null)
                    throw new DaoException("Danışman Zaten Sistem de Kayıtlı!,Lütfen Kontrol Ederek Tekarar Deneyiniz.");

                _danismanTanimDal.Add(danismanTanim);

            }
            catch (DaoException ex)
            {

                throw new DaoException(ex.Message); ;
            }
        }

        public DanismanTanim Getir(int id)
        {
            return _danismanTanimDal.Get(p=>p.Id==id);
        }

        public void Guncelle(DanismanTanim danismanTanim)
        {
            try
            {
                var data = _meclisContext.DanismanTanims.FirstOrDefault(p => p.Id == danismanTanim.Id && p.Silindi == 0);
                if (data == null)
                    throw new DaoException("Danışman Sistem de Bulunamadı Değiştirilmiş Yada Silinmiş Olabilir!,Lütfen Kontrol Ederek Tekarar Deneyiniz.");
                
                danismanTanim.EklenmeTarihi = data.EklenmeTarihi;
                danismanTanim.Id = data.Id;
                _danismanTanimDal.Update(danismanTanim);

            }
            catch (DaoException ex)
            {
                throw new DaoException(ex.Message); 
            }
        }

        public List<DanismanTanim> ListeGetir()
        {
            return _danismanTanimDal.GetAll(p=>p.Silindi==0);
        }

        public void Sil(int id)
        {
            var data = _meclisContext.DanismanTanims.SingleOrDefault(p => p.Id == id);
            if (data != null && data.Silindi != 1)
            {
                data.Silindi = 1;
                _danismanTanimDal.Delete(data);


            }
            else
            {
                throw new DaoException("Bu Kayıt Silinmiş Yada Değiştirilmiş Olabilir.Lütfen Kontrol Ederek Tekrar Deneyiniz!");
            }
           // _danismanTanimDal.Delete(new DanismanTanim {Id=id });
        }
    }
}
