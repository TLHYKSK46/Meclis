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
    public class MeclisGorevTanimService : IMeclisGorevTanimService
    {
        IMeclisGorevTanimDal _meclisGorevTanimDal;

        public MeclisGorevTanimService(IMeclisGorevTanimDal meclisGorevTanimDal)
        {
            _meclisGorevTanimDal = meclisGorevTanimDal;
        }

        public void Ekle(MeclisGorevTanim meclisGorevTanim)
        {
            _meclisGorevTanimDal.Add(meclisGorevTanim);
        }

        public MeclisGorevTanim Getir(int id)
        {
         return   _meclisGorevTanimDal.Get(p=>p.Id==id);
        }

        public void Guncelle(MeclisGorevTanim meclisGorevTanim)
        {
            _meclisGorevTanimDal.Update(meclisGorevTanim);
        }

        public List<MeclisGorevTanim> ListeGetir()
        {
            return _meclisGorevTanimDal.GetAll();
        }

        public void Sil(int id)
        {
            _meclisGorevTanimDal.Delete(new MeclisGorevTanim {Id=id });
        }
    }
}
