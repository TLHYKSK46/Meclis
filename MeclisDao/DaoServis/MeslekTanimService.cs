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
            _meslekTanim.Update(Data);
        }

        public List<MeslekTanim> ListeGetir()
        {
            return _meslekTanim.GetAll();
        }

        public void Sil(int id)
        {
            _meslekTanim.Delete(new MeslekTanim {Id=id});
        }
    }
}
