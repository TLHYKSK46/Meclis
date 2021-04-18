using MeclisDal.BaseDb;
using MeclisDal.BaseDb.Interfaces;
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
    public class DilVekilTanimService : IDilVekilTanimService
    {
        IDilTanimDal _dilTanimDal;
        IDilVekilTanimDal _dilVekilTanimDal;
        MeclisContext _context;
        IVekilTanimDal _vekilTanimDal;
        IVekilDetayDal _vekilDetayDal;
        public DilVekilTanimService(IDilTanimDal dilTanimDal, MeclisContext context, IVekilTanimDal vekilTanimDal, IVekilDetayDal vekilDetayDal, IDilVekilTanimDal dilVekilTanimDal)
        {
            _dilTanimDal = dilTanimDal;
            _context = context;
            _vekilTanimDal = vekilTanimDal;
            _vekilDetayDal = vekilDetayDal;
            _dilVekilTanimDal = dilVekilTanimDal;
        }

        //public List<DilVekilTanim> AdGoreGetir(string data)
        //{
        //    return _dilVekilTanimDal.GetAll(p=>p.DiltanimId.Contains(data.ToLower())&& p.Silindi==0);
        //}

             public void Ekle(DilVekilTanim data)
        {
            var aData = _context.DilVekilTanims.FirstOrDefault(p => p.Id == data.Id);
            if (aData != null)
                throw new DaoException( "Bu Dil ilgili Vekil için Sistemde Kayıtlıdır,Lütfen Kontrol Ederek Tekrar Deneyiniz..");

            _dilVekilTanimDal.Add(data);
        }

  
        public void Guncelle(DilVekilTanim data)
        {
            var ldata = _context.DilTanims.FirstOrDefault(p => p.Id == data.Id);
            if (ldata != null)
                _dilVekilTanimDal.Update(data);

            if (ldata == null)
                throw new DaoException("Bu Kayıt Silinmiş Yada Değiştirilmiş Olabilir.Lütfen Kontrol Ederek Tekrar Deneyiniz!");

        }


        public void Sil(int id)
        {
            var data =  _context.DilVekilTanims.SingleOrDefault(p => p.Id == id);
            if (data != null && data.Silindi != 1)
            {
                data.Silindi = 1;
                Guncelle(data);

            }
            else { 
                throw new DaoException("Bu Kayıt Silinmiş Yada Değiştirilmiş Olabilir.Lütfen Kontrol Ederek Tekrar Deneyiniz!");
            }


            //_dilTanimDal.Delete(new DilTanim {Id=id });
        }

      public  DilVekilTanim Getir(int id)
        {
            var data = _dilVekilTanimDal.Get(p => p.Id == id && p.Silindi == 0);
            if (data == null)
                throw new DaoException("Bu Kayıt Silinmiş Yada Değiştirilmiş Olabilir.Lütfen Kontrol Ederek Tekrar Deneyiniz!");
            return data;
        }

       public List<DilVekilTanim> ListeGetir()
        {
            return _dilVekilTanimDal.GetAll();
        }
    }
}
