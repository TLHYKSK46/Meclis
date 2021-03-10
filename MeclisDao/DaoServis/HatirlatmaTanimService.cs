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
   public class HatirlatmaTanimService:IHatirlatmaTanimService
    {
        IHatirlatmaTanimDal _hatirlatmaTanim;

        public HatirlatmaTanimService(IHatirlatmaTanimDal hatirlatmaTanim)
        {
            _hatirlatmaTanim = hatirlatmaTanim;
        }

        public void Ekle(HatirlatmaTanim hatirlatmaTanim)
        {
            _hatirlatmaTanim.Add(hatirlatmaTanim);
        }

        public HatirlatmaTanim Getir(int id)
        {
            return _hatirlatmaTanim.Get(p=>p.Id==id);
        }

        public void Guncelle(HatirlatmaTanim hatirlatmaTanim)
        {
            _hatirlatmaTanim.Update(hatirlatmaTanim);
        }

        public List<HatirlatmaTanim> ListeGetir()
        {
            return _hatirlatmaTanim.GetAll();
        }

        public void Sil(int id)
        {
            _hatirlatmaTanim.Delete(new HatirlatmaTanim {Id=id});
        }
    }
}
