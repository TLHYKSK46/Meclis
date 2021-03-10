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
   public class MazeretKodService:IMazeretKodService
    {
        IMazeretKodDal _mazeretKodDal;

        public MazeretKodService(IMazeretKodDal mazeretKodDal)
        {
            _mazeretKodDal = mazeretKodDal;
        }

        public void Ekle(MazeretKod mazeretKod)
        {
            _mazeretKodDal.Add(mazeretKod);
        }

        public MazeretKod Getir(int id)
        {
            return _mazeretKodDal.Get(p=>p.Id==id);
        }

        public void Guncelle(MazeretKod mazeretKod)
        {
            _mazeretKodDal.Update(mazeretKod);
        }

        public List<MazeretKod> ListeGetir()
        {
            return _mazeretKodDal.GetAll();
        }

        public void Sil(int id)
        {
            _mazeretKodDal.Delete(new MazeretKod { Id=id});
        }
    }
}
