using MeclisDao.IDaoServis;
using MeclisEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeclisDal.IDal;

namespace MeclisDao.DaoServis
{
    public class VekilTanimService  : IVekilTanimService
    {
        IVekilTanimDal _vekilTanim;

        public VekilTanimService(IVekilTanimDal vekilTanim)
        {
            _vekilTanim = vekilTanim;
        }

        public List<VekilTanim> AdGoreGetir(string vekilAdi)
        {
            return _vekilTanim.GetAll(p => p.Ad == vekilAdi);
        }

        public void Ekle(VekilTanim vekilTanim)
        {
            _vekilTanim.Add(vekilTanim);
        }

        public void Guncelle(VekilTanim vekilTanim)
        {
            _vekilTanim.Update(vekilTanim);
        }

        public List<VekilTanim> ListeGetir()
        {
          return _vekilTanim.GetAll();
        }

        public void Sil(VekilTanim vekilTanim)
        {
            _vekilTanim.Delete(vekilTanim);
        }

        public List<VekilTanim> TcNoyeGöreGetir(int tcNo)
        {
            return _vekilTanim.GetAll(p => p.TcKimlikNo == tcNo);
        }

        VekilTanim IVekilTanimService.Getir(int id)
        {
            return _vekilTanim.Get(p => p.Id == id);
        }

      
    }
}
