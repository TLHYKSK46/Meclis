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
   public class HatirlatmaTanimService:IHatirlatmaTanimService
    {
        IHatirlatmaTanimDal _hatirlatmaTanim;
        MeclisContext _Context;

        public HatirlatmaTanimService(IHatirlatmaTanimDal hatirlatmaTanim, MeclisContext context)
        {
            _hatirlatmaTanim = hatirlatmaTanim;
            _Context = context;
        }

        public void Ekle(HatirlatmaTanim hatirlatmaTanim)
        {
            try
            {
                var data = _Context.HatirlatmaTanims.FirstOrDefault(p => p.VekilTanimId == hatirlatmaTanim.VekilTanimId && p.OlusturmaTarihi == hatirlatmaTanim.OlusturmaTarihi);
                if (data != null)
                    throw new DaoException("Zaten Bu Kişi Sistemde Kayıtlıdır!.Lütfen Kontrol Ederek Tekrar Deneyiniz.");
                var kontrol= hatirlatmaTanim.HatirlatmaTarihi.Date != DateTime.Now.Date && (hatirlatmaTanim.HatirlatmaTarihi.Date > DateTime.Now.Date);
                if(!kontrol)
                    throw new DaoException("Bugün veya Eski Bir Tarihe Hatırlatma Ekleyemezsiniz!");
                _hatirlatmaTanim.Add(hatirlatmaTanim);
            }
            catch (DaoException ex)
            {

                throw new DaoException(ex.Message.ToString());
            }
           
        }

        public HatirlatmaTanim Getir(int id)
        {
            return _hatirlatmaTanim.Get(p=>p.Id==id);
        }

        public void Guncelle(HatirlatmaTanim hatirlatmaTanim)
        {
            _hatirlatmaTanim.Update(hatirlatmaTanim);
        }

        public List<HatirlatmaTanim> ListeGetir()
        {
            return _hatirlatmaTanim.GetAll();
        }

        public void Sil(int id)
        {
            _hatirlatmaTanim.Delete(new HatirlatmaTanim {Id=id});
        }
    }
}
