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
   public class MazeretTanimService:IMazeretTanimService
    {
        IMazeretTanimDal _mazeretTanimService;
        MeclisContext _meclisContext;
        public MazeretTanimService(IMazeretTanimDal mazeretTanimService, MeclisContext meclisContext)
        {
            _mazeretTanimService = mazeretTanimService;
            _meclisContext = meclisContext;
        }

        public List<MazeretTanim> AdGoreGetir(string data)
        {
            return _mazeretTanimService.GetAll(p=>p.MazeretNedeni.ToLower().Contains(data.ToLower()));
        }

        public void Ekle(MazeretTanim mazeretTanim)
        {
            try
            {
                var aData = _meclisContext.MazeretTanims.SingleOrDefault(p => p.BaslamaTarihi == mazeretTanim.BaslamaTarihi
                && p.BitisTarihi == mazeretTanim.BitisTarihi && p.Silindi == 0);
                if (aData != null)
                    throw new DaoException("Zaten "+mazeretTanim.BaslamaTarihi+"ve "+mazeretTanim.BitisTarihi+" arasına Tanım Oluşturulmuş! ,Lütfen Kontrol Ederek Tekrar Deneyiniz..");
               
                _mazeretTanimService.Add(mazeretTanim);
            }
            catch (DaoException ex)
            {

                throw new DaoException(ex.Message.ToString());
            }
          
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
            return _mazeretTanimService.GetAll(p=>p.Silindi==0);
        }

        public void Sil(int id)
        {
            _mazeretTanimService.Delete(new MazeretTanim { Id=id});
        }
    }
}
