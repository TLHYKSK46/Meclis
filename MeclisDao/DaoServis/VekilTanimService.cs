using MeclisDao.IDaoServis;
using MeclisEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeclisDal.IDal;
using MeclisDal.BaseDb;
using MeclisDao.Exceptions;
using MeclisDao.MessageDialogs;

namespace MeclisDao.DaoServis
{
    public class VekilTanimService  : IVekilTanimService
    {
        IVekilTanimDal _vekilTanim;
        MeclisContext _meclisContext;

        public VekilTanimService(IVekilTanimDal vekilTanim, MeclisContext meclisContext)
        {
            _vekilTanim = vekilTanim;
            _meclisContext = meclisContext;
        }

        public VekilTanim AdveSoyadGoreGetir(string vekilAdi, string soyad)
        {
            return _vekilTanim.Get(p=>p.Ad==vekilAdi && p.Soyad==soyad);
        }
        public List<VekilTanim> AdGoreGetir(string vekilAdi)
        {
            return _vekilTanim.GetAll(p => p.Ad == vekilAdi.ToLower() || p.Soyad==vekilAdi.ToLower());
        }

        public void Ekle(VekilTanim vekilTanim)
        {
            //  var data = vekilTanim.Equals(null);
            try
            {
                var data = _meclisContext.VekilTanims.FirstOrDefault(p => p.TcKimlikNo == vekilTanim.TcKimlikNo);
                if (data != null)
                    throw new DaoException("Zaten Bu Kişi Sistemde Kayıtlıdır!.Lütfen Kontrol Ederek Tekrar Deneyiniz.");
                _vekilTanim.Add(vekilTanim);
            }
            catch (DaoException ex)
            {

                throw new DaoException(ex.Message.ToString());
            }
           
       
        }

        public void Guncelle(VekilTanim vekilTanim)
        {
            try
            {
               
                var data = _meclisContext.VekilTanims.FirstOrDefault(p => p.Id == vekilTanim.Id);
                if (data == null && !(vekilTanim.Id<=0))
                    throw new DaoException("Bu Kayıt Silinmiş Yada Değiştirilmiş Olabilir.Lütfen Kontrol Ederek Tekrar Deneyiniz!");

                vekilTanim.EklenmeTarihi = data.EklenmeTarihi;
                vekilTanim.Id = data.Id;
                _vekilTanim.Update(vekilTanim);
            }
            catch (DaoException ex)
            {
                throw new DaoException(ex.Message);
            }
        }

        public List<VekilTanim> ListeGetir()
        {
          return _vekilTanim.GetAll(p=>p.Silindi==0).ToList();
        }

        public void Sil(int id)
        {
            var data = _meclisContext.VekilTanims.FirstOrDefault(p => p.Id == id);
            if (data != null && data.Silindi != 1)
            {
                data.Silindi = 1;
                _vekilTanim.Delete(data);
            }
            else
            {
                throw new DaoException("Bu Kayıt Silinmiş Yada Değiştirilmiş Olabilir.Lütfen Kontrol Ederek Tekrar Deneyiniz!");
            }
           // _vekilTanim.Delete(new VekilTanim { Id = id });
        }

        public List<VekilTanim> TcNoyeGoreGetir(int tcNo)
        {
            return _vekilTanim.GetAll();
        }

       public VekilTanim Getir(int id)
        {
            return _vekilTanim.Get(p => p.Id == id);
        }

        public List<VekilTanim> FiltreleGetir(string tur, string value)
        {
            var data = new List<VekilTanim>();
            switch (tur)
            {
                case "Tümü":
                    data = _vekilTanim.GetAll(p => p.Silindi == 0);
                    break;
                case "Ad Soyad":
                    data = _vekilTanim.GetAll(p => p.Ad.ToLower().Contains(value.ToLower()) || p.Soyad.ToLower().Contains(value.ToLower()) && p.Silindi == 0);
                    break;
                case "TC Kimlik No":
                    data = _vekilTanim.GetAll(p => p.TcKimlikNo == value && p.Silindi == 0);
                    break;
            }
            return data;
        }

     

        
    }
}
