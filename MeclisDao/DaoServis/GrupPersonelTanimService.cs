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
            _GrupPersonel.Update(grupPersonelTanim);
        }

        public List<GrupPersonelTanim> ListeGetir()
        {
            return _GrupPersonel.GetAll(p=>p.Silindi==0);
        }

        public void Sil(int id)
        {
            _GrupPersonel.Delete(new GrupPersonelTanim {Id=id });
        }
    }
}
