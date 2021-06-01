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
    public class GrupBaskanVekilTanimService : IGrupBaskanVekilTanimService
    {
        IGrupBaskanVekilTanimDal _grupBaskanVekil;
        MeclisContext _meclisContext;

        public GrupBaskanVekilTanimService(MeclisContext meclisContext, IGrupBaskanVekilTanimDal grupBaskanVekil)
        {
            _meclisContext = meclisContext;
            _grupBaskanVekil = grupBaskanVekil;
        }

        public List<GrupBaskanVekilTanim> AdGoreGetir(string data)
        {
            throw new NotImplementedException();
        }

        public void Ekle(GrupBaskanVekilTanim data)
        {
            try
            {
                var ldata = _meclisContext.GrupBaskanTanims.FirstOrDefault(p => p.Id == data.Id);
                if (ldata != null)
                    throw new DaoException("Zaten Bu Kişi Sistemde Kayıtlıdır!.Lütfen Kontrol Ederek Tekrar Deneyiniz.");
                _grupBaskanVekil.Add(data);
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

        public GrupBaskanVekilTanim Getir(int id)
        {
            return _grupBaskanVekil.Get(p => p.Id == id);

        }

        public void Guncelle(GrupBaskanVekilTanim data)
        {
            try
            {
                var ldata = _meclisContext.GrupBaskanVekilTanims.FirstOrDefault(p => p.Id == data.Id);
                if (ldata == null)
                    throw new DaoException("Bu Kayıt Silinmiş Yada Değiştirilmiş Olabilir.Lütfen Kontrol Ederek Tekrar Deneyiniz!");

                data.EklenmeTarihi = data.EklenmeTarihi;
                data.Id = data.Id;
                _grupBaskanVekil.Update(data);
            }
            catch (DaoException ex)
            {

                throw new DaoException(ex.Message);
            }
        }

        public List<GrupBaskanVekilTanim> ListeGetir()
        {
            return _grupBaskanVekil.GetAll(p => p.Silindi == 0);

        }

        public void Sil(int id)
        {
            var data = _meclisContext.GrupBaskanVekilTanims.FirstOrDefault(p => p.Id == id);
            if (data != null && data.Silindi != 1)
            {
                data.Silindi = 1;
                _grupBaskanVekil.Delete(data);
            }
            else
            {
                throw new DaoException("Bu Kayıt Silinmiş Yada Değiştirilmiş Olabilir.Lütfen Kontrol Ederek Tekrar Deneyiniz!");
            }
        }
    }
}
