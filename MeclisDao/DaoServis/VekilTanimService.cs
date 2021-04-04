﻿using MeclisDao.IDaoServis;
using MeclisEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeclisDal.IDal;
using MeclisDal.BaseDb;

namespace MeclisDao.DaoServis
{
    public class VekilTanimService  : IVekilTanimService
    {
        IVekilTanimDal _vekilTanim;
        MeclisContext _meclisContext;

        public VekilTanimService(IVekilTanimDal vekilTanim, MeclisContext meclisContext)
        {
            _vekilTanim = vekilTanim;
            _meclisContext = meclisContext;
        }

        public List<VekilTanim> AdGoreGetir(string vekilAdi)
        {
            return _vekilTanim.GetAll(p => p.Ad == vekilAdi);
        }

        public void Ekle(VekilTanim vekilTanim)
        {
         //  var data = vekilTanim.Equals(null);

            if (vekilTanim!=null)
            _vekilTanim.Add(vekilTanim);
        }

        public void Guncelle(VekilTanim vekilTanim)
        {
            var data = !vekilTanim.Equals("") || !vekilTanim.Equals(null);
            if (data==false)
            {
               var IData= Getir(vekilTanim.Id);
                if(IData!=null)
                _vekilTanim.Update(vekilTanim);

            }
        }

        public List<VekilTanim> ListeGetir()
        {
          return _vekilTanim.GetAll();
        }

        public void Sil(int id)
        {
            _vekilTanim.Delete(new VekilTanim { Id = id });
        }

        public List<VekilTanim> TcNoyeGöreGetir(int tcNo)
        {
            return _vekilTanim.GetAll();
        }

       public VekilTanim Getir(int id)
        {
            return _vekilTanim.Get(p => p.Id == id);
        }

      
    }
}
