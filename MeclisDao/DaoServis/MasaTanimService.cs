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
    public class MasaTanimService : IMasaTanimService
    {
        IMasaTanimDal _masaTanim;
        MeclisContext _context;
        IVekilTanimDal _vekilTanimDal;
        public MasaTanimService(MeclisContext context, IVekilTanimDal vekilTanimDal, IMasaTanimDal masaTanim)
        {
            _masaTanim = masaTanim;
            _context = context;
            _vekilTanimDal = vekilTanimDal;
        }

        public void Ekle(MasaTanim data)
        {
            _masaTanim.Add(data);
        }

        public MasaTanim Getir(int id)
        {
            throw new NotImplementedException();
        }

        public void Guncelle(MasaTanim data)
        {
            throw new NotImplementedException();
        }

        public List<MasaTanim> ListeGetir()
        {
           return _masaTanim.GetAll(p=>p.Silindi==0) ;
        }

        public void Sil(int id)
        {
            throw new NotImplementedException();
        }
    }
}
