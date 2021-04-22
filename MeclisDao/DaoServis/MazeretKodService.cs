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
   public class MazeretKodService:IMazeretKodService
    {
        IMazeretKodDal _mazeretKodDal;
        MeclisContext _meclisContext;
        public MazeretKodService(IMazeretKodDal mazeretKodDal, MeclisContext meclisContext)
        {
            _mazeretKodDal = mazeretKodDal;
            _meclisContext = meclisContext;
        }

        public void Ekle(MazeretKod mazeretKod)
        {
            try
            {
                var aData = _meclisContext.MazeretKods.FirstOrDefault(p =>p.MazeretKodu==mazeretKod.MazeretKodu && p.Silindi == 0);
                if (aData != null)
                    throw new DaoException(" Sistemde Kayıtlıdır,Lütfen Kontrol Ederek Tekrar Deneyiniz..");
               
                _mazeretKodDal.Add(mazeretKod);
            }
            catch (DaoException ex)
            {

                throw new DaoException(ex.Message.ToString());
            }
           
        }

        public MazeretKod Getir(int id)
        {
            return _mazeretKodDal.Get(p=>p.Id==id);
        }

        public void Guncelle(MazeretKod mazeretKod)
        {
            try
            {
                var data = _meclisContext.MazeretKods.FirstOrDefault(p => p.Id == mazeretKod.Id);
                if (data == null)
                    throw new DaoException("Bu Kayıt Silinmiş Yada Değiştirilmiş Olabilir.Lütfen Kontrol Ederek Tekrar Deneyiniz!");

                mazeretKod.EklenmeTarihi = data.EklenmeTarihi;
                mazeretKod.Id = data.Id;
                _mazeretKodDal.Update(mazeretKod);
            }
            catch (DaoException ex)
            {

                throw new DaoException(ex.Message);
            }

         
        }

        public List<MazeretKod> ListeGetir()
        {
            return _mazeretKodDal.GetAll();
        }

        public void Sil(int id)
        {
            var data = _meclisContext.MazeretKods.FirstOrDefault(p => p.Id == id);
            if (data != null && data.Silindi != 1)
            {
                data.Silindi = 1;
                _mazeretKodDal.Delete(data);


            }
            else
            {
                throw new DaoException("Bu Kayıt Silinmiş Yada Değiştirilmiş Olabilir.Lütfen Kontrol Ederek Tekrar Deneyiniz!");
            }
          //  _mazeretKodDal.Delete(new MazeretKod { Id=id});
        }
    }
}
