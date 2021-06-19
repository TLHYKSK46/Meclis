using MeclisDal.BaseDb;
using MeclisDal.BaseDb.Interfaces;
using MeclisDal.Dal;
using MeclisDal.IDal;
using MeclisDao.Exceptions;
using MeclisDao.IDaoServis;
using MeclisEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeclisDao.DaoServis
{
    public class OturumService : IOturumService
    {
        IOturumDal _oturumDal;
        MeclisContext _context;
        IVekilTanimDal _vekilTanimDal;

        public OturumService(IVekilTanimDal vekilTanimDal, IOturumDal oturumDal)
        {
            _vekilTanimDal = vekilTanimDal;
            _oturumDal = oturumDal;
        }

        public void Ekle(Oturum data)
        {
            
            _oturumDal.Add(data);
        }

        public List<Oturum> FiltreleGetir(DateTime tarih)
        {
            return _oturumDal.GetAll(p=>p.OturumZamani==tarih);

        }

        public Oturum Getir(int id)
        {
            return _oturumDal.Get(p => p.Id == id);
        }

        public void Guncelle(Oturum data)
        {
            throw new NotImplementedException();
        }

        public List<Oturum> ListeGetir()
        {
            return _oturumDal.GetAll();
        }

        public void Sil(int id)
        {
            throw new NotImplementedException();
        }

        public int  SonKayitId()
        {
        return  _oturumDal.GetAll().Max(u=>u.Id);

        }
    }
}
