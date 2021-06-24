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
    public class VekilYoklamaService : IVekilYoklamaService
    {
        IVekilYoklamaDal _yoklamaDal;
        MeclisContext _context;
        IVekilTanimDal _vekilTanimDal;
        IOturumDal _oturumDal;
        public VekilYoklamaService(IVekilYoklamaDal yoklamaDal, MeclisContext context, IVekilTanimDal vekilTanimDal, IOturumDal oturumDal)
        {
            _yoklamaDal = yoklamaDal;
            _context = context;
            _vekilTanimDal = vekilTanimDal;
            _oturumDal = oturumDal;
        }

        public int BugunListele()
        {
            throw new NotImplementedException();
        }

        public void Ekle(VekilYoklama data)
        {
            _yoklamaDal.Add(data);
        }

        public List<VekilYoklama> FiltreleGetir(int id)
        {
            return _yoklamaDal.GetAll().Where(p => p.OturumId == id && p.Silindi == 0).ToList();

        }

        public VekilYoklama Getir(int id)
        {
            throw new NotImplementedException();
        }

        public void Guncelle(VekilYoklama data)
        {
            throw new NotImplementedException();
        }

        public List<VekilYoklama> ListeGetir()
        {
            return _yoklamaDal.GetAll();
        }

        public void Sil(int id)
        {
            throw new NotImplementedException();
        }
    }
}
