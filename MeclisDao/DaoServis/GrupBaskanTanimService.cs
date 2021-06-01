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
    public class GrupBaskanTanimService : IGrupBaskanTanimService
    {
        IGrupBaskanTanimDal _grupBaskan;
        MeclisContext _meclisContext;

        public GrupBaskanTanimService(MeclisContext meclisContext, IGrupBaskanTanimDal grupBaskan)
        {
            _meclisContext = meclisContext;
            _grupBaskan = grupBaskan;
        }

        public List<GrupBaskanTanim> AdGoreGetir(string data)
        {
            throw new NotImplementedException();
        }

        public void Ekle(GrupBaskanTanim data)
        {
            try
            {
                var ldata = _meclisContext.GrupBaskanTanims.FirstOrDefault(p => p.Id == data.Id);
                if (ldata != null)
                    throw new DaoException("Zaten Bu Kişi Sistemde Kayıtlıdır!.Lütfen Kontrol Ederek Tekrar Deneyiniz.");
                _grupBaskan.Add(data);
            }
            catch (DaoException ex)
            {

                throw new DaoException(ex.Message.ToString());
            }
        }

        public void ExceleAktar(DataGridView dataGridView)
        {
            throw new NotImplementedException();
        }

        public GrupBaskanTanim Getir(int id)
        {
            return _grupBaskan.Get(p => p.Id == id);
        }

        public void Guncelle(GrupBaskanTanim data)
        {
            try
            {
                var ldata = _meclisContext.GrupBaskanTanims.FirstOrDefault(p => p.Id == data.Id);
                if (ldata == null)
                    throw new DaoException("Bu Kayıt Silinmiş Yada Değiştirilmiş Olabilir.Lütfen Kontrol Ederek Tekrar Deneyiniz!");

                data.EklenmeTarihi = data.EklenmeTarihi;
                data.Id = data.Id;
                _grupBaskan.Update(data);
            }
            catch (DaoException ex)
            {

                throw new DaoException(ex.Message);
            }
        }

        public List<GrupBaskanTanim> ListeGetir()
        {
            return _grupBaskan.GetAll(p => p.Silindi == 0);

        }

        public void Sil(int id)
        {
            var data = _meclisContext.GrupBaskanTanims.FirstOrDefault(p => p.Id == id);
            if (data != null && data.Silindi != 1)
            {
                data.Silindi = 1;
                _grupBaskan.Delete(data);
            }
            else
            {
                throw new DaoException("Bu Kayıt Silinmiş Yada Değiştirilmiş Olabilir.Lütfen Kontrol Ederek Tekrar Deneyiniz!");
            }
        }
    }
}
