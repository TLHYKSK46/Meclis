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
    public class MasaOturumDuzenService : IMasaOturumDuzenService
    {
        IMasaOturmaDuzenDal _masaduzen;
        MeclisContext _context;
        IVekilTanimDal _vekilTanimDal;
        public MasaOturumDuzenService(MeclisContext context, IVekilTanimDal vekilTanimDal, IMasaOturmaDuzenDal masaduzen)
        {
            _masaduzen = masaduzen;
            _context = context;
            _vekilTanimDal = vekilTanimDal;
        }

        public void Ekle(MasaOturmaDuzen data)
        {
            _masaduzen.Add(data);
        }

        public MasaOturmaDuzen Getir(int id)
        {
            throw new NotImplementedException();
        }

        public void Guncelle(MasaOturmaDuzen data)
        {
            throw new NotImplementedException();
        }

        public List<MasaOturmaDuzen> ListeGetir()
        {
           return _masaduzen.GetAll(x => x.Silindi == 0).ToList();
        }

        public void Sil(int id)
        {
            throw new NotImplementedException();
        }
    }
}
