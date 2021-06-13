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
using System.Windows.Forms;

namespace MeclisDao.DaoServis
{
    public class GrupYonetimKurulUyesiService : IGrupYonetimKurulUyesiService
    {
        IGrupYonetimKurulUyesiDal _grupYonetimKurul;
        MeclisContext _meclisContext;

        public GrupYonetimKurulUyesiService(MeclisContext meclisContext, IGrupYonetimKurulUyesiDal grupYonetimKurul)
        {
            _meclisContext = meclisContext;
            _grupYonetimKurul = grupYonetimKurul;
        }

        public void Ekle(GrupYonetimKurulUyesi data)
        {
            try
            {
                var ldata = _meclisContext.GrupYonetimKurulUyesis.FirstOrDefault(p => p.Id == data.Id);
                if (ldata != null)
                    throw new DaoException("Zaten Bu Kişi Sistemde Kayıtlıdır!.Lütfen Kontrol Ederek Tekrar Deneyiniz.");
                _grupYonetimKurul.Add(data);
            }
            catch (DaoException ex)
            {

                throw new DaoException(ex.Message.ToString());
            }
        }

      

        public void Guncelle(GrupYonetimKurulUyesi data)
        {
            try
            {
                var ldata = _meclisContext.GrupYonetimKurulUyesis.FirstOrDefault(p => p.Id == data.Id);
                if (ldata == null)
                    throw new DaoException("Bu Kayıt Silinmiş Yada Değiştirilmiş Olabilir.Lütfen Kontrol Ederek Tekrar Deneyiniz!");

                data.EklenmeTarihi = data.EklenmeTarihi;
                data.Id = data.Id;
                _grupYonetimKurul.Update(data);
            }
            catch (DaoException ex)
            {

                throw new DaoException(ex.Message);
            }
        }
        public void ExceleAktar(DataGridView dataGridView)
        {
            throw new NotImplementedException();
        }

        public GrupYonetimKurulUyesi Getir(int id)
        {
            return _grupYonetimKurul.Get(p => p.Id == id);

        }
        public List<GrupYonetimKurulUyesi> ListeGetir()
        {
            return _grupYonetimKurul.GetAll(p => p.Silindi == 0);
        }

        public void Sil(int id)
        {
            var data = _meclisContext.GrupYonetimKurulUyesis.FirstOrDefault(p => p.Id == id);
            if (data != null && data.Silindi != 1)
            {
                data.Silindi = 1;
                _grupYonetimKurul.Delete(data);
            }
            else
            {
                throw new DaoException("Bu Kayıt Silinmiş Yada Değiştirilmiş Olabilir.Lütfen Kontrol Ederek Tekrar Deneyiniz!");
            }
        }
    }
}
