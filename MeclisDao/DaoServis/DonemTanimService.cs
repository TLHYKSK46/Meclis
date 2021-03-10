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
    public class DonemTanimService : IDonemTanimService
    {
        IDonemTanimDal _donemTanimDal;

        public DonemTanimService(IDonemTanimDal donemTanimDal)
        {
            _donemTanimDal = donemTanimDal;
        }

        public void Ekle(DonemTanim donemTanim)
        {
            _donemTanimDal.Add(donemTanim);
        }

        public DonemTanim Getir(int id)
        {
            return _donemTanimDal.Get(p=>p.Id==id);
        }

        public void Guncelle(DonemTanim donemTanim)
        {
            _donemTanimDal.Update(donemTanim);
        }

        public List<DonemTanim> ListeGetir()
        {
            return _donemTanimDal.GetAll();
        }

        public void Sil(int id)
        {
            _donemTanimDal.Delete(new DonemTanim { Id=id});
        }
    }
}
