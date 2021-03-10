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
   public class MazeretTanimService:IMazeretTanimService
    {
        IMazeretTanimDal _mazeretTanimService;

        public MazeretTanimService(IMazeretTanimDal mazeretTanimService)
        {
            _mazeretTanimService = mazeretTanimService;
        }

        public void Ekle(MazeretTanim mazeretTanim)
        {
            _mazeretTanimService.Add(mazeretTanim);
        }

        public MazeretTanim Getir(int id)
        {
            return _mazeretTanimService.Get(p=>p.Id==id);
        }

        public void Guncelle(MazeretTanim mazeretTanim)
        {
            _mazeretTanimService.Update(mazeretTanim);
        }

        public List<MazeretTanim> ListeGetir()
        {
            return _mazeretTanimService.GetAll();
        }

        public void Sil(int id)
        {
            _mazeretTanimService.Delete(new MazeretTanim { Id=id});
        }
    }
}
