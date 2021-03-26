using MeclisDal.IDal;
using MeclisDao.IDaoServis;
using MeclisEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeclisDao.DaoServis
{
    public class CinsiyetTanimService : ICinsiyetTanimService
    {
        ICinsiyetTanimDal _cinsiyetTanimDal;

        public CinsiyetTanimService(ICinsiyetTanimDal cinsiyetTanimDal)
        {
            _cinsiyetTanimDal = cinsiyetTanimDal;
        }

        public void Ekle(CinsiyetTanim cinsiyetTanim)
        {
            _cinsiyetTanimDal.Add(cinsiyetTanim);
        }

        public CinsiyetTanim Getir(int id)
        {
            return _cinsiyetTanimDal.Get(p=>p.Id==id);
        }

        public void Guncelle(CinsiyetTanim cinsiyetTanim)
        {
            _cinsiyetTanimDal.Add(cinsiyetTanim);

        }

        public List<CinsiyetTanim> ListeGetir()
        {
            return _cinsiyetTanimDal.GetAll();
        }

        public void Sil(int id)
        {
            var kayit=Getir(id);
            if (kayit!=null || kayit.Equals(""))
            {
                _cinsiyetTanimDal.Delete(new CinsiyetTanim { Id = id });

            }

        }
    }
}
