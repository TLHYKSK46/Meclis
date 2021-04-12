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
    public class DilTanimService : IDilTanimService
    {
        IDilTanimDal _dilTanimDal;
        MeclisContext _context;
        IVekilTanimDal _vekilTanimDal;
        IVekilDetayDal _vekilDetayDal;
        public DilTanimService(IDilTanimDal dilTanimDal, MeclisContext context, IVekilTanimDal vekilTanimDal, IVekilDetayDal vekilDetayDal)
        {
            _dilTanimDal = dilTanimDal;
            _context = context;
            _vekilTanimDal = vekilTanimDal;
            _vekilDetayDal = vekilDetayDal;
        }

        public List<DilTanim> AdGoreGetir(string data)
        {
            return _dilTanimDal.GetAll(p=>p.DilAdi.ToLower().Contains(data.ToLower())&& p.Silindi==0);
        }

        public void Ekle(DilTanim dilTanim)
        {
            var aData = _context.DilTanims.FirstOrDefault(p=>p.Id==dilTanim.Id);
            if(aData!=null)
              throw new DaoException(dilTanim.DilAdi+"Dil Sistemde Kayıtlıdır,Lütfen Kontrol Ederek Tekrar Deneyiniz..");

            _dilTanimDal.Add(dilTanim);
        }

        public DilTanim Getir(int id)
        {
            var data= _dilTanimDal.Get(p => p.Id == id && p.Silindi == 0);
            if (data == null)
                throw new DaoException("Bu Kayıt Silinmiş Yada Değiştirilmiş Olabilir.Lütfen Kontrol Ederek Tekrar Deneyiniz!");
            return data;
        }

        public void Guncelle(DilTanim dilTanim)
        {
            var data  = _context.DilTanims.SingleOrDefault(p => p.Id == dilTanim.Id);
            if (data!=null)
            _dilTanimDal.Update(dilTanim);

            if (data == null)
                throw new DaoException("Bu Kayıt Silinmiş Yada Değiştirilmiş Olabilir.Lütfen Kontrol Ederek Tekrar Deneyiniz!");

        }

        public List<DilTanim> ListeGetir()
        {
            //var vekildetay = _vekilDetayDal.GetAll();
            //(from dt in _dilTanimDal.GetAll()
            // join vd in vekildetay on dt.Id equals vd.DilTanimId
            // join vt in _vekilTanimDal.GetAll() on vd.DilTanimId equals vt.Id
            // select new 
            // {
            //     vt.TcKimlikNo,
            //    AdSoyad=vt.Ad+""+vt.Soyad,
            //    dt.DilAdi,
            // }

            // ).ToList();

            return _dilTanimDal.GetAll();
        }

        public void Sil(int id)
        {
            var data =  _context.DilTanims.SingleOrDefault(p => p.Id == id);
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
    }
}
