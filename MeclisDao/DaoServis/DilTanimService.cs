using MeclisDal.Dal;
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
    public class DilTanimService : IDilTanimService
    {
        IDilTanimDal _dilTanimDal;
        public void Ekle(DilTanim dilTanim)
        {
            var aData = Getir(dilTanim.Id);
            if(aData!=null)
              throw new DaoException(dilTanim.DilAdi+"Dil Sistemde Kayıtlıdır,Lütfen Kontrol Ederek Tekrar Deneyiniz..");

            aData = new DilTanim
            {
                DilAdi=aData.DilAdi,
                DilSeviye=aData.DilSeviye
            };

            _dilTanimDal.Add(aData);
        }

        public DilTanim Getir(int id)
        {
            return _dilTanimDal.Get(p=>p.Id==id && p.Silindi==0);
        }

        public void Guncelle(DilTanim dilTanim)
        {
            _dilTanimDal.Update(dilTanim);
        }

        public List<DilTanim> ListeGetir()
        {
            return _dilTanimDal.GetAll();
        }

        public void Sil(int id)
        {
            _dilTanimDal.Delete(new DilTanim {Id=id });
        }
    }
}
