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
    public class KomisyonDurumService : IKomisyonDurumService
    {
        IKomisyonDurumDal _komisyonDurum;

        public KomisyonDurumService(IKomisyonDurumDal komisyonDurum)
        {
            _komisyonDurum = komisyonDurum;
        }

        public void Ekle(KomisyonDurum komisyonDurum)
        {
            _komisyonDurum.Add(komisyonDurum);
        }

        public KomisyonDurum Getir(int id)
        {
            return _komisyonDurum.Get(p => p.Id == id);
        }

        public void Guncelle(KomisyonDurum komisyonDurum)
        {
            _komisyonDurum.Update(komisyonDurum);
        }

        public List<KomisyonDurum> ListeGetir()
        {
            return _komisyonDurum.GetAll();
        }

        public void Sil(int id)
        {
            _komisyonDurum.Delete(new KomisyonDurum { Id = id });
        }
    }
}
