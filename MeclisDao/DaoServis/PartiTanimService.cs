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
    public class PartiTanimService : IPartiTanimService
    {
        IPartiTanimDal _partiTanimDal;

        public PartiTanimService(IPartiTanimDal partiTanimDal)
        {
            _partiTanimDal = partiTanimDal;
        }

        public void Ekle(PartiTanim partiTanim)
        {
            _partiTanimDal.Add(partiTanim);
        }

        public PartiTanim Getir(int id)
        {
            return _partiTanimDal.Get(p => p.Id == id);
        }

        public void Guncelle(PartiTanim partiTanim)
        {
            _partiTanimDal.Update(partiTanim);
        }

        public List<PartiTanim> ListeGetir()
        {
            return _partiTanimDal.GetAll();
        }

        public void Sil(int id)
        {
            _partiTanimDal.Delete(new PartiTanim { Id = id });
        }
    }
}
