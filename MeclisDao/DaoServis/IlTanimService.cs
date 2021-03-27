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
    public class IlTanimService : IIlTanimService
    {
        IIlTanimDal _ilTanimDal;
        MeclisContext _context;

        public IlTanimService(IIlTanimDal ilTanimDal, MeclisContext context)
        {
            _ilTanimDal = ilTanimDal;
            _context = context;
        }

        public void Ekle(IlTanim ilTanim)
        {
            var kontrol = ilTanim.IlAdi != null && ilTanim.IlBolgesi != null && ilTanim.IlKodu != null;
            if (kontrol)
            {
                var data = _context.IlTanims.SingleOrDefault(p =>p.IlKodu==ilTanim.IlKodu && p.Silindi==0);
                if (data != null)
                    throw new DaoException(ilTanim.IlAdi + "Bu İl Sistemde Zaten Kayıtlı!Lütfen Kontrol Ederek Tekrar Deneyiniz..");

                ilTanim.EklenmeTarihi = DateTime.Now;
                _ilTanimDal.Add(ilTanim);
            }
            else { 
                    throw new DaoException(ilTanim.IlAdi + "Lütfen Zorunlu Alanları Doldurunuz!");
            }




        }

        public IlTanim Getir(int id)
        {
            var data = _ilTanimDal.Get(p => p.Id == id && p.Silindi == 0);
            if (data == null)
                throw new DaoException("Bu Kayıt Silinmiş Yada Değiştirilmiş Olabilir.Lütfen Kontrol Ederek Tekrar Deneyiniz!");
            return data;
           
        }

        public void Guncelle(IlTanim ilTanim)
        {
            var data = _context.IlTanims.SingleOrDefault(p => p.Id == ilTanim.Id && p.Silindi==0);
            if (data != null)
                _ilTanimDal.Update(ilTanim);

            if (data == null)
                throw new DaoException("Bu Kayıt Silinmiş Yada Değiştirilmiş Olabilir.Lütfen Kontrol Ederek Tekrar Deneyiniz!");

       
        }

        public List<IlTanim> ListeGetir()
        {
            return _ilTanimDal.GetAll();
        }

        public void Sil(int id)
        {
            var data = _context.IlTanims.SingleOrDefault(p => p.Id == id);
            if (data != null && data.Silindi != 1)
            {
                data.Silindi = 1;
                Guncelle(data);

            }
            else
            {
                throw new DaoException("Bu Kayıt Silinmiş Yada Değiştirilmiş Olabilir.Lütfen Kontrol Ederek Tekrar Deneyiniz!");
            }

            //_ilTanimDal.Delete(new IlTanim { Id=id});
        }
    }
}
