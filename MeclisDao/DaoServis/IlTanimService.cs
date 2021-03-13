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
    public class IlTanimService : IIlTanimService
    {
        IIlTanimDal _ilTanimDal;

        public IlTanimService(IIlTanimDal ilTanimDal)
        {
            _ilTanimDal = ilTanimDal;
        }

        public void Ekle(IlTanim ilTanim)
        {
            _ilTanimDal.Add(ilTanim);
        }

        public IlTanim Getir(int id)
        {
            return _ilTanimDal.Get(p=>p.Id==id);
        }

        public void Guncelle(IlTanim ilTanim)
        {
            _ilTanimDal.Update(ilTanim);
        }

        public List<IlTanim> ListeGetir()
        {
            return _ilTanimDal.GetAll();
        }

        public void Sil(int id)
        {
            _ilTanimDal.Delete(new IlTanim { Id=id});
        }
    }
}
