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
    public class DostlukGrupTanimService : IDostlukGrupTanimService
    {
        IDostlukGrupTanimDal _DostlukGrupTanim;
        MeclisContext _context;

        public DostlukGrupTanimService(IDostlukGrupTanimDal dostlukGrupTanim, MeclisContext context)
        {
            _DostlukGrupTanim = dostlukGrupTanim;
            _context = context;
        }

        public void Ekle(DostlukGrupTanim doslukGrupTanim)
        {
            var aData = _context.DostlukGrupTanims.SingleOrDefault(p =>p.DostlukGrupAdi==doslukGrupTanim.DostlukGrupAdi);
            if (aData != null)
                throw new DaoException(doslukGrupTanim.DostlukGrupAdi + "Dönemi Sistemde Kayıtlıdır,Lütfen Kontrol Ederek Tekrar Deneyiniz..");

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
            return _DostlukGrupTanim.GetAll(p=>p.Silindi==0);
        }

        public void Sil(int id)
        {
            _DostlukGrupTanim.Delete(new DostlukGrupTanim {Id=id });
        }
    }
}
