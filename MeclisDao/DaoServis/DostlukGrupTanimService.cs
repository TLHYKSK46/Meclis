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
    public class DostlukGrupTanimService : IDostlukGrupTanimService
    {
        IDostlukGrupTanimDal _DostlukGrupTanim;

        public DostlukGrupTanimService(IDostlukGrupTanimDal dostlukGrupTanim)
        {
            _DostlukGrupTanim = dostlukGrupTanim;
        }

        public void Ekle(DostlukGrupTanim doslukGrupTanim)
        {
            _DostlukGrupTanim.Add(doslukGrupTanim);
        }

        public DostlukGrupTanim Getir(int id)
        {
            return _DostlukGrupTanim.Get(p=>p.Id==id);
        }

        public void Guncelle(DostlukGrupTanim doslukGrupTanim)
        {
            _DostlukGrupTanim.Update(doslukGrupTanim);
        }

        public List<DostlukGrupTanim> ListeGetir()
        {
            return _DostlukGrupTanim.GetAll();
        }

        public void Sil(int id)
        {
            _DostlukGrupTanim.Delete(new DostlukGrupTanim {Id=id });
        }
    }
}
