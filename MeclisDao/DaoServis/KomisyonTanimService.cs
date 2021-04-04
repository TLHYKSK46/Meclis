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
                var aData = _meclisContext.KomisyonTanims.SingleOrDefault(p => p.IhtisasAdi == komisyonTanim.IhtisasAdi && p.UluslararasiAdi == komisyonTanim.UluslararasiAdi && p.Silindi==0);
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
            _komisyonTanim.Update(komisyonTanim);
        }

        public List<KomisyonTanim> ListeGetir()
        {
            return _komisyonTanim.GetAll(p => p.Silindi == 0);
        }

        public void Sil(int id)
        {
            _komisyonTanim.Delete(new KomisyonTanim { Id=id});
        }
    }
}
