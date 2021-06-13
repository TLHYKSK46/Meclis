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
        public YoklamaService(IYoklamaDal yoklamaDal, MeclisContext context, IVekilTanimDal vekilTanimDal)
        {
            _yoklamaDal = yoklamaDal;
            _context = context;
            _vekilTanimDal = vekilTanimDal;
        }

     

        public void Ekle(Yoklama data)
        {
            _yoklamaDal.Add(data);
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
            throw new NotImplementedException();
        }

        public void Sil(int id)
        {
            throw new NotImplementedException();
        }
    }
}
