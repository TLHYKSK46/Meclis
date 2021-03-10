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
    public class VekilDanismanService : IVekilDanismanService
    {
        IVekilDanismanDal _vekilDanismanDal;

        public VekilDanismanService(IVekilDanismanDal vekilDanismanDal)
        {
            _vekilDanismanDal = vekilDanismanDal;
        }

        public void Ekle(VekilDanisman vekilDanisman)
        {
            _vekilDanismanDal.Add(vekilDanisman);
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
            return _vekilDanismanDal.GetAll();
        }

        public void Sil(VekilDanisman vekilDanisman)
        {
            _vekilDanismanDal.Delete(vekilDanisman);
        }
    }
}
