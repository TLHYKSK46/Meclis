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
    public class KomisyonTanimService : IKomisyonTanimService
    {
        IKomisyonTanimDal _komisyonTanim;

        public KomisyonTanimService(IKomisyonTanimDal komisyonTanim)
        {
            _komisyonTanim = komisyonTanim;
        }

        public void Ekle(KomisyonTanim komisyonTanim)
        {
            _komisyonTanim.Add(komisyonTanim);
        }

        public KomisyonTanim Getir(int id)
        {
            return _komisyonTanim.Get(p=>p.Id==id);
        }

        public void Guncelle(KomisyonTanim komisyonTanim)
        {
            _komisyonTanim.Update(komisyonTanim);
        }

        public List<KomisyonTanim> ListeGetir()
        {
            return _komisyonTanim.GetAll();
        }

        public void Sil(int id)
        {
            _komisyonTanim.Delete(new KomisyonTanim { Id=id});
        }
    }
}
