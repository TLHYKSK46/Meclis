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
    public class PartiGrupTanimService : IPartiGrupTanimService
    {
        IPartiGrupTanimDal _partiGrupTanimDal;
        MeclisContext _meclisContext;
        public PartiGrupTanimService(IPartiGrupTanimDal partiGrupTanimDal, MeclisContext meclisContext)
        {
            _partiGrupTanimDal = partiGrupTanimDal;
            _meclisContext = meclisContext;
        }

        public void Ekle(PartiGrupTanim partiTanim)
        {
            try
            {
                var aData = _meclisContext.PartiGrupTanims.FirstOrDefault(p => p.PartiGrupAdi == partiTanim.PartiGrupAdi && p.Silindi == 0);
                if (aData != null)
                    throw new DaoException("Zaten '" + partiTanim.PartiGrupAdi + "' Adın da  Tanımlama Yapılmıştır! ,Lütfen Kontrol Ederek Tekrar Deneyiniz..");

                _partiGrupTanimDal.Add(partiTanim);
            }
            catch (DaoException ex)
            {

                throw new DaoException(ex.Message.ToString());
            }

        }

        public PartiGrupTanim Getir(int id)
        {
            return _partiGrupTanimDal.Get(p => p.Id == id);
        }

        
        public void Guncelle(PartiGrupTanim partiTanim)
        {
            _partiGrupTanimDal.Update(partiTanim);
        }

        public List<PartiGrupTanim> ListeGetir()
        {
            return _partiGrupTanimDal.GetAll();
        }

        public void Sil(int id)
        {
            _partiGrupTanimDal.Delete(new PartiGrupTanim { Id = id });
        }
    }
}
