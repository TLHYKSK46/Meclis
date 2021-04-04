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
            }
            catch (DaoException ex)
            {

                throw new DaoException(ex.Message); ;
            }
            _danismanTanimDal.Add(danismanTanim);
        }

        public DanismanTanim Getir(int id)
        {
            return _danismanTanimDal.Get(p=>p.Id==id);
        }

        public void Guncelle(DanismanTanim danismanTanim)
        {
            _danismanTanimDal.Update(danismanTanim);
        }

        public List<DanismanTanim> ListeGetir()
        {
            return _danismanTanimDal.GetAll(p=>p.Silindi==0);
        }

        public void Sil(int id)
        {
            _danismanTanimDal.Delete(new DanismanTanim {Id=id });
        }
    }
}
