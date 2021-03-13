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
    public class MeslekTanimService : IMeslekTanimService
    {
        IMeslekTanimDal _meslekTanim;

        public MeslekTanimService(IMeslekTanimDal meslekTanim)
        {
            _meslekTanim = meslekTanim;
        }

        public void Ekle(MeslekTanim Data)
        {
            _meslekTanim.Add(Data);
        }

        public MeslekTanim Getir(int id)
        {
            return _meslekTanim.Get(p=>p.Id==id);
        }

        public void Guncelle(MeslekTanim Data)
        {
            _meslekTanim.Update(Data);
        }

        public List<MeslekTanim> ListeGetir()
        {
            return _meslekTanim.GetAll();
        }

        public void Sil(int id)
        {
            _meslekTanim.Delete(new MeslekTanim {Id=id});
        }
    }
}
