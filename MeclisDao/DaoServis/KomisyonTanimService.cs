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
    public class KomisyonTanimService : IKomisyonTanimService
    {
        IKomisyonTanimDal _komisyonTanim;
        MeclisContext _meclisContext;

        public KomisyonTanimService(IKomisyonTanimDal komisyonTanim, MeclisContext meclisContext)
        {
            _komisyonTanim = komisyonTanim;
            _meclisContext = meclisContext;
        }

        public List<KomisyonTanim> AdGoreGetir(string data)
        {
            return _komisyonTanim.GetAll(p => p.IhtisasAdi.ToLower().Contains(data.ToLower()) || p.UluslararasiAdi.ToLower().Contains(data.ToLower()) && p.Silindi == 0);

        }

        public void Ekle(KomisyonTanim komisyonTanim)
        {
            try
            {
                var aData = _meclisContext.KomisyonTanims.FirstOrDefault(p => p.IhtisasAdi == komisyonTanim.IhtisasAdi && p.UluslararasiAdi == komisyonTanim.UluslararasiAdi && p.Silindi==0);
                if (aData != null)
                    throw new DaoException(komisyonTanim.UluslararasiAdi + " ve " + komisyonTanim.IhtisasAdi + " Sistemde Kayıtlıdır,Lütfen Kontrol Ederek Tekrar Deneyiniz..");

                _komisyonTanim.Add(komisyonTanim);
            }
            catch (DaoException ex)
            {

                throw new DaoException(ex.Message.ToString());
            }
   
        }

        public KomisyonTanim Getir(int id)
        {
            return _komisyonTanim.Get(p=>p.Id==id);
        }

        public void Guncelle(KomisyonTanim komisyonTanim)
        {
            try
            {
                var data = _meclisContext.KomisyonTanims.FirstOrDefault(p => p.Id == komisyonTanim.Id);
                if (data == null)
                    throw new DaoException("Bu Kayıt Silinmiş Yada Değiştirilmiş Olabilir.Lütfen Kontrol Ederek Tekrar Deneyiniz!");

                komisyonTanim.EklenmeTarihi = data.EklenmeTarihi;
                komisyonTanim.Id = data.Id;
                _komisyonTanim.Update(komisyonTanim);
            }
            catch (DaoException ex)
            {

                throw new DaoException(ex.Message);
            }

            
        }

        public List<KomisyonTanim> ListeGetir()
        {
            return _komisyonTanim.GetAll(p => p.Silindi == 0);
        }

        public void Sil(int id)
        {
            var data = _meclisContext.KomisyonTanims.FirstOrDefault(p => p.Id == id);
            if (data != null && data.Silindi != 1)
            {
                data.Silindi = 1;
                _komisyonTanim.Delete(data);


            }
            else
            {
                throw new DaoException("Bu Kayıt Silinmiş Yada Değiştirilmiş Olabilir.Lütfen Kontrol Ederek Tekrar Deneyiniz!");
            }
           // _komisyonTanim.Delete(new KomisyonTanim { Id=id});
        }
    }
}
