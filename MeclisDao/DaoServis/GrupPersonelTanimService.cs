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
    public class GrupPersonelTanimService : IGrupPersonelTanimService
    {
        IGrupPesonelTanimDal _GrupPersonel;

        public GrupPersonelTanimService(IGrupPesonelTanimDal grupPersonel)
        {
            _GrupPersonel = grupPersonel;
        }

        public void Ekle(GrupPersonelTanim grupPersonelTanim)
        {
            _GrupPersonel.Add(grupPersonelTanim);
        }

        public GrupPersonelTanim Getir(int id)
        {
            return _GrupPersonel.Get(p=>p.Id==id);
        }

        public void Guncelle(GrupPersonelTanim grupPersonelTanim)
        {
            _GrupPersonel.Update(grupPersonelTanim);
        }

        public List<GrupPersonelTanim> ListeGetir()
        {
            return _GrupPersonel.GetAll();
        }

        public void Sil(int id)
        {
            _GrupPersonel.Delete(new GrupPersonelTanim {Id=id });
        }
    }
}
