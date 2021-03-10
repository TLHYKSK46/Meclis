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
    public class DanismanTanimService : IDanismanTanimService
    {
        IDanismanTanimDal _danismanTanimDal;

        public DanismanTanimService(IDanismanTanimDal danismanTanimDal)
        {
            _danismanTanimDal = danismanTanimDal;
        }

        public List<DanismanTanim> AdGoreGetir(string DanismanAdi)
        {
            return _danismanTanimDal.GetAll(p => p.Ad == DanismanAdi);
        }

        public void Ekle(DanismanTanim danismanTanim)
        {
            _danismanTanimDal.Add(danismanTanim);
        }

        public DanismanTanim Getir(int id)
        {
            return _danismanTanimDal.Get(p=>p.Id==id);
        }

        public void Guncelle(DanismanTanim danismanTanim)
        {
            _danismanTanimDal.Update(danismanTanim);
        }

        public List<DanismanTanim> ListeGetir()
        {
            return _danismanTanimDal.GetAll();
        }

        public void Sil(int id)
        {
            _danismanTanimDal.Delete(new DanismanTanim {Id=id });
        }
    }
}
