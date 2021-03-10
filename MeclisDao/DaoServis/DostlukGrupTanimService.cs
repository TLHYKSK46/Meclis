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

        public void Ekle(DoslukGrupTanim doslukGrupTanim)
        {
            _DostlukGrupTanim.Add(doslukGrupTanim);
        }

        public DoslukGrupTanim Getir(int id)
        {
            return _DostlukGrupTanim.Get(p=>p.Id==id);
        }

        public void Guncelle(DoslukGrupTanim doslukGrupTanim)
        {
            _DostlukGrupTanim.Update(doslukGrupTanim);
        }

        public List<DoslukGrupTanim> ListeGetir()
        {
            return _DostlukGrupTanim.GetAll();
        }

        public void Sil(int id)
        {
            _DostlukGrupTanim.Delete(new DoslukGrupTanim {Id=id });
        }
    }
}
