using MeclisDal.BaseDb;
using MeclisDal.IDal;
using MeclisDao.Exceptions;
using MeclisDao.IDaoServis;
using MeclisEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeclisDao.DaoServis
{
    public class VekilDanismanService : IVekilDanismanService
    {
        IVekilDanismanDal _vekilDanismanDal;
        MeclisContext _meclisContext;

        public VekilDanismanService(IVekilDanismanDal vekilDanismanDal, MeclisContext meclisContext)
        {
            _vekilDanismanDal = vekilDanismanDal;
            _meclisContext = meclisContext;
        }

        public void Ekle(VekilDanisman vekilDanisman)
        {
            try
            {
                var aData = _meclisContext.VekilDanismans.FirstOrDefault(p => p.Sira==vekilDanisman.Sira &&
                p.VekilTanimId == vekilDanisman.VekilTanimId&&p.DanismanTanimId==vekilDanisman.DanismanTanimId && p.Silindi == 0);

                if (aData != null)
                    throw new DaoException("Zaten  Bu  Tanımlama Yapılmıştır! ,Lütfen Kontrol Ederek Tekrar Deneyiniz..");

                _vekilDanismanDal.Add(vekilDanisman);
            }
            catch (DaoException ex)
            {

                throw new DaoException(ex.Message.ToString());
            }
         
        }

        public VekilDanisman Getir(int id)
        {
            return _vekilDanismanDal.Get(p=>p.DanismanTanimId==id);
        }

        public void Guncelle(VekilDanisman vekilDanisman)
        {
            _vekilDanismanDal.Update(vekilDanisman);
        }

        public List<VekilDanisman> ListeGetir()
        {
            return _vekilDanismanDal.GetAll(p=>p.Silindi==0);
        }

        public void Sil(int id)
        {
            _vekilDanismanDal.Delete(new VekilDanisman { Id = id });
        }
    }
}
