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
    public class MazeretService : IMazeretService
    {
        IMazeretDal _mazeretDal;

        public MazeretService(IMazeretDal mazeretDal, MeclisContext context, IVekilTanimDal vekilTanimDal)
        {
            _mazeretDal = mazeretDal;
            _context = context;
            _vekilTanimDal = vekilTanimDal;
        }

        MeclisContext _context;
        IVekilTanimDal _vekilTanimDal;

        public void Ekle(Mazeret data)
        {
            _mazeretDal.Add(data);
        }

        public Mazeret Getir(int id)
        {
            throw new NotImplementedException();
        }

        public void Guncelle(Mazeret data)
        {
            throw new NotImplementedException();
        }

        public List<Mazeret> ListeGetir()
        {
            return _mazeretDal.GetAll(p=>p.Silindi==0);
        }

        public void Sil(int id)
        {
            throw new NotImplementedException();
        }
    }
}
