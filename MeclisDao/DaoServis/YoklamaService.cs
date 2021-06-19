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
    public class YoklamaService : IYoklamaService
    {
        IYoklamaDal _yoklamaDal;
        MeclisContext _context;
        IVekilTanimDal _vekilTanimDal;
        IOturumDal _oturumDal;
        public YoklamaService(IYoklamaDal yoklamaDal, MeclisContext context, IVekilTanimDal vekilTanimDal, IOturumDal oturumDal)
        {
            _yoklamaDal = yoklamaDal;
            _context = context;
            _vekilTanimDal = vekilTanimDal;
            _oturumDal = oturumDal;
        }

        public int BugunListele()
        {
            return _yoklamaDal.GetAll().Max(p=>p.Id);
        }

        public void Ekle(Yoklama data)
        {
            _yoklamaDal.Add(data);
        }

        public List<Yoklama> FiltreleGetir(int id)
        {
          //  //var vekildetay = _yoklamaDal.GetAll();
          //var data=  (from dt in _yoklamaDal.GetAll()
          //  // join o in _oturumDal.GetAll() on dt.OturumId equals o.Id
          //   select new
          //   {
          //       dt.Id,
          //       dt.AdSoyad,
          //       dt.Il,
          //       dt.Katildi,
          //       dt.Mazeret,
          //       dt.Pusulali,
          //       //o.OturumAdi,
          //       dt.OturumId
          //   }

          //   ).ToList().Where(p => p.OturumId == id);
            return _yoklamaDal.GetAll().Where(p=>p.OturumId==id && p.Silindi==0).ToList();
           
        }

        public Yoklama Getir(int id)
        {
            throw new NotImplementedException();
        }

        public void Guncelle(Yoklama data)
        {
            throw new NotImplementedException();
        }

        public List<Yoklama> ListeGetir()
        {
           return _yoklamaDal.GetAll(p=>p.Silindi==0);
        }

        public void Sil(int id)
        {
            throw new NotImplementedException();
        }
    }
}
