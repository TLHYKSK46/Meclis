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
    public class GrupPersonelTanimService : IGrupPersonelTanimService
    {
        IGrupPesonelTanimDal _GrupPersonel;
        MeclisContext _meclisContext;

        public GrupPersonelTanimService(IGrupPesonelTanimDal grupPersonel, MeclisContext meclisContext)
        {
            _GrupPersonel = grupPersonel;
            _meclisContext = meclisContext;
        }

        public List<GrupPersonelTanim> AdGoreGetir(string data)
        {
            return _GrupPersonel.GetAll(p=>p.Ad.ToLower().Contains(data.ToLower())||p.Soyad.ToLower().Contains(data.ToLower())&&p.Silindi==0);
        }

        public void Ekle(GrupPersonelTanim grupPersonelTanim)
        {
            try
            {
                var data = _meclisContext.GrupPersonelTanims.FirstOrDefault(p => p.Id == grupPersonelTanim.Id &&
                        p.TcKimlikNo == grupPersonelTanim.TcKimlikNo);
                if (data != null)
                    throw new DaoException("Zaten Bu Kişi Sistemde Kayıtlıdır!.Lütfen Kontrol Ederek Tekrar Deneyiniz.");
                _GrupPersonel.Add(grupPersonelTanim);
            }
            catch (DaoException ex)
            {

                throw new DaoException(ex.Message.ToString());
            }
        
        }

        public GrupPersonelTanim Getir(int id)
        {
            return _GrupPersonel.Get(p=>p.Id==id);
        }

        public void Guncelle(GrupPersonelTanim grupPersonelTanim)
        {
            try
            {
                var data = _meclisContext.GrupPersonelTanims.FirstOrDefault(p => p.Id == grupPersonelTanim.Id);
                if (data == null)
                    throw new DaoException("Bu Kayıt Silinmiş Yada Değiştirilmiş Olabilir.Lütfen Kontrol Ederek Tekrar Deneyiniz!");

                grupPersonelTanim.EklenmeTarihi = data.EklenmeTarihi;
                grupPersonelTanim.Id = data.Id;
                _GrupPersonel.Update(grupPersonelTanim);
            }
            catch (DaoException ex)
            {

                throw new DaoException(ex.Message);
            }
          
        }

        public List<GrupPersonelTanim> ListeGetir()
        {
            return _GrupPersonel.GetAll(p=>p.Silindi==0);
        }

        public void Sil(int id)
        {
            var data = _meclisContext.GrupPersonelTanims.SingleOrDefault(p => p.Id == id);
            if (data != null && data.Silindi != 1)
            {
                data.Silindi = 1;
                _GrupPersonel.Delete(data);


            }
            else
            {
                throw new DaoException("Bu Kayıt Silinmiş Yada Değiştirilmiş Olabilir.Lütfen Kontrol Ederek Tekrar Deneyiniz!");
            }
           // _GrupPersonel.Delete(new GrupPersonelTanim {Id=id });
        }
    }
}
