using MeclisDal.BaseDb;
using MeclisDal.BaseDb.Interfaces;
using MeclisDal.Dal;
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
    public class BelgeNoService : IBelgeNoService
    {
        IBelgeNo _belgeNo;
        MeclisContext _context;
        IVekilTanimDal _vekilTanimDal;
        public BelgeNoService(MeclisContext context, IVekilTanimDal vekilTanimDal)
        {
            _belgeNo = dilTanimDal;
            _context = context;
            _vekilTanimDal = vekilTanimDal;
        }

      

        public void Ekle(BelgeNo no)
        {
            var aData = _context.DilTanims.FirstOrDefault(p=>p.Id==no.Id);
            if(aData!=null)
              throw new DaoException(no.BelgeNo1+"Dil Sistemde Kayıtlıdır,Lütfen Kontrol Ederek Tekrar Deneyiniz..");

            _belgeNo.Add(no);
        }



        public BelgeNo Getir(int id)
        {
            var data= _belgeNo.Get(p => p.Id == id && p.Silindi == 0);
            if (data == null)
                throw new DaoException("Bu Kayıt Silinmiş Yada Değiştirilmiş Olabilir.Lütfen Kontrol Ederek Tekrar Deneyiniz!");
            return data;
        }

        public void Guncelle(BelgeNo no)
        {
            var data  = _context.DilTanims.SingleOrDefault(p => p.Id == no.Id);
            if (data!=null)
            _belgeNo.Update(no);

            if (data == null)
                throw new DaoException("Bu Kayıt Silinmiş Yada Değiştirilmiş Olabilir.Lütfen Kontrol Ederek Tekrar Deneyiniz!");

        }

        public List<BelgeNo> ListeGetir()
        {
            //var vekildetay = _vekilDetayDal.GetAll();
            //(from dt in _dilTanimDal.GetAll()
            // join vd in vekildetay on dt.Id equals vd.DilTanimId
            // join vt in _vekilTanimDal.GetAll() on vd.DilTanimId equals vt.Id
            // select new 
            // {
            //     vt.TcKimlikNo,
            //    AdSoyad=vt.Ad+""+vt.Soyad,
            //    dt.DilAdi,
            // }

            // ).ToList();

            return _belgeNo.GetAll();
        }

        public void Sil(int id)
        {
            var data =  _context.BelgeNos.FirstOrDefault(p => p.Id == id);
            if (data != null && data.Silindi != 1)
            {
                data.Silindi = 1;
                Guncelle(data);

            }
            else { 
                throw new DaoException("Bu Kayıt Silinmiş Yada Değiştirilmiş Olabilir.Lütfen Kontrol Ederek Tekrar Deneyiniz!");
            }


            //_dilTanimDal.Delete(new DilTanim {Id=id });
        }
    }
}
