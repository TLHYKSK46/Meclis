using MeclisEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeclisDao.IDaoServis
{
    public interface IIITanimService
    {
        List<IlTanim> ListeGetir();
        IlTanim Getir(int id);
        //List<CinsiyetTanim> AdGoreGetir(string productName);
        void Ekle(IlTanim ilTanim);
        void Guncelle(IlTanim ilTanim);
        void Sil(IlTanim ilTanim);
    }
}
