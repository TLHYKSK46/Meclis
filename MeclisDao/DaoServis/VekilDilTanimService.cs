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
    public class VekilDilTanimService : IVekilDilTanimService
    {
        IVekilDilTanimDal _dilTanimDal;
        MeclisContext _context;
        IVekilTanimDal _vekilTanimDal;
        public VekilDilTanimService(IVekilDilTanimDal dilTanimDal, MeclisContext context, IVekilTanimDal vekilTanimDal)
        {
            _dilTanimDal = dilTanimDal;
            _context = context;
            _vekilTanimDal = vekilTanimDal;
        }

        public void Ekle(VekilDilTanim lData)
        {
            try
            {
                var aData = _context.VekilDilTanims.FirstOrDefault(p => lData.VekilTanimId == p.VekilTanimId && p.DilTanimId == lData.DilTanimId && p.Silindi == 0);
                if (aData != null)
                    throw new DaoException("Dil Sistemde Seçili Vekil İçin Zaten Kayıtlıdır,Lütfen Kontrol Ederek Tekrar Deneyiniz..");

                _dilTanimDal.Add(lData);

            }
            catch (DaoException ex)
            {

                throw new DaoException(ex.Message);
            }
         
        }

        public VekilDilTanim Getir(int id)
        {
            var data= _dilTanimDal.Get(p => p.Id == id && p.Silindi == 0);
            if (data == null)
                throw new DaoException("Bu Kayıt Silinmiş Yada Değiştirilmiş Olabilir.Lütfen Kontrol Ederek Tekrar Deneyiniz!");
            return data;
        }

        public void Guncelle(VekilDilTanim lData)
        {
            try
            {
                var data = _context.VekilDilTanims.FirstOrDefault(p => p.Id == lData.Id);
                if (data == null)
                    throw new DaoException("Bu Kayıt Silinmiş Yada Değiştirilmiş Olabilir.Lütfen Kontrol Ederek Tekrar Deneyiniz!");

                
                lData.EklenmeTarihi = data.EklenmeTarihi;
                lData.Id = data.Id;

                _dilTanimDal.Update(lData);
            }
            catch (DaoException ex)
            {

                throw new DaoException(ex.Message);
            }
      
        }

        public List<VekilDilTanim> ListeGetir()
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

            return _dilTanimDal.GetAll(p=>p.Silindi==0);
        }

        public void Sil(int id)
        {
            var data =  _context.VekilDilTanims.FirstOrDefault(p => p.Id == id);
            if (data != null)
            {
                data.Silindi = 1;
                data.SilinmeTarihi = DateTime.Now;
                Guncelle(data);

            }
            else { 
                throw new DaoException("Bu Kayıt Silinmiş Yada Değiştirilmiş Olabilir.Lütfen Kontrol Ederek Tekrar Deneyiniz!");
            }


            //_dilTanimDal.Delete(new DilTanim {Id=id });
        }
    }
}
