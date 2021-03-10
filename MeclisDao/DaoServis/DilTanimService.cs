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
    public class DilTanimService : IDilTanimService
    {
        IDilTanimDal _dilTanimDal;
        public void Ekle(DilTanim dilTanim)
        {
            _dilTanimDal.Add(dilTanim);
        }

        public DilTanim Getir(int id)
        {
            return _dilTanimDal.Get(p=>p.Id==id);
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
