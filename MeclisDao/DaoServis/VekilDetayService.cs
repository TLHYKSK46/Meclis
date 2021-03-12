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
    public class VekilDetayService : IVekilDetayService
    {
        IVekilDetayDal _DetayDal;

        public VekilDetayService(IVekilDetayDal detayDal)
        {
            _DetayDal = detayDal;
        }

        public List<VekilDetay> AdGoreGetir(string vekilAdi)
        {
            throw new NotImplementedException();
        }

        public void Ekle(VekilDetay vekilDetay)
        {
            _DetayDal.Add(vekilDetay);
        }

        public VekilDetay Getir(int id)
        {
            return _DetayDal.Get(p=>p.Id==id);
        }

        public void Guncelle(VekilDetay vekilDetay)
        {
            _DetayDal.Update(vekilDetay);
        }

        public List<VekilDetay> ListeGetir()
        {
            return _DetayDal.GetAll();        }

        public void Sil(int id)
        {
            _DetayDal.Delete(new VekilDetay {Id=id });
        }

        public List<VekilDetay> TcNoyeGöreGetir(int tcNo)
        {
            //    return _DetayDal.GetAll(p=>p.tc);    
            return _DetayDal.GetAll() ;
        }
    }
}
